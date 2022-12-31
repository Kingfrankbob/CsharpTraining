using System.Text;
namespace Vacashon
{
  class madagascarTwo
  {
    public static void Reversi()
    {
      string name = "";
      Console.WriteLine("Please enter your name:");
      try
      {
        name = Console.ReadLine() ?? "";
      }
      catch (Exception)
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Please try again!!");
        Console.ForegroundColor = ConsoleColor.Gray;
      }

      char[] spnm = name.ToCharArray();

      Array.Reverse(spnm);
      var finished = new StringBuilder();
      foreach (char ch in spnm)
      {
        finished.Append(ch);
      }
      Console.WriteLine(finished.ToString());

    }
  }
}