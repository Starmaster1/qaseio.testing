using BussinesObjects.API.RestEntities;
using BussinesObjects.API.Services;
using Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects.API.Steps
{
    public class ApiProjectSteps : ProjectService
    {
        public ApiProjectSteps() : base()
        {
        }

        public new Project GetProjectByCode(string code)
        {
            var response = base.GetProjectByCode(code);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse<Project>>(response.Content).Result;
        }
        public string CheckProjectByCode(string code)
        {
            var response = base.GetProjectByCode(code);
            Assert.IsNotNull(response.Content);
            return response.StatusDescription;
        }

        public new CommonResultResponse<Project> DeleteProjectByCode(string code)
        {
            logger.Info($"[API] Удаляем проект по коду: {code}");
            var response = base.DeleteProjectByCode(code);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse<Project>>(response.Content);
        }
        public new CommonResultResponse<Project> CreateProject(ProjectModel project)
        {
            logger.Info($"[API] Создаем проект с названием '{project.Title}' и с кодом: '{project.Code}'");
            var response = base.CreateProject(project);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse<Project>>(response.Content);
        }
        public new CommonResultResponse<Project> EditProject(ProjectModel project)
        {
            logger.Info($"[API] Редактируем основные настройки проекта. Меняем название на '{project.Title}', Код: '{project.Code}', Описание: '{project.Description}'");
            var response = base.CreateProject(project);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse<Project>>(response.Content);
        }
    }
}
