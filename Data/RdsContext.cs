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

        public DbSet<Movie> Movie { get; set; }
    }
}