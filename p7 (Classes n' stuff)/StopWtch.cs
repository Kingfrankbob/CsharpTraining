using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class StopWtch
    {
        private Boolean St = false;
        private Boolean Ed = true;
        public DateTime Start{ get; private set;}
        public DateTime End{ get; private set;}
        public TimeSpan Length{ get; private set;}
        public DateTime StartSP{ get; private set;}
        public DateTime EndSP{ get; private set;}
        public TimeSpan LengthSP{ get; private set;}
        public Boolean SpTm{ get; private set;}
    
        public void Star()
        {
            if(Ed == false || St == true)
                throw new InvalidOperationException("Tried to start it when it wasn't possible?!");
            St = true;
            Ed = false;
            Start = DateTime.Now;
            StartSP = DateTime.Now;
            Console.WriteLine("Started!");
            
        }

        public void En()
        {

            if(St == false || Ed == true)
                throw new InvalidOperationException("Tried Ending when there was no time to end!");
            Ed = true;
            St = false; 
            End = DateTime.Now;
            if(SpTm == true)
            {
            EndSP = DateTime.UtcNow;
            }
            Console.WriteLine("Stopped!");
            
        }
        public void Ask()
        {
            var rnd = new Random();
            if(St == true || Ed == false)
                throw new InvalidOperationException("Tried to find the a nonexistent thing, just like your friends!");
            if(SpTm == false)
            {
            Length = End - Start;
            Console.WriteLine("StopWatch time is:" + Length);
            }
            if(SpTm == true)
            {
                Length = End - Start;
                LengthSP = StartSP.AddYears(rnd.Next(1, 200)) - StartSP.AddDays(rnd.Next(1, 365)) - EndSP.Subtract(new DateTime(1300, 4, 12, 16, 5, 32));
                var yes = LengthSP;
                var no = double.Parse(yes.ToString().Replace(':', '3').Replace(' ', '7').Replace('.', '4'));
                var test = no % rnd.Next(1, 15);
                if(test < 0)
                {
                    test *= -1;
                }
                Console.WriteLine("SpaceTime calculated @" + Length);
                Console.WriteLine("You have traveled: {0} AU", test);
            }
        }

        public void MAGIK()
        {
            Console.WriteLine("You shouldn't be here");
            var ok = (Console.ReadLine() ?? "").Split(' ');
            if(ok.Length >= 2)
            {
            ok[2] = "YoUvE DoNe";
            }
            if(ok.Length >= 4)
            {
            ok[4] = "SoMeThInG";
            }
            if(ok.Length >= 6)
            {
            ok[6] = "ILLEGAL";
            }
            if(ok.Length >= 8)
            {
                ok[8] = "You have made the stopwatch become more then just a stopwatch, It now tracks SpaceTime";
            }
            if(ok.Length >= 9)
            {
                ok[9] = "AU is an Astronomical Unit!";
            }
            foreach(var word in ok)
            {
                Console.WriteLine(word);
            }
            if(ok.Length < 8)
            {
            throw new Exception("Been caught doing something Bad");
            }
            SpTm = true;
        }


    }
}