using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace lib
{
  public class Context : DbContext
  {
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      var dir = Directory.GetCurrentDirectory();
      Console.WriteLine($"dir: {dir}");
      options.UseSqlite($"Data Source=app.db");
    }
  }
}
