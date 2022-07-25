namespace comedians
{
  public static class RobinWilliams
  {
    public static void Reads()
    {
      var words = File.ReadAllText("BeeMovie.txt").Split(' ').OrderByDescending(x => x.Length).First();
      Console.WriteLine("The longest word in the file is: " + words);
    }
  }
}
      //string longestWord = words.OrderByDescending(x => x.Length).First(); //Goes in between 7 and 8