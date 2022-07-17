using System.Text;
namespace Vacashon
{
  class moscowFive
  {
    public static void Smallestofall()
    {
      List<string> numbers = new List<string>();
      int Previous1 = 2147483647;
      int Previous2 = 2147483647;
      int Previous3 = 2147483647;
      string toap;

      Console.WriteLine("Enter a string of Numbers: (Separated by a Comma)");
      string? input = Console.ReadLine();
      if (input == null)
      {
        while (input == null)
        {
          Console.WriteLine("At least put something!!!!");
          Console.WriteLine("Enter a string of Numbers: (Separated by a Comma)");
          input = Console.ReadLine();
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

      if (numbers.Count() < 5 || numbers == null)
      {
        Console.WriteLine("Invalid list try again");
        moscowFive.Smallestofall();
      }
      
      for (int i = 0; i < 3; i++)
      {
        if (numbers == null)
          break;
        foreach (string str in numbers)
        {
          try
          {
            int thisss = int.Parse(str);
            if (thisss < Previous1 && i == 0) Previous1 = thisss;
            if (thisss < Previous2 && i == 1 && thisss > Previous1) Previous2 = thisss;
            if (thisss < Previous3 && i == 2 && thisss > Previous2) Previous3 = thisss;
          }
          catch (Exception)
          {
            //Do nothing
          }
        }
      }

      Console.WriteLine("\nThe smallest three are: {0}, {1}, {2}\n", Previous1, Previous2, Previous3);
    }
  }
}