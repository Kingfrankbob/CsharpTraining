using System.Text;
namespace frootLoops
{
  class strawberryFive
  {
    public static void MMMck()
    {
      List<string> numbers = new List<string>();
      int Previous = 0;
      string toap;
      Console.ForegroundColor = ConsoleColor.Red;
      numbers.Add(" ");
      Console.WriteLine("Enter a string of Numbers: (Separated by a Comma)");
      string? input = Console.ReadLine();
      if (input == null)
      {
        while (input == null)
        {
          Console.WriteLine("At least put something!!!!");
          Console.WriteLine("Enter a string of Numbers: (Separated by a Comma)");
          input = Console.ReadLine() ?? "";
        }
      }

      var sb = new StringBuilder();

      foreach (char value in input)
      {
        int truvalue = (int)Char.GetNumericValue(value);

        if (truvalue <= 9 && truvalue >= 0)
        {
          sb.Append(value);
        }
        else if (truvalue > 9 || truvalue < 0)
        {
          toap = sb.ToString();
          numbers.Add(toap);
          sb = new StringBuilder();
        }
      }

      toap = sb.ToString();
      numbers.Add(toap);

      if (numbers == null || numbers.Count == 0)
      {
        Console.WriteLine("Please Try again when you feel like putting stuff in correctly :(");
        MMMck();
      }

      // numbers.ForEach(Console.WriteLine); // Debug Purposes

      foreach (string value in numbers)
      {
        try
        {
          int thisss = int.Parse(value);
          if (thisss > Previous) Previous = thisss;
        }
        catch (Exception)
        {
          //Do nothing
        }
      }

      Console.WriteLine("The biggest of the Entered is: {0}", Previous);



    }

  }
}