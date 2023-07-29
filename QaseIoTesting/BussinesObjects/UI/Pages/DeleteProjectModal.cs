using Core.Selenium.Elements;
using OpenQA.Selenium;

namespace BussinesObjects.UI.Pages
{
    public class DeleteProjectModal
    {
        Button deleteButton = new(By.XPath("//span[text()='Delete project']/ancestor::button[@type='button']"));
        Button cancelButton = new(By.XPath("//span[text()='Cancel']/ancestor::button[@type='button']"));
        public void Delete() { 
            deleteButton.GetElement().Click();
        }
        public void Cancel()
        {
            cancelButton.GetElement().Click();
        }
    }
}
