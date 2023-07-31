using BussinesObjects.API.RestEntities;
using Core.Selenium.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects.UI.Pages
{
    public class TestRepoPage : BasePage
    {
        private Button newCaseButton = new(By.XPath("//a[@id='create-case-button']"));
        public TestRepoPage NewCaseWindow()
        {
            logger.Info($"[GUI] Вызываем окно создания нового тест кейса");
            newCaseButton.GetElement().Click();
            return this;
        }
    }
}
