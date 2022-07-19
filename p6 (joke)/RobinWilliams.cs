namespace comedians
{
  public static class RobinWilliams
  {
    public static void Reads()
    {
      string[] words = File.ReadAllText("BeeMovie.txt").Split(' ');
      string longestWord = words.OrderByDescending(x => x.Length).First();
      Console.WriteLine("The longest word in the file is: " + longestWord);
    }
  }
}
