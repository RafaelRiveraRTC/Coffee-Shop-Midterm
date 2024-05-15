using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Coffee_Shop_Midterm
{
    internal class Order
    {
        //fields
        string _orderNumber;
        List<Product> _productsInOrder;
        string _customerName;
        decimal _tax;

        //constructor
        public Order(string orderNumber, List<Product> productsInOrder, string customerName, decimal tax)
        {
            Random rand = new Random();
            _orderNumber =  rand.Next(10000000, 100000000).ToString();
            _productsInOrder = new List<Product>();
            _customerName = customerName;
            _tax = tax;
        }

        // Methods

        public void AddProduct(Product product)
        {
            _productsInOrder.Add(product);
        }

        public string FormatOrder()
        {
            decimal subtotal = Subtotal();

            decimal taxAmount = Subtax();

            decimal total = subtotal + taxAmount;

            // Methods
            string formattedString = "";
            // 
            formattedString += $"Order Number: {_orderNumber}\n";
            // Student Name
            formattedString += $"Student Name: {_customerName}\n";

            formattedString += "-- Products\n";



            //
            // Courses
            foreach (Product product in _productsInOrder)
            {
                formattedString += $"{product.ProductName} - {product.Price}\n";
            }

            formattedString += $"\nSubtotal : ${subtotal}\n";
            formattedString += $"Tax: {_tax:P1}\n";
            formattedString += $"Total Tax: ${taxAmount}\n";
            formattedString += $"Total: ${total}\n";

            return formattedString;
        }

        public decimal Subtotal()
        {
            decimal subtotal = 0;
            foreach (Product product in _productsInOrder)
            {
                subtotal += product.Price;
            }
            return subtotal;
        }

        public decimal Subtax()
        {
            return Subtotal() * _tax;
        }

        //properties
        public string OrderNumber { get => _orderNumber; }
        public List<Product> ProductsInOrder { get => _productsInOrder; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public decimal Tax { get => _tax; set => _tax = value; }

        public override string ToString()
        {
            return $"{_customerName} - {_orderNumber}";
        }
    }
}
