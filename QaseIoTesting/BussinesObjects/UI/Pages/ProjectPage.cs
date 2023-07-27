using Core.Selenium.Elements;
using NLog;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects.UI.Pages
{
    [AllureNUnit]
    public class ProjectPage : BasePage
    {
        private Input passwordInput = new(By.XPath("//input[@placeholder='Password']"));
        private Button loginButton = new(By.XPath("//button[@type='submit']"));
    }
}
