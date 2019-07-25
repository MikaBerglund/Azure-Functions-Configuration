using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApplication.Configuration
{
    /// <summary>
    /// Defines information for how to send e-mails.
    /// </summary>
    public class SmtpConfigSection
    {

        /// <summary>
        /// The SMTP host name.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// The port to connect on.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// The username to use to authenticate with the SMTP host.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The password for the user name.
        /// </summary>
        public string Password { get; set; }

    }
}
