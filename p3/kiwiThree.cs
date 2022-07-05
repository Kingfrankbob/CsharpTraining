namespace frootLoops
{
    class kiwiThree
    {
        public static void kwFactor()
        {
            // Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Please enter a value for the Factoral Calculator");

            var factor = getInput.getIntNotNeg();
            var fvalue = 1;

            for(var i = 1; i <= factor; i++)
            {
                fvalue *= i;
            }

            Console.WriteLine("{0}! = {1}", factor, fvalue);

        }
    }
}