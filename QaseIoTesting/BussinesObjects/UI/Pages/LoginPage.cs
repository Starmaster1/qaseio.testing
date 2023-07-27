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
    public class LoginPage : BasePage
    {

        public static By msgWrongPassLocator = By.XPath("//*[text()='These credentials do not match our records.']");
        public static By msgSimplePassLocator = By.XPath("//*[text()[contains(.,'Security notice:')]]");
        public static By resetPswdButtonLocator = By.XPath("//button[@type='submit']/*[text()='Send password reset link']");

        private Input userNameInput = new(By.XPath("//input[@placeholder='E-Mail']"));
        private Input passwordInput = new(By.XPath("//input[@placeholder='Password']"));
        private Button loginButton = new(By.XPath("//button[@type='submit']"));
        private Button resetPswdButton = new(resetPswdButtonLocator);

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
