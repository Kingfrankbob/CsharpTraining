namespace frootLoops
{
    class kiwiThree
    {
        public static void kwFactor()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Please enter a value for the Factorial Calculator");

            var factor = getInput.getIntNotNeg();
            var fvalue = 1;

            for(var i = 1; i <= factor; i++)
            {
                fvalue *= i;
            }

            Console.WriteLine("{0}! = {1}\n", factor, fvalue);

        }
    }
}