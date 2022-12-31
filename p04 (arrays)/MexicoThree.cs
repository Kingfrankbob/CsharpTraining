namespace Vacashon
{
  public class MexicoThree
  {
    public static void numberAsk()
    {
      var count = 1;
      var numbers = new List<int>();


      while (count < 6)
      {
        var sCheck = (count == 5) ? "" : "s";
        var aCheck = (count == 5) ? " a " : " ";

        Console.WriteLine("Please enter {0}{1}number{2} then press enter.", 6 - count, aCheck, sCheck);
        var input = getInput.getAnyInt();

        if (numbers.Contains(input))
        {
          Console.WriteLine("You already entered that number.");
          continue;
        }
        numbers.Add(input);
        count++;
      }
      Console.WriteLine("Your numbers were ");
      numbers.Sort();
      numbers.ForEach(Console.WriteLine);
    }
  }
}