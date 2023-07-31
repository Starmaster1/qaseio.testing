using Core;
using Core.Selenium.Elements;
using NUnit.Allure.Core;
using OpenQA.Selenium;

namespace BussinesObjects.UI.Pages
{
    public class ProjectPage : BasePage
    {
        private Input searchProjectsInput = new(By.XPath("//input[@placeholder='Search for projects']"));
        private Button createProjectButton = new(By.XPath("//button[@id='createButton']"));
        private Button projectButton;
        private DropDownProject threeDotDropDown;

        public ProjectPage CreateProject()
        {
            logger.Info("Нажимаем кнопку Create new project");
            createProjectButton.GetElement().Click();
            return this;
        }
        public ProjectPage DeleteProject(string project)
        {
            logger.Info("Удаляем проект");
            threeDotDropDown = new(project);
            threeDotDropDown.ClickElementViaJs();
            threeDotDropDown.Select("Delete");
            return this;
        }
        public ProjectPage EditProject(string project)
        {
            logger.Info("Редактируем проект");
            threeDotDropDown = new(project);
            threeDotDropDown.ClickElementViaJs();
            threeDotDropDown.Select("Settings");
            return this;
        }
        public ProjectPage OpenProject(ProjectModel project)
        {
            logger.Info($"Открываем проект '{project.Title}'");
            projectButton = new(By.XPath($"//a[text()='{project.Title}']"));
            projectButton.GetElement().Click();
            return this;
        }
    }
}
