using System;
using System.Collections.Generic;
using System.Linq;
using HW14_task1_library;
namespace HW14_task1
{
    public class DBContext
    {
        public List<Category> Categories { get; set; } = new();
        public List<Manufacturer> Manufacturers { get; set; } = new();
        public List<Product> Products { get; set; } = new();
        public List<Customer> Customers { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
        public DBContext()
        {
            Categories.Add(new Category { Id = 1, Name = "Електроніка" });
            Manufacturers.Add(new Manufacturer { Id = 1, Name = "Samsung" });
            Products.Add(new Product { Id = 1, CategoryId = 1, ManufacturerId = 1, Name = "Смартфон", Price = 20000, Stock = 10 });
            Customers.Add(new Customer { Id = 1, Name = "Іван Іванов" });
        }
    }
}
