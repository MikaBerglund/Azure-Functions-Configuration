using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApplication.Configuration
{
    public class MyAppConfigSection
    {

        public SmtpConfigSection Smtp { get; set; }

        public ICollection<StorageContainerConfigSection> Containers { get; set; }

    }
}
