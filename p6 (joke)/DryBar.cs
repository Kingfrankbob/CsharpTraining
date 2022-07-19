namespace comedians
{
    class DryBar
    {
        public static void Comedy()
        {
            var all = File.ReadAllText("BeeMovie.txt").Split(' ');
            var count = all.Length;
            Console.WriteLine("Total number of words is:" + count);
        }
    }
}