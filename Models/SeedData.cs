using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace razor_crud.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new razorcrudToyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<razorcrudToyContext>>()))
            {
                // Look for any Toys.
                if (context.Toy.Any())
                {
                    return; // DB has been seeded
                }

                context.Toy.AddRange(
                    new Toy
                    {
                        Name = "TeddyBear",
                        PurchaseDate = DateTime.Parse("2021-2-12"),
                        Owner = "Sanoody",
                        Price = 50,
                    },
                    new Toy
                    {
                        Name = "Barbie",
                        PurchaseDate = DateTime.Parse("2019-6-10"),
                        Owner = "Julia",
                        Price = 75,
                    }
                    
                );
                
                // Look for any Books.
                if (context.Book.Any())
                {
                    return; // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Name = "A",
                        PurchaseDate = DateTime.Parse("2021-2-12"),
                        Owner = "bla",
                        Price = 50,
                    },
                    new Book
                    {
                        Name = "B",
                        PurchaseDate = DateTime.Parse("2019-6-10"),
                        Owner = "blabla",
                        Price = 75,
                    }
                );
                
                context.SaveChanges();
            }
        }
    }

}