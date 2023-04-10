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
        private FoodCategory category;
        private string name;
        private string description;
        private string[] ingredients;

        public FoodCategory Category { get { return category; } set { category = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string[] Ingredients { get { return ingredients; } set { ingredients = value; } }
        public int MaxNumOfIngredients { get; }

        public Recipe(int maxNumOfIngredients)
        {
            // ingredients = new Recipe[maxNumOfIngredients];
        }

        public Recipe(string name, FoodCategory category, string[] ingredients)
        {
            Name = name;
            Category = category;
            Ingredients = ingredients;
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

            string strOut = $"{name,-25}{category,-21}{amtIngredients}";

            return strOut;
        }

        public string ToStringDetailed()
        {
            string strOut = "INGREDIENTS\n";
            
            for (int i = 0; i < Ingredients.Length; i++)
            {
                if (i != Ingredients.Length - 1)
                {
                    strOut += ingredients[i] + ", ";
                }
                else
                {
                    strOut += ingredients[i];
                }
            }

            strOut += "\n\n" + description;

            return strOut;
        }
    }
}
