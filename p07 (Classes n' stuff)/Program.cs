namespace School
{
    class Program
    {
        static void MainSchool()
        {
            Console.WriteLine("Please choose between the two programs that we have:");
            Console.WriteLine("1. Post");
            Console.WriteLine("2. Watch (Stupid)");
            Console.WriteLine("3. Watch (Smart)");
            Console.WriteLine("4. Exit");
            var input = 0;
            if (int.TryParse(Console.ReadLine() ?? "", out input))
            {
                if (input == 1)
                {
                    PostCall.Start();
                }
                else if (input == 2)
                {
                    WatchFace.ShowTime();
                }
                else if (input == 3)
                {
                    StopWatchClass.StMain();
                }
                else if (input == 4)
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}