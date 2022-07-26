namespace School
{
  public class PostCall
  {
    public static void Start()
    {
      Post post = new Post();
      Console.WriteLine("Please enter the title of the post:");
      post.Title = Console.ReadLine() ?? "";
      Console.WriteLine("Please enter the description of the post:");
      post.Description = Console.ReadLine() ?? "";

      while (true)
      {
        var end = 0;
        Console.WriteLine("Please enter 1 to up vote the post press 2 to down vote and 0 to exit:");
        if (int.TryParse(Console.ReadLine() ?? "", out end))
        {
          if (end == 1)
          {
            post.UpVote();
          }
          else if (end == 2)
          {
            post.DownVote();
          }
          else if (end == 0)
          {
            break;
          }
          else
          {
            Console.WriteLine("Please enter a valid number");
          }
        }
        else
        {
          Console.WriteLine("Please enter a valid number");
        }
      }

      Console.WriteLine("The post title is: " + post.Title);
      Console.WriteLine("The post description is: " + post.Description);
      Console.WriteLine("The post created date is: " + post.CreatedDate.ToString("MM/dd/yyyy"));
      Console.WriteLine("The post vote is: " + post.Vote);

    }
  }
}