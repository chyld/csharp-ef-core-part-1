using System;
using System.Linq;
using lib;

namespace app
{
  class Program
  {
    static void Main(string[] args)
    {
      using var db = new Context();

      // Create
      Console.WriteLine("Inserting a new blog");
      var blog = new Blog { Url = "http://wowblog.com/" };
      db.Add(blog);
      db.SaveChanges();

      // Read
      Console.WriteLine("Querying for a blog");
      var firstBlog = db.Blogs
          .OrderBy(b => b.BlogId)
          .First();
      Console.WriteLine($"First Blog: {firstBlog.BlogId} {firstBlog.Url}");

      // Update
      Console.WriteLine("Updating the blog and adding a post");
      blog.Url = "http://superblog.com/";
      var post = new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" };
      blog.Posts.Add(post);
      db.SaveChanges();

      // Delete
      Console.WriteLine("Delete the blog with associated posts");
      db.Remove(blog);
      db.SaveChanges();
    }
  }
}
