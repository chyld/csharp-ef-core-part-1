using System.Collections.Generic;

namespace lib
{
  public class Blog
  {
    public int BlogId { get; set; } // primary key
    public string Url { get; set; }
    public List<Post> Posts { get; } = new List<Post>(); // creates a foreign key in the Posts table
  }
}
