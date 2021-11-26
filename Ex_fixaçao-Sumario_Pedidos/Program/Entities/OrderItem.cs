using Program.Entities;
using System.Collections.Generic;

namespace Program.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public List<Product> Product { get; set; } = new List<Product>();

        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
        }

        public void AddProduct(Product product)
        {
            Product.Add(product);
        }

        public double SubTotal(int quantity, double price)
        {
            return quantity * price;
        }
    }
}
