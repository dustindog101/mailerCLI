using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace mailerCLI
{
     public class config
    {
        public  Thread interval { get; set; }
        public  string subject { get; set; }
        public  string body { get; set; }
    }
}
