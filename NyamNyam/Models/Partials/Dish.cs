using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyamNyam.Models
{
    public partial class Dish
    {
        public double FinalDishPriceDollar
        {
            get
            {
                return FinalPriceInCents * 0.01;
            }
        }
        public string OpacityDish
        {
            get
            {
                var destinationFormat = string.Empty;
                var allIngredientRecipeSteps = this.CookingStage.SelectMany(x => x.IngredientOfStage);
                if (allIngredientRecipeSteps.Any())
                {
                    foreach (var ingredientStep in allIngredientRecipeSteps)
                    {
                        if (allIngredientRecipeSteps.Where(x => x.IngredientId == ingredientStep.IngredientId).Sum(x => x.Quantity) > ingredientStep.Ingredient.AvailableCount)
                        {
                            destinationFormat = "Gray32Float";
                            Availble = false;
                            DBconnection.NyamDB.SaveChanges();
                        }
                    }
                }
                else
                {
                    destinationFormat = "Bgra32";
                    Availble = true;
                    DBconnection.NyamDB.SaveChanges();
                }
                return destinationFormat;
            }
        }

    }
}
