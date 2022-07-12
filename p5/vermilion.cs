using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yarn
{
    public class vermilion
    {
        static void duplicato()
        {
            int[] array = getInput.getnumbyhyphen();
            int dup = 0;
            foreach (var value in array)
            {
                if(array.Contains(value) == true) dup = 1;
                else dup = 0;
            }

            if(dup == 1) Console.WriteLine("Duplicates");
            else if (dup == 0) Console.WriteLine("No Duplicates");
            else if (dup > 1 || dup < 0) Console.WriteLine("What voodoo magik is happening here?");
        }
    }
}