﻿using FunctionApplication.Configuration;
using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApplication
{
    public class ScheduledFunctions
    {
        public ScheduledFunctions(MyAppConfigSection myAppConfig)
        {
            this.MyAppConfig = myAppConfig;
        }

        private MyAppConfigSection MyAppConfig;


        [FunctionName(nameof(Scheduled1))]
        public async Task Scheduled1([TimerTrigger("*/10 * * * * *")]TimerInfo timer)
        {
            var containers = this.MyAppConfig.Containers;

        }
    }
}