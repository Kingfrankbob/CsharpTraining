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
            try
            {
            var extraarray = getInput.getnumbyhyphen();
            int cont = 0;
            int length = extraarray.Length;
            for(int i = 0; i < length; i++)
            {
                if(extraarray[i] == (extraarray[i + 1] - 1)) cont = 1;
                else cont = 0;
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