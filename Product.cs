using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Midterm
{
    public class Product
    {
        //Fields
        string _productName;
        decimal _price;
        //constructor
        public Product(string productName, decimal price)
        {
            _productName = productName;
            _price = price;
        }

        public string ProductName { get => _productName; set => _productName = value; }
        public decimal Price { get => _price; set => _price = value; }

        public override string ToString()
        {
            return $"{_productName}-{_price:c}";
        }
    }
}
