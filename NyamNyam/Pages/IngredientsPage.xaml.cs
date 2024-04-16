using NyamNyam.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace NyamNyam.Pages
{
    /// <summary>
    /// Логика взаимодействия для IngredientsPage.xaml
    /// </summary>
    
    
    public partial class IngredientsPage : Page
    {
        public static List<Ingredient> ingredient { get; set; }
        public IngredientsPage()
        {
            InitializeComponent();
            Refresh();
        }

        private void PlusBT_Click(object sender, RoutedEventArgs e)
        {
            var ingredient = (sender as Button).DataContext as Ingredient;
            ingredient.AvailableCount += 1;
            DBconnection.NyamDB.SaveChanges();
            Refresh();
        }

        private void MinusBT_Click(object sender, RoutedEventArgs e)
        {
            var ingredient = (sender as Button).DataContext as Ingredient;
            try
            {
                if(ingredient.AvailableCount > 0)
                    ingredient.AvailableCount -= 1;
                DBconnection.NyamDB.SaveChanges();
            }
            catch 
            {
                MessageBox.Show("Count ingredient = 0");
            }
            Refresh();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var ingredient = (sender as TextBlock).DataContext as Ingredient;
            var dishCount = DBconnection.NyamDB.IngredientOfStage.Where(x => x.IngredientId == ingredient.Id).Count();
            if (dishCount == 0)
            {
                DBconnection.NyamDB.Ingredient.Remove(ingredient);
                DBconnection.NyamDB.SaveChanges();
                Refresh();
            }
            else
                MessageBox.Show($"You can not delete this ingredient, because hi is used in {dishCount} dishes", "Warning", MessageBoxButton.OK, MessageBoxImage.Stop);
        }
        private void Refresh()
        {
            ingredient = DBconnection.NyamDB.Ingredient.ToList();
            IngredientLV.ItemsSource = ingredient;

            double CostIngredient = 0;
            foreach (var i in ingredient)
            {
                double Sum = i.CostInDollars * i.AvailableCount;
                CostIngredient += Sum;
            }
            TotalIngredientsCostTB.Text = CostIngredient.ToString();
        }

        private void CountTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }

        private void CountTB_TextChanged(object sender, TextChangedEventArgs e)
        {
           DBconnection.NyamDB.SaveChanges();
        }
    }
}
