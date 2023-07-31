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
    public class BasePage
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static By projectMenuLinkLocator = By.XPath("//a[@href='/projects']"); 
        public static By workspaceMenuLinkLocator = By.XPath("//a[@href='/workspace']"); 
        private MenuLink projectMenuLink = new(projectMenuLinkLocator);
        private MenuLink workspaceMenuLink = new(workspaceMenuLinkLocator);

    }
}
