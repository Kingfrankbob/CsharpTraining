using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yarn
{
    public class Amaranth
    {
        public static void Consornt()
        {
            
            
            var extraarray = getInput.getnumbyhyphen();
            int cont = 0;
            int length = extraarray.Length;
            for(int i = 0; i < length; i++)
            {
                if (i == (length - 1)) break;
                else if(extraarray[i] == (extraarray[i + 1] - 1)) cont = 1;
                else if(extraarray[i] != (extraarray[i + 1] - 1)) cont = 0;
                
            }
            if(cont == 1)
            {
            Console.WriteLine("Your numbers are consecutive!");
            }
            else if(cont == 0)
            {
                Console.WriteLine("Your numbers aren't consecutive!");
            }
            else
            {
                Console.WriteLine("What kind of voodoo magik are you doing? XD");
            }
            
        }
        
    }
}