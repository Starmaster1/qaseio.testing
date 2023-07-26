using BussinesObjects.API.RestEntities;
using BussinesObjects.API.Services;
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

        public new CommonResultResponse<Project> DeleteProjectByCode(string code)
        {
            logger.Info("Delete project by Id: " + code);
            var response = base.DeleteProjectByCode(code);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse<Project>>(response.Content);
        }
    }
}
