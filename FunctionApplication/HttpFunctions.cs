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
        /// <summary>
        /// Creates an instance of the function class.
        /// </summary>
        /// <param name="appConfig"><see cref="MyAppConfigSection"/> is added as service in <see cref="Startup.Configure(IWebJobsBuilder)"/> and is injected to this class when an instance is created.</param>
        public HttpFunctions(MyAppConfigSection appConfig)
        {
            this.AppConfig = appConfig;
        }

        /// <summary>
        /// Private storage for configuration information.
        /// </summary>
        private readonly MyAppConfigSection AppConfig;

        /// <summary>
        /// A HTTP triggered function that returns the configured SMTP host to demonstrate the use of typed access to configuration information.
        /// </summary>
        [FunctionName(nameof(Http1))]
        public async Task<HttpResponseMessage> Http1([HttpTrigger(AuthorizationLevel.Function, "GET")]HttpRequestMessage request)
        {
            return await Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK) { Content = new StringContent($"SMTP Host: {this.AppConfig.Smtp.Host}") });
        }

    }
}
