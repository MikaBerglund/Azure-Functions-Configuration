using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApplication.Configuration
{
    /// <summary>
    /// Represents the configuration information our application requires.
    /// </summary>
    public class MyAppConfigSection
    {

        /// <summary>
        /// Information on how to send outgoing e-mails.
        /// </summary>
        public SmtpConfigSection Smtp { get; set; }

        /// <summary>
        /// A collection of blob storage containers to connect to from the application.
        /// </summary>
        public ICollection<StorageContainerConfigSection> Containers { get; set; }

    }
}
