using Microsoft.EntityFrameworkCore;
using TafadzwaMovies.Models;

namespace TafadzwaMovies.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TafadzwaMoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TafadzwaMoviesContext>>()))
            {
                // Look for any movies in the database
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Lion King",
                        ReleaseDate = new DateTime(1994, 6, 10),
                        Genre = "Animation",
                        Price = 9.99m,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "Black Panther: Wakanda Forever",
                        ReleaseDate = new DateTime(2022, 11, 11),
                        Genre = "Action",
                        Price = 14.99m,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Shang-Chi and the Legend of the Ten Rings",
                        ReleaseDate = new DateTime(2021, 9, 3),
                        Genre = "Action",
                        Price = 12.99m,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Coming to America",
                        ReleaseDate = new DateTime(1988, 6, 29),
                        Genre = "Comedy",
                        Price = 8.99m,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Get Out",
                        ReleaseDate = new DateTime(2017, 2, 24),
                        Genre = "Thriller",
                        Price = 11.99m,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
