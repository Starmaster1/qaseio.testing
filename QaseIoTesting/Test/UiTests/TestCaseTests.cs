using Allure.Commons;
using BussinesObjects;
using BussinesObjects.UI.Pages;
using BussinesObjects.UI.Steps;
using Core.Selenium;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiTests
{
    public class TestCaseTests : BaseTest
    {
        [Test]
        [Category("UI")]
        [AllureDescription("QIT-8 Create new test-case")]
        [AllureLink("https://app.qase.io/case/QIT-8")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        public void NewTestCase()
        {
            var user = UserBuilder.GetStandartUser();
            var project = ProjectBuilder.GetStandartProject();
            var testCase = TestCaseBuilder.GetRandomTestCase();
            UISteps.Login(user);
            UISteps.OpenProject(project);
            new TestRepoPage().NewCaseWindow();
            new CreateTestCasePage().CreateTestCase(testCase);
        }
    }
}
