namespace comedians
{
    public static class RobinWilliams
    {
        public static void Reads()
        {
            Console.WriteLine("The longest word in the file is: {0} ", File.ReadAllText("BeeMovie.txt").Split(' ').OrderByDescending(x => x.Length).First());
        }
    }
}
//var words = File.ReadAllText("BeeMovie.txt").Split(' ').OrderByDescending(x => x.Length).First();
//string longestWord = words.OrderByDescending(x => x.Length).First(); //Goes in between 7 and 8
//Console.WriteLine("The longest word in the file is: " + longestWord)