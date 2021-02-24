using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace assignment5.Models
{
    //data to fill the db if there is nothing existing yet
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BooksDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BooksDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Books
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        NumberOfPages = 1488
                    },

                    new Books
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        NumberOfPages = 944
                    },

                    new Books
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        NumberOfPages = 832
                    },

                    new Books
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        NumberOfPages = 864
                    },

                    new Books
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        NumberOfPages = 528
                    },

                    new Books
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0553384611",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        NumberOfPages = 288
                    },

                    new Books
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        NumberOfPages = 304
                    },

                    new Books
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        NumberOfPages = 240
                    },

                    new Books
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        NumberOfPages = 400
                    },

                    new Books
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        NumberOfPages = 642
                    },

                    new Books
                    {
                        Title = "Edenbrooke",
                        AuthorFirst = "Julianne",
                        AuthorLast = "Donaldson",
                        Publisher = "Shadow Mountain",
                        ISBN = "978-1609089467",
                        Classification = "Fiction",
                        Category = "Romance",
                        Price = 13.89,
                        NumberOfPages = 264
                    },

                    new Books
                    {
                        Title = "Uneasy Fortunes",
                        AuthorFirst = "Mandi",
                        AuthorLast = "Ellsworth",
                        Publisher = "Cedar Fort Inc",
                        ISBN = "978-1599559858",
                        Classification = "Fiction",
                        Category = "Romance",
                        Price = 9.89,
                        NumberOfPages = 240
                    },

                    new Books
                    {
                        Title = "To Whisper Her Name",
                        AuthorFirst = "Tamera",
                        AuthorLast = "Alexander",
                        Publisher = "Zondervan",
                        ISBN = "978-1543605013",
                        Classification = "Historical Fiction",
                        Category = "Romance",
                        Price = 12.99,
                        NumberOfPages = 480
                    }

                );
                context.SaveChanges();
            }
        }
    }
}