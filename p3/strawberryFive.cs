namespace frootLoops
{
    class strawberryFive
    {
        public static void MMMck()
        {
            int testn = 0;
            List<int> numbers = new List<int>();
            int Previous = 0;
            
            Console.WriteLine("Enter a string of Numbers:");
            string input = Console.ReadLine();
                            
            foreach (var value in input)
            {
                string ok = value.ToString();
                bool success = int.TryParse(ok, out testn);
                if(success)
                {
                    numbers.Add(value);
                }    
            }
            
            numbers.ForEach(Console.WriteLine);


                foreach (var value in numbers)
                {
                    if(value > Previous) Previous = value;
                }

            Console.WriteLine("The biggest of the Entered is: {0}", Previous);
        
                
            
        }

    }
}