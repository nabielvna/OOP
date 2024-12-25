using System;

namespace Encapsulation.Extra
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty");
            if (price <= 0)
                throw new ArgumentException("Price must be positive");
            if (quantity < 0)
                throw new ArgumentException("Quantity cannot be negative");

            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void AddStock(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount to add must be positive");
            Quantity += amount;
        }

        public void SellProduct(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount to sell must be positive");
            if (amount > Quantity)
                throw new InvalidOperationException("Not enough stock to sell");
            Quantity -= amount;
        }

        public decimal GetTotalValue()
        {
            return Price * Quantity;
        }
    }
}