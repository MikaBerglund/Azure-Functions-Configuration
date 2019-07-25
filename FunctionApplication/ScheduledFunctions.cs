using FunctionApplication.Configuration;
using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApplication
{
    public class ScheduledFunctions
    {
        /// <summary>
        /// Creates an instance of the function class.
        /// </summary>
        /// <param name="rootConfig">This instance will be injected into the class when created, since we have specified <see cref="AppSettingsRootConfig"/> as a service in <see cref="Startup.Configure(IWebJobsBuilder)"/>.</param>
        public ScheduledFunctions(AppSettingsRootConfig rootConfig)
        {
            this.AppConfig = rootConfig;
        }

        /// <summary>
        /// Keep a reference to the configuration information injected.
        /// </summary>
        private readonly AppSettingsRootConfig AppConfig;


        /// <summary>
        /// A timer triggered function that uses injected configuration information.
        /// </summary>
        [FunctionName(nameof(Scheduled1))]
        public async Task Scheduled1([TimerTrigger("*/10 * * * * *")]TimerInfo timer)
        {
            foreach(var container in this.AppConfig.MyApp.Containers)
            {
                await Task.Yield();
            }
        }
    }
}
