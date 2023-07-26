using Core.API;
using Core.Configuration;
using Microsoft.Extensions.Configuration;

namespace Test.ApiTests
{
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