using BussinesObjects.API.RestEntities;
using BussinesObjects.API.Services;
using Core;
using Newtonsoft.Json;
using System.Net;

namespace BussinesObjects.API.Steps
{
    public class ApiTestCaseSteps : TestCaseService
    {
        public ApiTestCaseSteps() : base()
        {
        }
        public new CommonResultResponse<AllTestCases> DeleteTestCase(ProjectModel project, int id)
        {
            logger.Info($"[API] Удаляем тест-кейс по коду: {project.Code}");
            var response = base.DeleteTestCase(project, id);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
            Assert.IsNotNull(response.Content);
            return JsonConvert.DeserializeObject<CommonResultResponse<AllTestCases>>(response.Content);
        }
        public new CommonResultResponse<AllTestCases> GetAllTestCases(ProjectModel project)
        {
            logger.Info($"[API] Получаем все тест-кейсы в проекте по его коду: {project.Code}");
            var response = base.GetAllTestCases(project);
            return JsonConvert.DeserializeObject<CommonResultResponse<AllTestCases>>(response.Content);
        }
        public new CommonResultResponse<AllTestCases> CreateTestCase(ProjectModel project, TestCaseModel testCase)
        {
            logger.Info($"[API] Создаем новый тест-кейсы в проекте по его коду: {project.Code}");
            var response = base.CreateTestCase(project, testCase);
            return JsonConvert.DeserializeObject<CommonResultResponse<AllTestCases>>(response.Content);
        }
    }
}
