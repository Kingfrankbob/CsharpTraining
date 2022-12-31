namespace School
{
  public class Watch
  {
    public DateTime Start { get; private set; }
    public DateTime End { get; private set; }
    public int Check { get; private set; }
    public Watch()
    {
      Start = DateTime.Now;
      End = DateTime.Now;
      Check = 0;
    }
    public void StartTimer()
    {
      if (Check == 0)
      {
        Start = DateTime.Now;
        Check = 1;
      }
      else
      {
        Console.WriteLine("Watch is already started");
      }
    }
    public TimeSpan StopTimer()
    {
      End = DateTime.Now;
      Check = 0;
      return End - Start;
    }
  }
}