using Allure.Commons;
using BussinesObjects;
using BussinesObjects.UI.Pages;
using BussinesObjects.UI.Steps;
using Core;
using Core.Selenium;
using NUnit.Allure.Attributes;

namespace Test.UiTests
{

    public class AuthorizationTests : BaseTest
    {
        [Test]
        [Category("UI")]
        [AllureDescription("QIT-1 Login to qase.io as standard user")]
        [AllureLink("https://app.qase.io/case/QIT-1")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        public void LoginStandartUser()
        {
            var user = UserBuilder.GetStandartUser();
            UISteps.Login(user);

            WaitHelper.WaitElement(Browser.Instance.Driver, LoginPage.projectMenuLinkLocator);
            Assert.That(Browser.Instance.GetCurrentUrl(), Is.EqualTo("https://app.qase.io/projects"));
        }
        [Test]
        [Category("UI")]
        [AllureDescription("QIT-2 Login to qase.io as standard user with wrong password")]
        [AllureLink("https://app.qase.io/case/QIT-2")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        public void LoginWrongPassword()
        {
            var user = UserBuilder.GetStandartUser();
            user.Password = "adsfvc@43f#2";
            UISteps.Login(user);
            Assert.NotNull(Browser.Instance.Driver.FindElement(LoginPage.msgWrongPassLocator));
        }
        [Test]
        [Category("UI")]
        [AllureDescription("QIT-3 Login to qase.io as standard user with simple password")]
        [AllureLink("https://app.qase.io/case/QIT-3")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Alexander Starostin")]
        public void LoginSimplePassword()
        {
            var user = UserBuilder.GetStandartUser();
            user.Password = "12345";

            UISteps.Login(user);
            Assert.NotNull(Browser.Instance.Driver.FindElement(LoginPage.msgSimplePassLocator));
            WaitHelper.WaitElement(Browser.Instance.Driver, LoginPage.resetPswdButtonLocator);
        }

    }
}
