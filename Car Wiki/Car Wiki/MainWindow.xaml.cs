using Car_Wiki.Model.Classes;
using System;
using System.Collections.Generic;
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

namespace Car_Wiki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CarContext carContext;
        public MainWindow()
        {
            InitializeComponent();
            carContext = new CarContext();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var brand = txtSearch.Text;
            var cars = carContext.Cars.Where(c => c.Brand.Contains(brand)).ToList();
            lvCars.ItemsSource = cars;
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            lvCars.ItemsSource = carContext.Cars.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lvCars.SelectedItem != null)
            {
                var selectedCar = lvCars.SelectedItem as Car;
                carContext.Cars.Remove(selectedCar);
                carContext.SaveChanges();
                ShowAllCars();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
        }

        private void ShowAllCars()
        {
            lvCars.ItemsSource = carContext.Cars.ToList();
        }

        private void SeachCarsByBrand(string brand)
        {
            var cars = carContext.Cars.Where(c => c.Brand.Contains(brand)).ToList();
            lvCars.ItemsSource = cars;
        }
    }
}
