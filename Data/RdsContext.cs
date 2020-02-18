using Microsoft.EntityFrameworkCore;
using AspNetMvc.Models;

namespace AspNetMvc.Data
{
    public class RdsContext : DbContext
    {
        public RdsContext (DbContextOptions<RdsContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().ToTable("Blog");
            modelBuilder.Entity<Post>().ToTable("Post");
        }
    }
}