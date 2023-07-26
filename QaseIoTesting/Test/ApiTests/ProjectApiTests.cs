using Allure.Commons;
using BussinesObjects.API.Services;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApiTests
{

    public class ProjectApiTests : ApiAuthTests
    {

        [Test]
        [AllureDescription("QIT-4 Get project information by code")]
        [AllureLink("https://app.qase.io/case/QIT-4")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Alexander Starostin")]
        [Category("API")]
        public void GetProjectByCode()
        {
            var projectCode = "DEMO";

            var project = apiProjectSteps.GetProjectByCode(projectCode);

            Assert.IsTrue(project.Title == "Demo Project");
            Assert.IsTrue(project.Code == "DEMO");
            Assert.IsTrue(project.Counts.Cases == 10);
            Assert.IsTrue(project.Counts.Suites == 3);
            Assert.IsTrue(project.Counts.Milestones == 2);
        }
    }
}
