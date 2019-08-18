using Microsoft.EntityFrameworkCore;

namespace HelloAspDotnetCore.Models
{
    public class HelloAspDotnetCoreContext : DbContext
    {
        public HelloAspDotnetCoreContext(DbContextOptions<HelloAspDotnetCoreContext> options)
            :base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}