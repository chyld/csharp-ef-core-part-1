using Microsoft.EntityFrameworkCore;

namespace lib
{
  public class Context : DbContext
  {
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=app.db");
  }
}

