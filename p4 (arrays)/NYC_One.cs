namespace Vacashon
{
  public class NYC_ONE
  {
    public static void noFriends()
    {
      List<string> friends = new List<string>();

      while (true)
      {
        Console.WriteLine("Enter your friends names or press enter.");
        var names = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(names))
        {
          break;
        }
        friends.Add(names);
      }
      int friendsCount = friends.Count;
      switch (friendsCount)
      {
        case 0:
          Console.WriteLine("You have no friends.");
          break;
        case 1:
          Console.WriteLine("{0} likes your post.", friends[0]);
          break;
        case 2:
          Console.WriteLine("{0} and {1} like your post.", friends[0], friends[1]);
          break;
        default:
          Console.WriteLine("{0}, {1} and {3} others like your post.", friends[0], friends[1], friendsCount - 2);
          break;
      }
    }
  }
}