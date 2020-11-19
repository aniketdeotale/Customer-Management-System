using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Common
{
   public  class LoggingService
    {

        public static void WriteToFile(List<iLoggable> itemsToLog)
        {
            foreach(var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
