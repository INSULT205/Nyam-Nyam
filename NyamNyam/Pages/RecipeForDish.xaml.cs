using NyamNyam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Reflection;
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

namespace NyamNyam.Pages
{
    /// <summary>
    /// Логика взаимодействия для RecipeForDish.xaml
    /// </summary>
    public partial class RecipeForDish : Page
    {   
        int costdishes = 1;
        int cost;
        double FinalPrice;

        public static List<Dish> Dishes {get;set;}
        public static List<Category> categories {get;set;}
        public static List<CookingStage> cookingStages { get;set;}   

        public static List<IngredientOfStage> ingredientOfStages { get;set;}
        public RecipeForDish(Dish dish)
        {
            InitializeComponent();
            Dishes = DBconnection.NyamDB.Dish.ToList();
            categories = new List<Category>(DBconnection.NyamDB.Category.ToList());
            cookingStages = new List<CookingStage>(DBconnection.NyamDB.CookingStage.Where(i => i.DishId == dish.Id).ToList());

            DishRecipeTB.Text = dish.Name;
            CategoryTB.Text = DBconnection.NyamDB.Category.FirstOrDefault(i => i.Id == dish.CategoryId).Name;
            DescriptionTB.Text = dish.Description;
            cost = dish.BaseServingsQuantity;
            ServingsTB.Text = cost.ToString();

            int min = 0;
            int count = 0;
            while (count < cookingStages.Count)
            {
                min += (int)cookingStages[count].TimeInMinutes;
                count ++;
            }
            CookingTimeTB.Text = min.ToString();

            FinalPrice = dish.FinalDishPriceDollar ;
            TotalCostTB.Text = (FinalPrice * Convert.ToDouble(costdishes)).ToString();

            ingredientOfStages = new List<IngredientOfStage>();
            List<IngredientOfStage> list = dish.CookingStage.SelectMany(x => x.IngredientOfStage).ToList();
            foreach (var item in list)
            {
                var existIngredient = ingredientOfStages.Find(i => i.IngredientId == item.IngredientId);
                if(existIngredient == null)
                {
                    item.SumQuantity = item.Quantity;
                    ingredientOfStages.Add(item);
                }
                else
                {
                    existIngredient.SumQuantity += item.Quantity;
                }
            }
            IngredientsLv.ItemsSource = ingredientOfStages;
          


            CookingStage.stepNumber = 1;
            var t = dish.CookingStage.SelectMany(s => s.IngredientOfStage).ToList();
            var v = new List<IngredientOfStage>();
            foreach (var i in t)
            {
                var w = v.Find(x => x.IngredientId == i.IngredientId);
                if (w == null)
                {
                    i.SumQuantity = i.Quantity;
                    v.Add(i);
                }
                else
                    w.SumQuantity += i.Quantity;
            }
            IngredientsLv.ItemsSource = v;
            LVRecipes.ItemsSource = dish.CookingStage.ToList();

            Refresh();
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DishesPage());
        }

        private void MinusBT_Click(object sender, RoutedEventArgs e)
        {
            if (ServingsTB.Text != "0")
            {
                costdishes -= 1;
                ServingsTB.Text = (cost * costdishes).ToString();
                TotalCostTB.Text = (FinalPrice * Convert.ToDouble(costdishes)).ToString();
                Refresh();
            }
        }

        private void PlusBT_Click(object sender, RoutedEventArgs e)
        {
                costdishes += 1;
                ServingsTB.Text = (cost * costdishes).ToString();
                TotalCostTB.Text = (FinalPrice * Convert.ToDouble(costdishes)).ToString();
                Refresh();
        }

        private void Refresh()
        {
            foreach(var item in ingredientOfStages)
            {
                item.TotalQuantity = item.SumQuantity * costdishes;
            }
            IngredientsLv.Items.Refresh();
        }
    }
}
