using System;
using System.Collections.Generic;
using System.Data.Common;
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
using NyamNyam.Models;

namespace NyamNyam.Pages
{
    /// <summary>
    /// Логика взаимодействия для DishesPage.xaml
    /// </summary>
    public partial class DishesPage : Page
    {
        public static List<Dish> Dishes { get; set; }
        public static List<Category> Categories { get; set; }
        public DishesPage()
        {
            InitializeComponent();
            Dishes = DBconnection.NyamDB.Dish.ToList();
            Categories = DBconnection.NyamDB.Category.ToList();
            DishesLV.ItemsSource = Dishes;
            CategoryCB.ItemsSource = Categories;
            Categories.Insert(0, new Category() { Name = "All categories" });
            CategoryCB.SelectedIndex = 0;
            double max = Dishes[0].FinalDishPriceDollar;
            double min = Dishes[0].FinalDishPriceDollar;
            foreach (Dish dish in Dishes)
            {
                if (dish.FinalDishPriceDollar > max)
                {
                    max = dish.FinalDishPriceDollar;
                }
                if (dish.FinalDishPriceDollar < min)
                {
                    min = dish.FinalDishPriceDollar;
                }
            }
            PriceSlider.Maximum = max;
            PriceSlider.Minimum = min;
            PriceSlider.Value = max;
            this.DataContext = this;
        }

        private void FilterTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void CategoryCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Refresh();
        }

        private void IngredientCB_Checked(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void IngredientCB_Unchecked(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void DishesLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new RecipeForDish(DishesLV.SelectedItem as Dish));
        }

        private void Refresh()
        {
            var filterDishes = DBconnection.NyamDB.Dish.ToList();
            if (FilterTB.Text.Length > 0)
            {
                filterDishes = filterDishes.Where(i => i.Name.ToLower().StartsWith(FilterTB.Text.Trim().ToLower())
                || i.Description.ToLower().StartsWith(FilterTB.Text.Trim().ToLower())).ToList();
            }

            var name = CategoryCB.SelectedItem as Category;
            if (CategoryCB.SelectedIndex > 0 && name != null)
                filterDishes = filterDishes.Where(x => x.CategoryId == name.Id).ToList();


            if ((bool)IngredientCB.IsChecked)
                filterDishes = filterDishes.Where(i => i.Availble == true).ToList();

            filterDishes = filterDishes.Where(x => (double)x.FinalDishPriceDollar <= PriceSlider.Value).ToList();

            DishesLV.ItemsSource = filterDishes;

        }
    }
}
