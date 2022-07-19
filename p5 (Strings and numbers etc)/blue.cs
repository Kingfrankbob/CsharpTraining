namespace yarn
{
  public class blue{
    public static void VowelCounter(){
      var numVowels = 0;
      Console.WriteLine("Please enter a word or phrase:");
      var input = Console.ReadLine() ?? "";
      if (string.IsNullOrWhiteSpace(input))
      {
        Console.WriteLine("Please try again when you feel like putting stuff in correctly :(\n");
        return;
      }
      var words = input.Split(' ');
      foreach (var word in words)
      {
        foreach (var letter in word)
        {
          if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            numVowels++;
        }
      }
      Console.WriteLine("Number of vowels: " + numVowels + "\n");
    }
  }
}