namespace yarn
{
  using System.Text;
  public class green
  {
    public static void PascalCase()
    {
      Console.WriteLine("Please enter a word or phrase:");
      var input = Console.ReadLine() ?? "";
      if (string.IsNullOrWhiteSpace(input))
      {
        Console.WriteLine("Please try again when you feel like putting stuff in correctly :(\n");
        return;
      }
      var words = input.Split(' ');
      var finished = new StringBuilder();
      foreach (var word in words)
      {
        finished.Append(word.Substring(0, 1).ToUpper());
        finished.Append(word.Substring(1).ToLower());
      }
      Console.WriteLine("Pascal Case: " + finished.ToString() + "\n");
    }
  }
}