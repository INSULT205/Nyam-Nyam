using NyamNyam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyamNyam
{
    public class CheckAvialable
    {
        public static void Start()
        {
            List<Dish> dishes = DBconnection.NyamDB.Dish.ToList();
            for (int i = 0; i < dishes.Count; i++)
            {
                dishes[i].Availble = true;
                int id = dishes[i].Id;
                List<CookingStage> cookingStages = DBconnection.NyamDB.CookingStage.Where(x => x.DishId == id).ToList();
                List<IngredientOfStage> ingredientOfStages = new List<IngredientOfStage>();
                for (int j = 0; j < cookingStages.Count; j++)
                {
                    
                }
                for (int j = 0; j < ingredientOfStages.Count; j++)
                {
                    if (ingredientOfStages[j].Ingredient.AvailableCount < ingredientOfStages[j].Quantity)
                        dishes[i].Availble = false;
                }
            }
            DBconnection.NyamDB.SaveChanges();
        }
    }
}
