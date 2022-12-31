namespace comedians
{
    class DryBar
    {
        public static void Comedy()
        {
            string all = File.ReadAllText("BeeMovie.txt").Split(' ').OrderByDescending(x => x.Length).First();
            Console.WriteLine("Total number of words is: {0}", all.Length);
        }
    }
}