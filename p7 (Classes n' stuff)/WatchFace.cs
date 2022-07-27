namespace School
{
  public static class WatchFace
  {
    public static void ShowTime()
    {
      var watch = new Watch();
      watch.StartTimer();
      Console.WriteLine("Press any key to stop the watch...");
      Console.ReadKey(true);
      Console.WriteLine("\nThe time is: " + watch.StopTimer().ToString("hh\\:mm\\:ss"));
    }
  }
}