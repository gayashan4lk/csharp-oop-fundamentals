using System;
using System.Collections.Generic;

namespace Stark.Common
{
    public class LoggingService
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
