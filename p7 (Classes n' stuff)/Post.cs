namespace School
{
  public class Post
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; private set; }
    public int Vote { get; private set; }
    public Post()
    {
      Title = "";
      Description = "";
      CreatedDate = DateTime.Now;
      Vote = 0;
    }
    public void UpVote()
    {
      Vote++;
    }
    public void DownVote()
    {
      Vote--;
    }
  }
}