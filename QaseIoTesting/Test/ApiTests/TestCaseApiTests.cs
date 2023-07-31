using Allure.Commons;
using BussinesObjects;
using NUnit.Allure.Attributes;

namespace Test.ApiTests
{
    public class TestCaseApiTests : ApiAuthTests
    {
        [Test]
        [AllureDescription("QIT-9 Get all test-cases in project by code")]
        [AllureLink("https://app.qase.io/case/QIT-9")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        [Category("API")]
        public void GetAllTestCases()
        {
            var project = ProjectBuilder.GetStandartProject();
            bool successs = false;
            Assert.IsTrue(apiTestCaseSteps.GetAllTestCases(project).Result.Entities.Capacity > 0);
        }

        [Test]
        [AllureDescription("QIT-x Create test-case in project by code")]
        [AllureLink("https://app.qase.io/case/QIT-x")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        [Category("API")]
        public void CreateTestCase()
        {
            var project = ProjectBuilder.GetStandartProject();
            var newTestCase = TestCaseBuilder.GetRandomTestCase();
            var testCaseResponse = apiTestCaseSteps.CreateTestCase(project, newTestCase);
            bool successs = false;
            foreach (var testCase in apiTestCaseSteps.GetAllTestCases(project).Result.Entities)
            {
                if (testCase.Title == newTestCase.Title)
                {
                    successs = true; break;
                };
            }
            Assert.IsTrue(successs);
        }
        [Test]
        [AllureDescription("QIT-10 Delete test-case in project by code")]
        [AllureLink("https://app.qase.io/case/QIT-x")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        [Category("API")]
        public void DeleteTestCase()
        {
            var project = ProjectBuilder.GetStandartProject();
            bool successs = false;
            var testCaseResponse = apiTestCaseSteps.GetAllTestCases(project).Result.Entities.First();
            var deleteTCResponse = apiTestCaseSteps.DeleteTestCase(project, testCaseResponse.Id);
            var checkAllTCResponse = apiTestCaseSteps.GetAllTestCases(project).Result.Entities;
            foreach (var testCase in checkAllTCResponse)
            {
                if (testCase.Id == testCaseResponse.Id)
                {
                successs = true; break;
                }
            }
            Assert.IsFalse(successs);
        }
    }
}
