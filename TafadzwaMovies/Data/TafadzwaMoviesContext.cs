using Microsoft.EntityFrameworkCore;
using TafadzwaMovies.Models;

namespace TafadzwaMovies.Data
{
    public class TafadzwaMoviesContext : DbContext
    {
        public TafadzwaMoviesContext(DbContextOptions<TafadzwaMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
