using FunctionApplication;
using FunctionApplication.Configuration;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: WebJobsStartup(typeof(Startup))]

namespace FunctionApplication
{
    /// <summary>
    /// The startup class that takes care of introducing services used by the application.
    /// </summary>
    public class Startup : IWebJobsStartup
    {
        /// <summary>
        /// Takes care of deserializing configuration information and adds it as services to the application for easy access.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(IWebJobsBuilder builder)
        {
            var serviceProvider = builder.Services.BuildServiceProvider();
            var config = serviceProvider.GetService<IConfiguration>();

            //Get all configuration information deserialized to an instance of our configuration root class.
            var rootConfig = config.Get<AppSettingsRootConfig>();

            // Add configuration data as services.
            builder.Services.AddSingleton(rootConfig);

            // Add a subset of configuration data as a separate service, which enables us to specify MyAppConfigSection as injected service in our function classes or other services.
            builder.Services.AddSingleton(rootConfig.MyApp);
        }
    }
}
