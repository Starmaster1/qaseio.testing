using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Logger = NLog.Logger;
using Core.Configuration;

namespace Core.API
{
    public class BaseService
    {
        protected BaseApiClient apiClient;
        protected static Logger logger = LogManager.GetCurrentClassLogger();
        public BaseService(string url)
        {
            this.apiClient = new BaseApiClient(url);
            apiClient.AddToken(AppConfiguration.Api.Token);
        }
    }
}
