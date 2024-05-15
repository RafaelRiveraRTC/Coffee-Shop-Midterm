using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Midterm
{
    public class Inventory
    {
        // Fields
        List<Product> _coffeeProducts;
        List<Product> _teaProducts;
        List<Product> _breakfastProducts;

        // Constructor
        public Inventory()
        {
            // Preloads our lists with 3 items a piece
            _coffeeProducts = new List<Product>()
            {
                new Product("Dark Roast Coffee", 3.50m),
                new Product("Medium Roast Coffee", 3.25m),
                new Product("Light Roast Coffee", 3.00m)
            };

            _teaProducts = new List<Product>()
            {
                new Product("Black Tea", 2.75m),
                new Product("Green Tea", 2.50m),
                new Product("Chai Tea", 3.00m)
            };

            _breakfastProducts = new List<Product>()
            {
                new Product("Sandwich", 4.99m),
                new Product("Pastry", 2.99m),
                new Product("Fruit", 3.75m)
            };




        } // Inventory

        // Properties - Grants access to the list to get the products
        public List<Product> CoffeeProducts { get => _coffeeProducts; }
        public List<Product> TeaProducts { get => _teaProducts; }
        public List<Product> BreakfastProducts { get => _breakfastProducts; }
    }
}
