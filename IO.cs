using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace mailerCLI
{
    class IO
    {
        public static string Read(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
