using System;
using System.Collections.Generic;
using System.Text;

namespace mailerCLI
{
    public  class MailInfo
    {
        public readonly string from = LoginInfo.email;
        public  string fromName { get; set; }
        public string to { get; set; }
        public string toName { get; set; }

    }
}
