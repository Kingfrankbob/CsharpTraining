namespace UserInput
{
    public class BiggerThan
    {
        public static void BiggerofTwo()
        {
            int first = 0, second = 0;
            Console.WriteLine("Enter the first number\n");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number\n");
            second = int.Parse(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine("First is bigger then second being {0}", first);

            }
            else if (second > first)
            {
                Console.WriteLine("Second is bigger then first being: {0}", second);
            }
            else
            {
                Console.WriteLine("Sorry cant help you there");
            }
        }
    }
}