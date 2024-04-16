using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyamNyam.Models
{
    public partial class IngredientOfStage
    {
        public double SumQuantity {  get; set; }
        public double TotalQuantity {  get; set; }
        public double TotalCost
        {
            get
            {
                return TotalQuantity * Ingredient.CostInDollars;
            }
        }
        public bool IndicatorColor
        {
            get
            {
                if (TotalQuantity <= Ingredient.AvailableCount )
                    return true;
                else
                    return false;
            }
        }
    }
}
