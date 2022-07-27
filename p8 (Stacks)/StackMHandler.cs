using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garbage
{
    public class StackMHandler
    {
        public static void StackMain(StackM Stack)
        {
                  var stack = new StackM();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      Console.WriteLine(stack.Pop());
      Console.WriteLine(stack.Pop());
      Console.WriteLine(stack.Pop());


        /*
              Console.WriteLine(@"Please enter an Input with a valid number:
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
          1. Push(Object)
          2. Pop(Object)
          3. Clear(Stack)
          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      int input = 0;
      try
      {
        input = int.Parse(Console.ReadLine() ?? "");
        if (input < 0 || input > 4)
          throw new ArgumentOutOfRangeException("Invalid choice you nab(noob)");
      }
      catch (Exception)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Please try Again!");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
        StackMain(Stack);
      }

        var inputMod = StackM.Confuscationism(input);
        

      switch (input)
      {
        case 1:
          Stack.Push(new DateTime(1300, 12, 12, 12, 12, 12));
          StackMain(Stack);
          break;

        case 2:
          Console.WriteLine(Stack.Pop());
          StackMain(Stack);
          break;

        case 3:
          Stack.Clear();
          StackMain(Stack);
          break;

        case 4:
          Console.WriteLine("You thought I was gonna do something this time :face_with_raised_brow:");
          Stack.changed = true;
          StackMain(Stack);
          break;
        }
        */
        }
    }
}