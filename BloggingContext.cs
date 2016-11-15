using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts {get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           var connection = @"Server=.\\sqlexpress;Database=ConsoleApp;Trusted_Connection=True";
           optionsBuilder.UseSqlServer(connection);
       }
    }

    
}