using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApplication.Configuration
{
    /// <summary>
    /// Represents configuration information for connecting to a blob container in a storage account.
    /// </summary>
    public class StorageContainerConfigSection
    {

        public string ConnectionString { get; set; }

        public string Container { get; set; }

    }
}
