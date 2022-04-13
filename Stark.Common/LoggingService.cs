using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stark.Common
{
    internal class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsList)
        {
            foreach (var item in itemsList)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
