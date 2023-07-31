using Allure.Commons;
using BussinesObjects;
using NUnit.Allure.Attributes;

namespace Test.ApiTests
{

    public class ProjectApiTests : ApiAuthTests
    {

        [Test]
        [AllureDescription("QIT-4 Get projectResponse information by code")]
        [AllureLink("https://app.qase.io/case/QIT-4")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        [Category("API")]
        public void GetProjectByCode()
        {
            var project = ProjectBuilder.GetStandartProject(); 

            var projectResponse = apiProjectSteps.GetProjectByCode(project.Code);

            Assert.IsTrue(projectResponse.Title == project.Title);
            Assert.IsTrue(projectResponse.Code == project.Code);
        }
    }
}
