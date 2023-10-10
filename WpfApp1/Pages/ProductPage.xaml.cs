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
using WpfApp1.Models;
using WpfApp1.Pages;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {

        public Dictionary<string, Func<Dish, object>>  sortings;
        public ProductPage()
        {
            InitializeComponent();
            ListProductLV.ItemsSource = App.bd.Dish.ToList();

            sortings = new Dictionary<string, Func<Dish, object>>{
                {"От А до Я", x=>x.Title },
                {"От Я до А", x=>x.Title },
                {"Сначала дорогие", x=>x.Cost },
                {"Сначала дешевые", x=>x.Cost },

            };

            SortCb.ItemsSource = sortings.Keys;

            var categories = App.bd.Category.ToList();
            categories.Insert(0, new Category { Title = "Все" });
            FiltrCb.ItemsSource = categories;
         
        }
        
        public void Reshres() 
        {
        var product = App.bd.Dish.ToList();
            var fikter = FiltrCb.SelectedItem as Category;
            var sort = SortCb.SelectedItem as string;

            if (fikter != null && fikter.Title != "Все")
            {
                product = product.Where(x => x.Category == fikter).ToList();

            }

            if (sort != null)
            {

                product = product.OrderBy(sortings[sort]).ToList();

                if (sort == "От Я до А" || sort == "Сначала дорогие")
                    product.Reverse();
            }
            //else if (fikter.Title == "Все")
            //{
            //    product = App.bd.Dish.ToList().Where(x => x.Category == fikter).ToList();
            //}
            


            ListProductLV.ItemsSource = product;
            ListProductLV.Items.Refresh();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DelitBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FiltrCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Reshres();
        }

        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Reshres();
        }
    }
}
