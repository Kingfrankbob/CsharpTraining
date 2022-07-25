using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class StopWatchClass
    {
        public static void StMain()
        {
          var input = Console.ReadLine();
          var SW = new StopWtch();
          switch(input)
          {
            case 1:
            SW.Start();
            break;

            case 2:
            SW.End();
            break;

            case 3:
            SW.Ask();
            break;
          }
        }
    }
}