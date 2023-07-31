using Core.Selenium;
using Core.Selenium.Elements;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BussinesObjects.UI.Pages
{
    [AllureNUnit]
    public class ProjectPage : BasePage
    {
        private Input searchProjectsInput = new(By.XPath("//input[@placeholder='Search for projects']"));
        private Button createProjectButton = new(By.XPath("//button[@id='createButton']"));
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
    }
}
