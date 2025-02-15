namespace HW14_task1_library
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Category: {Name}, Id: {Id}";
        }
    }
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Manufacturer: {Name}, Id: {Id}";
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price}, Stock: {Stock}";
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Customer: {Name}, Id: {Id}";
        }
    }
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public override string ToString()
        {
            return $"Order: ProductId: {ProductId}, CustomerId: {CustomerId}, Quantity: {Quantity}, OrderDate: {OrderDate}";
        }
    }
}
