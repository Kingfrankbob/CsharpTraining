using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class StopWtch
    {
        private TimeSpan Length;
        private DateTime Start;
        private Boolean St = false;
        private Boolean Ed = true;
        private DateTime End;


        public DateTime Start
        {
            get{ return Start; }
            set{ Start = value; }
        }

        public DateTime End 
        {
            get{ return End; }
            set{ End = value; }
        }
    
        public void Star()
        {
            if(Ed == false || St == true)
                break; // Throw new exception when I get there
            St = true;
            Ed = false;
            Start = DateTime.Now();
            Console.WriteLine("Started!");
        }

        public void En()
        {
            if(St == false || Ed == true)
                break;
            Ed = true;
            St = false; 
            End = DateTime.Now();
            Console.WriteLine("Stopped!");

        }
        public void Ask()
        {
            Length = Start - End;
            Console.WriteLine(Length);
        }


    }
}