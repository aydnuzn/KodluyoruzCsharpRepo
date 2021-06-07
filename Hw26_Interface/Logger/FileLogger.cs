using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw26_Interface
{
    class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("File Log");
        }
    }
}
