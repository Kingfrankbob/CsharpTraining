namespace Vacashon
{
  class tahitiFour
  {
    public static void uniquity()
    {
      Console.ForegroundColor = ConsoleColor.Magenta;
      int sum = 0;
      var numbers = new List<int>();
      while (true)
      {
        Console.WriteLine("Enter any number or enter 'quit' to exit:");
        var input = Console.ReadLine();
        var cleanedInput = String.IsNullOrWhiteSpace(input) ? "0" : input ?? "0";
        if (cleanedInput == "quit")
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("\nGoodbye\n", sum);
          Console.WriteLine("Your unique numbers were:");
          numbers.Sort();
          numbers.ForEach(Console.WriteLine);
          Console.ForegroundColor = ConsoleColor.Gray;
          break;
        }
        try
        {
          int number = int.Parse(cleanedInput);
          if (numbers.Contains(number))
          {
            continue;
          }
          numbers.Add(number);
        }
        catch (Exception)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\nInvalid Input\n");
          Console.ForegroundColor = ConsoleColor.Magenta;
          continue;
        }
      }
    }
  }
}