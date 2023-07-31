using Allure.Commons;
using Core;
using Core.Selenium.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects.UI.Pages
{
    public class CreateTestCasePage : BasePage
    {
        private Input titleInput = new("title");
        private Input descriptionInput = new(By.XPath("//div[@class='toastui-editor ww-mode']"));
        private Button saveButton = new(By.XPath("//button[@id='save-case']"));

        public CreateTestCasePage CreateTestCase(TestCaseModel testCase)
        {
            titleInput.GetElement().SendKeys(testCase.Title);
            saveButton.GetElement().Click();
            return this;
        }
    }
}
