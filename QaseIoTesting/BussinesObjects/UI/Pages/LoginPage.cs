using Core;
using Core.Selenium;
using Core.Selenium.Elements;
using OpenQA.Selenium;


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
        private string url = "https://app.qase.io/login";
        public LoginPage OpenPage()
        {
            logger.Info($"Переходим на страцицу {url}");
            Browser.Instance.NavigateToUrl(url);
            return this;
        }
        public LoginPage Login(UserModel user)
        {
            logger.Info($"Вводим e-mail {user.Name} и пароль {user.Password}");
            userNameInput.GetElement().SendKeys(user.Name);
            passwordInput.GetElement().SendKeys(user.Password);
            loginButton.GetElement().Click();
            return this;
        }

    }
}
