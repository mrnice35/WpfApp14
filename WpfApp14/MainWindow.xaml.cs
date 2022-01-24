using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection <Products> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection <Products>();
            products.Add(new Products()
            {
                ProductsName = "Яблоки",
                Price = 35,
                ProductType = ProductTypes.Food,
                Jpeg = 1
            });
            products.Add(new Products()
            {
                ProductsName = "Молоко",
                Price = 60,
                ProductType = ProductTypes.Food,
                Jpeg = 2
            });
            products.Add(new Products()
            {
                ProductsName = "Кофеварка",
                Price = 3500,
                ProductType = ProductTypes.Appliances,
                Jpeg = 3
            });
            products.Add(new Products()
            {
                ProductsName = "Микроволновка",
                Price = 6500,
                ProductType = ProductTypes.Appliances,
                Jpeg = 4
            });
            lstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Products()
            {
                ProductsName = "Электрочайник",
                Price = 4000,
                ProductType = ProductTypes.Appliances,
                Jpeg = 5
            });
        }
    }
}
