namespace School
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Please choose between the two programs that we have:");
      Console.WriteLine("1. Post");
      Console.WriteLine("2. Watch");
      Console.WriteLine("3. Exit");
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