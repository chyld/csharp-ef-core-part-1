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
      var basedir = System.AppContext.BaseDirectory;
      var solndir = Directory.GetParent(basedir).Parent.Parent.Parent.Parent;
      options.UseSqlite($"Data Source={solndir.FullName}/db/app.db");
    }
  }
}
