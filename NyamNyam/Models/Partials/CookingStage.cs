using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyamNyam.Models
{
    public partial class CookingStage
    {
        public static int stepNumber = 1;

        public string Steps
        {
            get
            {
                string[] steps = ProcessDescription.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder stepsWithNumbers = new StringBuilder();
                foreach (var step in steps)
                {

                    string cleanStep = step.Trim();
                    stepsWithNumbers.AppendFormat("{0}. {1}\n", stepNumber, cleanStep);
                    stepNumber++;
                }

                return stepsWithNumbers.ToString();
            }
        }
    }
}
