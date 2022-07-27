using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garbage
{
    public class StackM
    {
        public Boolean changed = false;
        private List<Object> Stackl = new List<Object>();
        public void Push(object obj)
        {
            if (obj == null)
                throw new TypeLoadException("I cant believe you've done this");
            Stackl.Prepend(obj);
            Console.WriteLine("Added to Stack(not overflow)!");

        }
        public object Pop()
        {
            if (Stackl.Count == 0)
                throw new ArgumentNullException("Don't even know how you got this error!?");
            var obj = Stackl[0];
            Stackl.RemoveAt(0);
            return obj;
        }

        public void Clear()
        {
            Stackl.Clear();
            Console.WriteLine("Cleared of all energies!");
            if(changed == true)
            {
                Console.WriteLine("Oh dang the console is gonna crash");
                while(true)
                {
                    Console.Beep();
                }
            }
        }

        public static int Confuscationism(int choice)
        {
            var yes = choice + 1;
            return yes;
        }
    }
}
