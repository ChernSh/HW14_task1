using HW14_task1_library;
namespace HW14_task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            DBContext dbContext = new DBContext();
            Service shopService = new Service(dbContext);
            Console.WriteLine("Список товарів:");
            Service.Show(dbContext.Products);
            var newProduct = new Product { Id = 2, CategoryId = 1, ManufacturerId = 1, Name = "Ноутбук", Price = 40000, Stock = 5 };
            shopService.AddProduct(newProduct);
            Console.WriteLine("\nДодано товар: " + newProduct.Name);
            var sortedProducts = shopService.GetSortedProductsByPrice();
            Console.WriteLine("\nСписок товарів після сортування за ціною:");
            Service.Show(sortedProducts);
            bool success = shopService.PurchaseProduct(1, 1, 2);
            Console.WriteLine("\nРезультат покупки 2 смартфонів: " + (success ? "Успішно!" : "Недостатньо товару!"));
            Console.WriteLine("\nСписок товарів після покупки:");
            Service.Show(dbContext.Products);
        }
    }
}
