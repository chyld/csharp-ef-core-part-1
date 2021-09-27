namespace lib
{
  public class Post
  {
    public int PostId { get; set; }  // primary key
    public string Title { get; set; }
    public string Content { get; set; }
    public Blog Blog { get; set; } // allows you to reference the Blog object associated with this Post
  }
}
