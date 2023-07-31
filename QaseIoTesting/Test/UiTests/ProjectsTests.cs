using Allure.Commons;
using BussinesObjects;
using BussinesObjects.UI.Pages;
using Core.Selenium;
using NUnit.Allure.Attributes;
using BussinesObjects.API.Steps;
using BussinesObjects.API.Services;
using Core.Configuration;
using Test.ApiTests;
using BussinesObjects.UI.Steps;
using OpenQA.Selenium.Support.UI;
using BussinesObjects.API.RestEntities;
using Core;

namespace Test.UiTests
{
    public class ProjectsTests : BaseTest
    {
        [Test]
        [Category("UI")]
        [AllureDescription("QIT-5 Create project")]
        [AllureLink("https://app.qase.io/case/QIT-5")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        public void CreateProject()
        {
            var user = UserBuilder.GetStandartUser();
            var projectTitle = "Sasha`s project name";
            var projectCode = "SSPN";
            UISteps.Login(user);

            new ProjectPage()
                .CreateProject();
            new CreateProjectModal()
                .CreateProject(projectTitle, "public", "all");
            var projectResponse = new ApiProjectSteps().GetProjectByCode(projectCode);
            var delPrjResponse = new ApiProjectSteps().DeleteProjectByCode(projectCode);
            Assert.IsTrue(projectTitle == projectResponse.Title);
        }
        [Test]
        [Category("UI")]
        [AllureDescription("QIT-6 Edit project")]
        [AllureLink("https://app.qase.io/case/QIT-6")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        public void EditProject()
        {
            var user = UserBuilder.GetStandartUser();
            var project = ProjectBuilder.GetRandomProject();
            var newProjectResponse = new ApiProjectSteps().CreateProject(project);
            UISteps.Login(user);
            new ProjectPage()
                 .EditProject(project.Title);
            project.Title = "Edited Project";
            project.Code = "EDP";
            project.Description = "Edited project description";
            new EditProgectPage()
                .GeneralSettingsProject(project, "public");
            var projectResponse = new ApiProjectSteps().GetProjectByCode(project.Code);
            Assert.IsTrue(projectResponse.Title == project.Title);
            var delPrjResponse = new ApiProjectSteps().DeleteProjectByCode(project.Code);
        }

        [Test]
        [Category("UI")]
        [AllureDescription("QIT-7 Delete project")]
        [AllureLink("https://app.qase.io/case/QIT-7")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        public void DeleteProject()
        {
            var user = UserBuilder.GetStandartUser();
            UISteps.Login(user);
            var newProject = ProjectBuilder.GetRandomProject();

            new ApiProjectSteps().CreateProject(newProject);
            new ProjectPage()
                .DeleteProject(newProject.Title);
            new DeleteProjectModal()
                .Delete();
            var projectResponse = new ApiProjectSteps().CheckProjectByCode(newProject.Code);
            Assert.IsTrue(projectResponse == "Not Found");
        }

    }
}
