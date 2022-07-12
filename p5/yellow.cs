namespace yarn
{
  public class yellow
  {
    //     3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00). 
    // A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; 
    // otherwise, display "Invalid Time". 
    // If the user doesn't provide any values, consider it as invalid time.
    public static void timeToStop()
    {
      var time = new DateTime();
      try
      {
        Console.WriteLine("Please enter a time value in the 24-hour time format (e.g. 19:00).\n");
        time = DateTime.Parse(Console.ReadLine() ?? "");
      }
      catch (Exception)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nInvalid Time\n");
        Console.ForegroundColor = ConsoleColor.Gray;
        return;
      }
    }
  }
}