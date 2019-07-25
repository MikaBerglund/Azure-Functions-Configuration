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

        /// <summary>
        /// The full connection string to the storage account.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// The name of the container.
        /// </summary>
        public string Container { get; set; }

        /// <summary>
        /// Specifies whether to enable soft deletes in case the application deletes blobs.
        /// </summary>
        public bool EnableSoftDelete { get; set; }

    }
}
