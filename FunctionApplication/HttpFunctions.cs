using FunctionApplication.Configuration;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApplication
{
    public class HttpFunctions
    {
        public HttpFunctions(MyAppConfigSection appConfig)
        {
            this.AppConfig = appConfig;
        }

        private MyAppConfigSection AppConfig;

        [FunctionName(nameof(Http1))]
        public async Task<HttpResponseMessage> Http1([HttpTrigger(AuthorizationLevel.Function, "GET")]HttpRequestMessage request)
        {

            return await Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK) { Content = new StringContent("") });
        }

    }
}
