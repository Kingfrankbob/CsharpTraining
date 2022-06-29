namespace UserInput
{
  class problemOne
  {
    public static void Validation()
    {      
      int inputNumber = getInput.getIntOneToTen();
      Console.ForegroundColor = ConsoleColor.Green;     
      System.Console.WriteLine("Valid, that is a number between 1 & 10\n");      
      Console.ForegroundColor = ConsoleColor.Gray;
    }
  }
}
