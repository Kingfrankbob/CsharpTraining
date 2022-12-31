namespace frootLoops
{
    public static class appleTwo
    {
        public static void itOkay()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter any number or enter ok to exit:");
                var input = Console.ReadLine();
                var cleanedInput = String.IsNullOrWhiteSpace(input) ? "0" : input ?? "0";
                if (cleanedInput == "ok")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nGoodbye - Total sum was {0}.\n", sum);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
                try
                {
                    int number = int.Parse(cleanedInput);
                    sum += number;
                    Console.WriteLine("You entered: {0} The current sum is: {1}", number, sum);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid Input\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    continue;
                }
            }
        }
    }
}
