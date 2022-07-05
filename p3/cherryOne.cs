namespace frootLoops
{
    class cherryOne
    {
        public static void threeDone()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            var count = 0;

            Console.WriteLine("Enter the range to Check: ");

            Console.Write("For Min please ");
            var min = getInput.getAnyInt();

            Console.Write("For Max please ");
            var max = getInput.getAnyInt();

            string err = "";

            if(min < max || min == max){
                
            for(var i = min; i < max; i++)
            {
                if(i%3 == 0) count += 1;
            }
            Console.WriteLine("Numbers divisible by three: {0} between {1}, and {2}\n", count, min, max);
        
            }
            else
            {
                if(min > max) err = "Minimum is greater then Maximum";
                Console.WriteLine("Illegal Numbers Entered Error: {0}", err);
            }
        }
    }
}