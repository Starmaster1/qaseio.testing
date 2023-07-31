using Core.Selenium.Elements;
using OpenQA.Selenium;

namespace BussinesObjects.UI.Pages
{
    public class CreateProjectModal
    {
        Input projectName = new("project-name");
        Input projectCode = new("project-code");
        Input projectdescription = new("description-area");
        RadioButton privateRadioButton = new("public");
        RadioButton publicRadioButton = new("private");
        RadioButton allRadioButton = new("all");
        RadioButton groupRadioButton = new("group");
        RadioButton noneRadioButton = new("none");
        Button submitButton = new(By.XPath("//button[@type='submit']"));
        Button cancelButton = new(By.XPath("//button[@type='button']"));

        public void CreateProject(string name, string accessType, string memberAccess)
        {
            projectName.GetElement().SendKeys(name);
            switch (accessType)
            {
                case "public":
                    publicRadioButton.GetElement().Click();
                    break;
                case "private":
                    privateRadioButton.GetElement().Click();
                    break;
                default:
                    privateRadioButton.GetElement().Click();
                    break;
            }

            switch (memberAccess)
            {
                case "all":
                    allRadioButton.GetElement().Click();
                    break;
                case "group":
                    groupRadioButton.GetElement().Click();
                    break;
                case "none":
                    noneRadioButton.GetElement().Click();
                    break;
                default:
                    allRadioButton.GetElement().Click();
                    break;
            }
            submitButton.GetElement().Click();

        }
    }
}
