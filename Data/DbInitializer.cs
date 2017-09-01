using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trainer.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DiagonAlleyContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            
            // add customers
            var customers = new List<Customer>
            {
                new Customer { FirstName = "Harry", LastName = "Potter", Email = "harry.potter@gmail.com" },
                new Customer { FirstName = "Ron", LastName = "Weasley", Email = "ron.weasley@gmail.com" },
                new Customer { FirstName = "Hermione", LastName = "Granger", Email = "hermione.granger@yahoo.com" },
                new Customer { FirstName = "Draco", LastName = "Malfoy", Email = "draco.malfoy@hotmail.com" }
            };
            foreach (var customer in customers)
            {
                context.Customer.Add(customer);
            }
            context.SaveChanges();

            // add products
            var products = new List<Product>
            {
                new Product { Name = "wand", Description = "a magical device to cast spells", Price = 19.99M },
                new Product { Name = "caldron", Description = "a pot to brew potions", Price = 10.99M },
                new Product { Name = "chocolate frog", Description = "a tasty snack that might jump away", Price = 5.99M },
                new Product { Name = "robe", Description = "a part of the school uniform", Price = 49.99M }
            };
            foreach (var product in products)
            {
                context.Product.Add(product);
            }
            context.SaveChanges();

            // add orders
            var orders = new List<Order>
            {
                new Order { CustomerId = 1, ProductId = 1, Quantity = 1, OrderDate = new DateTime(2017, 1, 1) },
                new Order { CustomerId = 2, ProductId = 3, Quantity = 2, OrderDate = new DateTime(2017, 1, 1) },
                new Order { CustomerId = 3, ProductId = 2, Quantity = 1, OrderDate = new DateTime(2017, 1, 1) },
                new Order { CustomerId = 1, ProductId = 2, Quantity = 1, OrderDate = new DateTime(2017, 1, 1) }
            };
            foreach (var order in orders)
            {
                context.Order.Add(order);
            }
            context.SaveChanges();


            // add books
            var books = new List<Book>
            {
                new Book { Title = "How to Program", Author = "John Johnson", Price = 1.99M },
                new Book { Title = "How to Knit", Author = "Jane Doe", Price = 2.99M },
                new Book { Title = "How to Paint", Author = "Bob Ross", Price = 3.99M },
            };
            foreach (var book in books)
            {
                context.Book.Add(book);
            }
            context.SaveChanges();


            // add books
            var cats = new List<Cat>
            {
                new Cat { Name = "Garfield", Age = 2, Owner = "Jon", Breed = "tabby" },
                new Cat { Name = "Socks", Age = 3, Owner = "Jane", Breed = "persian" },
                new Cat { Name = "Randal", Age = 4, Owner = "Mark", Breed = "siamese" },
            };
            foreach (var cat in cats)
            {
                context.Cat.Add(cat);
            }
            context.SaveChanges();


            // add books
            var dogs = new List<Dog>
            {
                new Dog { Name = "Snoppy", Age = 4, Owner = "Chuck", Breed = "beagle" },
                new Dog { Name = "Lassie", Age = 4, Owner = "Tommy", Breed = "collie" },
                new Dog { Name = "Rex", Age = 4, Owner = "Jim", Breed = "german shepard" },
            };
            foreach (var dog in dogs)
            {
                context.Dog.Add(dog);
            }
            context.SaveChanges();


            // add books
            var computers = new List<Computer>
            {
                new Computer { Brand = "Dell", CPU = "i3", Memory = "8gb", Price = 799.99M },
                new Computer { Brand = "Lenovo", CPU = "i5", Memory = "8gb", Price = 899.99M },
                new Computer { Brand = "HP", CPU = "i7", Memory = "16gb", Price = 999.99M },
            };
            foreach (var computer in computers)
            {
                context.Computer.Add(computer);
            }
            context.SaveChanges();
        }
    }
}
