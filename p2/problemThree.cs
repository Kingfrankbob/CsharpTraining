namespace UserInput
{
  class problemThree
  {
    public static void LandscapeOrPortrait()
    {
      int width = 0, height = 0;
      Console.WriteLine("\nEnter the width of the image");
      width = getInput.getIntNotNeg();
      Console.WriteLine("\nEnter the height of the image");
      height = getInput.getIntNotNeg();
      if (width > height)
      {
        Console.WriteLine("\nThe image is landscape\n");
      }
      else if (height > width)
      {
        Console.WriteLine("\nThe image is portrait\n");
      }
      else
      {
        Console.WriteLine("\nThe image is square\n");
      }
    }
  }
}
