using Microsoft.EntityFrameworkCore;
using BlogNoticias.Models;

namespace BlogNoticias.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }
        public DbSet<Post> Posts { get; set; }
    }
}
