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

        public void Push(Object obj)
        {
            if (obj == null)
                throw new TypeLoadException("I cant believe you've done this");
            Stackl.Add(obj);
            Console.WriteLine("Added to Stack(not overflow)!");

            foreach (var Value in Stackl)
            {
                Console.WriteLine(Value);
            }


        }
        public object Pop()
        {
            if (Stackl.Count == 0)
                throw new ArgumentNullException("Don't even know how you got this error!?");
           var obj = Stackl[Stackl.Count - 1];
            Stackl.RemoveAt(Stackl.Count - 1);
            return obj;
            
        }

        public void Clear()
        {

            if(Stackl.Count == 0)
                throw new Exception("Purely for Debugging");

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
