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
      db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
      db.SaveChanges();
    }
  }
}
