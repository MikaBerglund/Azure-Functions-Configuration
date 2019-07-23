using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApplication.Configuration
{
    /// <summary>
    /// Represents the root configuration section for all application settings.
    /// </summary>
    public class AppSettingsRootConfig
    {

        /// <summary>
        /// The connection string to the storage account that all Azure Function applications must have configured.
        /// </summary>
        public string AzureWebJobsStorage { get; set; }

        /// <summary>
        /// The container for all our application specific configuration settings.
        /// </summary>
        public MyAppConfigSection MyApp { get; set; }

    }
}
