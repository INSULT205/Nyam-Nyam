using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyamNyam.Models
{
    public partial class Ingredient
    {
        public double CostInDollars
        {
            get
            {
                return CostInCents * 0.01;
            }
        }
    }
}
