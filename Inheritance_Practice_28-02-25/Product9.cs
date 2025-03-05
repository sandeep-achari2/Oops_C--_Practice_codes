using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_28_02_25
{
    public class Product9
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product9(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual double GetDiscountedPrice()
        {
            return Price; // No discount by default
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price:F2}, Discounted Price: ${GetDiscountedPrice():F2}");
        }
    }
    public class ElectronicProduct : Product9
    {
        public ElectronicProduct(string name, double price) : base(name, price) { }
        public override double GetDiscountedPrice()
        {
            return Price * 0.90; // 10% discount
        }
    }
    public class ClothingProduct : Product9
    {
        public ClothingProduct(string name, double price) : base(name, price) { }
        public override double GetDiscountedPrice()
        {
            return Price * 0.80; // 20% discount
        }
    }
}
