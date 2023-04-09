using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public partial class Recipe
    {

        // TODO: change type from string to FoodCategory
        private string category;
        private string name;
        private string description;
        private string[] ingredients;

        public string Category { get { return category; } set { category = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string[] Ingredients { get { return ingredients; } set { ingredients = value; } }
        public int MaxNumOfIngredients { get; }

        public Recipe(int maxNumOfIngredients)
        {
            // ingredients = new Recipe[maxNumOfIngredients];
        }

        public Recipe(string name, string category, string[] ingredients)
        {
            
        }

        public int CurrentNumOfIngredients()
        {
            int value = 1;

            return value;
        }

        public override string ToString()
        {
            int amtIngredients = 0;

            if (ingredients != null)
            {
                amtIngredients = ingredients.Length;
            }

            string strOut = $"{name,-60}{category,-50}{amtIngredients,-50}";
            return strOut;
        }






    }
}
