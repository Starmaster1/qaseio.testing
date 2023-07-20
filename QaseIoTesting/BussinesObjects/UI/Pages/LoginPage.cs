using Core;
using Core.Selenium;
using Core.Selenium.Elements;
using NLog;
using NUnit.Allure.Attributes;
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
    public class LoginPage
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private Input userNameInput = new(By.XPath("//input[@placeholder='E-Mail']"));
        private Input passwordInput = new(By.XPath("//input[@placeholder='Password']"));
        private Button loginButton = new(By.XPath("//button[@type='submit']"));

        [AllureStep("Открываем страницу авторизации")]
        public LoginPage OpenPage()
        {
            Browser.Instance.NavigateToUrl("https://app.qase.io/login");
            return this;
        }
        [AllureStep("Вводим e-mail и пароль")]

        public LoginPage Login(UserModel user)
        {
            logger.Info("Вводим e-mail и пароль");
            userNameInput.GetElement().SendKeys(user.Name);
            passwordInput.GetElement().SendKeys(user.Password);
            loginButton.GetElement().Click();
            return this;
        }

    }
}
