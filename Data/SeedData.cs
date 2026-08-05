using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookVerse.Models;

namespace BookVerse.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<LibraryDbContext>>()))
            {
                // Automatically run migrations if database is available
                await context.Database.MigrateAsync();

                if (context.Books.Any())
                {
                    return;   // DB has already been seeded
                }

                context.Books.AddRange(
                    new Book
                    {
                        Title = "Clean Code",
                        Author = "Robert C. Martin",
                        Category = "Programming",
                        Price = 45.99m,
                        PublishDate = new DateOnly(2008, 8, 1),
                        Pages = 464,
                        Language = "English",
                        Description = "A handbook of agile software craftsmanship that teaches you how to write cleaner code.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "The Pragmatic Programmer",
                        Author = "Andy Hunt",
                        Category = "Programming",
                        Price = 49.99m,
                        PublishDate = new DateOnly(1999, 10, 30),
                        Pages = 352,
                        Language = "English",
                        Description = "Your journey to mastery in software development. Classic software development tips.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "A Brief History of Time",
                        Author = "Stephen Hawking",
                        Category = "Science",
                        Price = 14.99m,
                        PublishDate = new DateOnly(1988, 3, 1),
                        Pages = 212,
                        Language = "English",
                        Description = "A landmark volume in science writing by one of the great minds of our time discussing cosmology.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "Cosmos",
                        Author = "Carl Sagan",
                        Category = "Science",
                        Price = 18.50m,
                        PublishDate = new DateOnly(1980, 10, 12),
                        Pages = 365,
                        Language = "English",
                        Description = "The story of cosmic evolution, science, and civilization, exploring the depth of outer space.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "Zero to One",
                        Author = "Peter Thiel",
                        Category = "Business",
                        Price = 27.00m,
                        PublishDate = new DateOnly(2014, 9, 16),
                        Pages = 224,
                        Language = "English",
                        Description = "Notes on startups, or how to build the future. Insightful guide for entrepreneurs.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "Good to Great",
                        Author = "Jim Collins",
                        Category = "Business",
                        Price = 29.99m,
                        PublishDate = new DateOnly(2001, 10, 16),
                        Pages = 320,
                        Language = "English",
                        Description = "Why some companies make the leap... and others don't, based on long term research.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "Sapiens: A Brief History of Humankind",
                        Author = "Yuval Noah Harari",
                        Category = "History",
                        Price = 22.99m,
                        PublishDate = new DateOnly(2011, 1, 1),
                        Pages = 443,
                        Language = "English",
                        Description = "Explores the history of humankind from the Stone Age to the modern era with biology and history.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "The Guns of August",
                        Author = "Barbara W. Tuchman",
                        Category = "History",
                        Price = 19.95m,
                        PublishDate = new DateOnly(1962, 1, 1),
                        Pages = 511,
                        Language = "English",
                        Description = "A classic history of the events leading up to and during the first month of World War I.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "Atomic Habits",
                        Author = "James Clear",
                        Category = "Self Development",
                        Price = 21.99m,
                        PublishDate = new DateOnly(2018, 10, 16),
                        Pages = 320,
                        Language = "English",
                        Description = "An easy & proven way to build good habits & break bad ones using behavioral psychology.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "The 7 Habits of Highly Effective People",
                        Author = "Stephen R. Covey",
                        Category = "Self Development",
                        Price = 18.99m,
                        PublishDate = new DateOnly(1989, 8, 15),
                        Pages = 381,
                        Language = "English",
                        Description = "A powerful lesson in personal change to improve efficiency, character, and integrity.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "The Hobbit",
                        Author = "J.R.R. Tolkien",
                        Category = "Fiction",
                        Price = 12.99m,
                        PublishDate = new DateOnly(1937, 9, 21),
                        Pages = 310,
                        Language = "English",
                        Description = "The classic fantasy story and prelude to the legendary Lord of the Rings trilogy.",
                        CreatedAt = DateTime.UtcNow
                    },
                    new Book
                    {
                        Title = "1984",
                        Author = "George Orwell",
                        Category = "Fiction",
                        Price = 10.99m,
                        PublishDate = new DateOnly(1949, 6, 8),
                        Pages = 328,
                        Language = "English",
                        Description = "A dystopian social science fiction novel that introduced Big Brother and thoughtcrime.",
                        CreatedAt = DateTime.UtcNow
                    }
                );

                await context.SaveChangesAsync();
            }
        }
    }
}
