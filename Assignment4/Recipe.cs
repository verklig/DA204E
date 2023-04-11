using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public partial class Recipe
    {
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
            MaxNumOfIngredients = maxNumOfIngredients;
            ingredients = new string[maxNumOfIngredients];
        }

        public Recipe(string name, FoodCategory category, string[] ingredients)
        {
            Name = name;
            Category = category;
            Ingredients = ingredients;
        }

        public bool AddIngredient(string input)
        {
            int count = GetCurrentNumOfIngredients();

            if (input != null && count < MaxNumOfIngredients)
            {
                ingredients[count] = input;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangeIngredientAt(int index, string value)
        {
            bool ok = false;

            if (CheckIndex(index) && (value != null))
            {
                ingredients[index] = value;
            }

            return ok;
        }

        public void DeleteIngredientAt(int index)
        {
            if (CheckIndex(index))
            {
                ingredients[index] = null;
            }
        }

        public int GetCurrentNumOfIngredients()
        {
            int count = 0;

            foreach (string currIngredient in ingredients)
            {
                if (currIngredient != null)
                {
                    count++;
                }
            }

            return count;
        }

        public string GetIngredientsString()
        {
            string strOut = "";
            int amtIngredients = GetCurrentNumOfIngredients();

            for (int i = 0; i < amtIngredients; i++)
            {
                if (i != amtIngredients - 1)
                {
                    strOut += ingredients[i] + ", ";
                }
                else
                {
                    strOut += ingredients[i];
                }
            }

            return strOut;
        }

        private bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < GetCurrentNumOfIngredients());

            return ok;
        }

        public override string ToString()
        {
            int amtIngredients = 0;

            if (ingredients != null)
            {
                amtIngredients = GetCurrentNumOfIngredients();
            }

            string strOut = $"{name,-25}{category,-21}{amtIngredients}";

            return strOut;
        }

        public string ToStringDetailed()
        {
            string strOut = "INGREDIENTS\n";

            strOut += GetIngredientsString();
            strOut += "\n\n" + description;

            return strOut;
        }
    }
}
