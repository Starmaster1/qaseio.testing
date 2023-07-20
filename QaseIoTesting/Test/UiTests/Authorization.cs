﻿using Allure.Commons;
using BussinesObjects;
using BussinesObjects.UI.Pages;
using Core.Selenium;
using NLog;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiTests
{
    public class Authorization : BaseTest
    {
        [Test]
        [AllureDescription("QIT-1 Login to qase.io as standard user")]
        [AllureLink("https://app.qase.io/case/QIT-1")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        public void LoginStandartUser()
        {
            var user = UserBuilder.GetStandartUser();
            
            new LoginPage()
                .OpenPage()
                .Login(user);
            WaitHelper.WaitElement(driver,By.XPath("//a[@href='/projects']"));
            Assert.That(Browser.Instance.GetCurrentUrl(), Is.EqualTo("https://app.qase.io/projects"));
        }
        [Test]
        [AllureDescription("QIT-2 Login to qase.io as standard user with wrong password")]
        [AllureLink("https://app.qase.io/case/QIT-2")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        public void LoginWrongPassword()
        {
            var user = UserBuilder.GetStandartUser();
            user.Password = "WrongPa$$w0rd1";

            new LoginPage()
                .OpenPage()
                .Login(user);
            Assert.NotNull(Browser.Instance.Driver.FindElement(By.XPath("//*[text()='These credentials do not match our records.']")));
        }

    }
}