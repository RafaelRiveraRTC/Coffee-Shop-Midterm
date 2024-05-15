using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Coffee_Shop_Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> previousOrders = new List<Product>(); // Will hold all completed orders
        Inventory inventory = new Inventory(); // Used to access list of product
        Order currentOrder; // Class scope variable to easily pass the current order around.
        public MainWindow()
        {
            InitializeComponent();
            currentOrder = new Order("", new List<Product>(), "", 0.1m);//In order for this to work you need to pass through the parameters you set up in the order class
            cmbChooseOrderName.ItemsSource = previousOrders;
        }

        private void Dark_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.CoffeeProducts[0]);
            newOrders.Text = currentOrder.FormatOrder();
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.CoffeeProducts[1]);
            newOrders.Text = currentOrder.FormatOrder();
        }

        private void LightButton_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.CoffeeProducts[2]);
            newOrders.Text = currentOrder.FormatOrder();
        }

        private void BlackButton_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.TeaProducts[0]);
            newOrders.Text = currentOrder.FormatOrder();
        }

        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.TeaProducts[1]);
            newOrders.Text = currentOrder.FormatOrder();
        }

        private void ChaiButton_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.TeaProducts[2]);
            newOrders.Text = currentOrder.FormatOrder();
        }

        private void SandWichButton_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.BreakfastProducts[0]);
            newOrders.Text = currentOrder.FormatOrder();
        }

        private void PastryButton_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.BreakfastProducts[1]);
            newOrders.Text = currentOrder.FormatOrder();
        }

        private void FruitButton_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.BreakfastProducts[2]);
            newOrders.Text = currentOrder.FormatOrder();
        }

        private void CompletePurchaseButton_Click(object sender, RoutedEventArgs e)
        {
            string customerName = txtName.Text.Trim();

            if (!string.IsNullOrEmpty(customerName))
            {
                currentOrder.CustomerName = customerName;//Assign the name
                previousOrders.AddRange(currentOrder.ProductsInOrder);
                cmbChooseOrderName.ItemsSource = previousOrders;//Reset With Updated List
                cmbChooseOrderName.Items.Refresh();

                txtName.Clear();
                newOrders.Text = "";

                currentOrder = new Order("", new List<Product>(), "", 0.1m);

                MessageBox.Show("Thank You For Your Selection Your order will be out in a moment");
            }
            else
            {
                MessageBox.Show("A name is required to place your order");
            }


        }

      private void cmbChooseOrderName_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if (cmbChooseOrderName.SelectedItem != null)
    {
        Order selectedOrder = cmbChooseOrderName.SelectedItem as Order;
        oldOrders.Text = selectedOrder.FormatOrder();
    }
}
    }
}