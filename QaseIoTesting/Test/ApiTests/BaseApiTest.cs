using Core.API;
using Core.Configuration;
using Microsoft.Extensions.Configuration;
using NUnit.Allure.Core;

namespace Test.ApiTests
{
    [TestFixture]
    [AllureNUnit]
    public class BaseApiTest
    {
        protected BaseApiClient apiClient;

        [OneTimeSetUp]
        public void InitApiClient()
        {
            apiClient = new BaseApiClient(AppConfiguration.Api.BaseUrl);
        }
    }
}