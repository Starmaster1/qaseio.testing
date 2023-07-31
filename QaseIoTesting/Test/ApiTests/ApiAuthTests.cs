using BussinesObjects.API.Services;
using BussinesObjects.API.Steps;
using Core.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ApiTests
{
    public class ApiAuthTests : BaseApiTest
    {
        protected ProjectService projectService;
        protected ApiProjectSteps apiProjectSteps;
        protected ApiTestCaseSteps apiTestCaseSteps;

        [OneTimeSetUp]
        public void SetUp()
        {
            projectService = new ProjectService();
            apiProjectSteps = new ApiProjectSteps();
            apiTestCaseSteps = new ApiTestCaseSteps();
        }

        [OneTimeSetUp]
        public void InitialService()
        {
            apiClient.AddToken(AppConfiguration.Api.Token);
        }
    }
}
