using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Security;

namespace mailerCLI
{
    class LoginInfo
    {
       // private static SecureString pwd = new SecureString();
        private static string[] abc = IO.Read("login.txt").Split(':');
        public static string email = abc[0];
        public static NetworkCredential credentials = new NetworkCredential {

            UserName = abc[0],
            Password = abc[1]
        };
    }
}
