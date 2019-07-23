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
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            var serviceProvider = builder.Services.BuildServiceProvider();
            var config = serviceProvider.GetService<IConfiguration>();

            var rootConfig = config.Get<AppSettingsRootConfig>();

            builder.Services.AddSingleton(rootConfig);
            builder.Services.AddSingleton(rootConfig.MyApp);
        }
    }
}
