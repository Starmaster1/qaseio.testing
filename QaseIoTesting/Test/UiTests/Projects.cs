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

namespace Test.UiTests
{
    public class Projects : BaseTest
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
                .CreateProject(projectTitle, "public","all");
            var projectResponse = new ApiProjectSteps().GetProjectByCode(projectCode);
            var delPrjResponse = new ApiProjectSteps().DeleteProjectByCode(projectCode);
            Assert.IsTrue(projectTitle == projectResponse.Title);
        }
        //[Test] //Не готов пока
        //[Category("UI")]
        //[AllureDescription("QIT-6 Edit project")]
        //[AllureLink("https://app.qase.io/case/QIT-6")]
        //[AllureSeverity(SeverityLevel.critical)]
        //[AllureOwner("Alexander Starostin")]
        //public void EditProject()
        //{
        //    var user = UserBuilder.GetStandartUser();
        //    var projectTitle = "Demo Project";
        //    var projectCode = "DEMO";
        //    UISteps.Login(user);

        //    new ProjectPage()
        //        .CreateProject();
        //    new CreateProjectModal()
        //        .CreateProject(projectTitle, "public", "all");
        //    var projectResponse = new ApiProjectSteps().GetProjectByCode(projectCode);
        //    var delPrjResponse = new ApiProjectSteps().DeleteProjectByCode(projectCode);
        //    Assert.IsTrue(projectTitle == projectResponse.Title);
        //}

        [Test] //Не готов пока
        [Category("UI")]
        [AllureDescription("QIT-7 Delete project")]
        [AllureLink("https://app.qase.io/case/QIT-7")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        public void DeleteProject()
        {
            var user = UserBuilder.GetStandartUser();
            var projectTitle = "Project to delete";
            var projectCode = "PTD";
            UISteps.Login(user);

            new ProjectPage()
                .DeleteProject(projectTitle);
            new DeleteProjectModal()
                .Delete();
            Browser.Instance.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //var projectResponse = new ApiProjectSteps().CheckProjectByCode(projectCode);
            //Assert.IsNull(projectResponse.Title);
        }

    }
}
