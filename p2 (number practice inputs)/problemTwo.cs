namespace UserInput
{
  class problemTwo
  {
    public static void BiggerOfTwo()
    {
      int first = 0, second = 0;
      Console.WriteLine("Enter the first number\n");
      first = getInput.getAnyInt();
      Console.WriteLine("Enter the second number\n");
      second = getInput.getAnyInt();
      if (first > second)
      {
        Console.WriteLine("First is bigger then second being {0}\n", first);
      }
      else if (second > first)
      {
        Console.WriteLine("Second is bigger then first being: {0}\n", second);
      }
      else
      {
        Console.WriteLine("Sorry cant help you there");
      }
    }
  }
}
