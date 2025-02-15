using HW14_task1_library;
namespace HW14_task1
{
    public class Service
    {
        private DBContext _context;
        public Service(DBContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }
        public void RemoveProduct(int productId)
        {
            var product = _context.Products.First(p => p.Id == productId);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
        }
        public void UpdateProduct(Product updatedProduct)
        {
            var product = _context.Products.First(p => p.Id == updatedProduct.Id);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                product.Stock = updatedProduct.Stock;
            }
        }
        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }
        public List<Product> GetSortedProductsByPrice()
        {
            return _context.Products.OrderBy(p => p.Price).ToList();
        }
        public bool PurchaseProduct(int productId, int customerId, int quantity)
        {
            var product = _context.Products.First(p => p.Id == productId);
            if (product != null && product.Stock >= quantity)
            {
                product.Stock -= quantity;
                _context.Orders.Add(new Order { Id = _context.Orders.Count + 1, ProductId = productId, CustomerId = customerId, Quantity = quantity, OrderDate = DateTime.Now });
                return true;
            }
            return false;
        }
        public static void Show<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
