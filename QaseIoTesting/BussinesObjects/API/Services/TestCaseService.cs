using Core;
using Core.API;
using Core.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects.API.Services
{
    public class TestCaseService : BaseService
    {
        public string TestCaseEndpoint = "/case/{code}";
        public string TestCaseByCodeIdEndpoint = "/case/{code}/{id}";

        public TestCaseService() : base(AppConfiguration.Api.BaseUrl) { }
        public RestResponse DeleteTestCase(ProjectModel project, int id)
        {
            var request = new RestRequest(TestCaseByCodeIdEndpoint, Method.Delete).AddUrlSegment("code", project.Code);
            request.AddUrlSegment("id", id);
            return apiClient.Execute(request);
        }
        public RestResponse GetAllTestCases(ProjectModel project)
        {
            var request = new RestRequest(TestCaseEndpoint, Method.Get).AddUrlSegment("code", project.Code);
            return apiClient.Execute(request);
        }
        public RestResponse CreateTestCase(ProjectModel project, TestCaseModel testCase)
        {
            var request = new RestRequest(TestCaseEndpoint, Method.Post).AddUrlSegment("code", project.Code);
            request.AddBody(testCase);
            return apiClient.Execute(request);
        }
    }
}
