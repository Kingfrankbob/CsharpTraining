namespace comedians
{
    class DryBar
    {
        public static void Comedy()
        {
            var all = File.ReadAllText("BeeMovie.txt").Split(' ');
            Console.WriteLine("Total number of words is: {0}", all.Length);
        }
    }
}