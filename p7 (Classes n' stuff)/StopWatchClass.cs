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
          Console.WriteLine(@"Please enter an Input with a valid number:
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
          1. Start
          2. Stop
          3. Get Length
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          int input = 0;
          try
          {
          input = int.Parse(Console.ReadLine() ?? "");
          if (input < 1 || input > 4)
              throw new ArgumentOutOfRangeException("Invalid choice you nab(noob)");
          }
          catch(Exception)
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Please try Again!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            StMain();
          }
          var SW = new StopWtch();
          switch(input)
          {
            case 1:
            SW.Star();
            StMain(SW);
            break;

            case 2:
            SW.En();
            StMain(SW);
            break;

            case 3:
            SW.Ask();
            StMain(SW);
            break;

            case 4:
            SW.MAGIK();
            StMain(SW);
            break;
          }
          
        }
        public static void StMain(StopWtch SW)
        {

          Console.WriteLine(@"Please enter an Input with a valid number:
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
          1. Start
          2. Stop
          3. Get Length
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          int input = 0;
          try
          {
          input = int.Parse(Console.ReadLine() ?? "");
          if (input < 1 || input > 4)
              throw new ArgumentOutOfRangeException("Invalid choice you nab(noob)");
          }
          catch(Exception)
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Please try Again!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            StMain(SW);
          }

          switch(input)
          {
            case 1:
            SW.Star();
            StMain(SW);
            break;

            case 2:
            SW.En();
            StMain(SW);
            break;

            case 3:
            SW.Ask();
            StMain(SW);
            break;

            case 4:
            SW.MAGIK();
            StMain(SW);
            break;
          }
        }
    }
}