using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var db = new BloggingContext())
            {
                db.Add(new Blog { Url = "blogs.msdn.com" });
                var count = db.SaveChanges();
                Console.WriteLine("----SAVE-----");
                Console.WriteLine($"{count} records saved to the database");

                Console.WriteLine("----RETRIEVE-----");
                foreach(var blog in db.Blogs)
                    Console.WriteLine($"- {blog.Url}");
            }
        }
    }
}
