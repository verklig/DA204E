using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// This class temporarily saves data to be added in the recipe as an array in the "RecipeManager" class.
    /// </summary>
    public partial class Recipe
    {
        private FoodCategory category; // Category of the recipe used as the enum class
        private string name; // Name of the recipe as a string
        private string description; // Description of the recipe as a string
        private string[] ingredients; // Ingredients to be added to the recipe as an array of strings

        // Getters and setters
        public FoodCategory Category { get { return category; } set { category = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string[] Ingredients { get { return ingredients; } set { ingredients = value; } }
        public int MaxNumOfIngredients { get; }

        // This is the constructor of the class, it takes an integer
        // as an argument that is "maxNumOfIngredients" and initializes
        // the "MaxNumOfIngredients" property with this value, it also creates
        // a new "ingredients" string array with a length equal to the value of "maxNumOfIngredients"
        public Recipe(int maxNumOfIngredients)
        {
            MaxNumOfIngredients = maxNumOfIngredients;
            ingredients = new string[maxNumOfIngredients];
        }

        #region Unused commented out code
        //public Recipe(string name, FoodCategory category, string[] ingredients)
        //{
        //    Name = name;
        //    Category = category;
        //    Ingredients = ingredients;
        //}

        //public bool AddIngredient(string input)
        //{
        //    int count = GetCurrentNumOfIngredients();

        //    if (input != null && count < MaxNumOfIngredients)
        //    {
        //        ingredients[count] = input;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public bool ChangeIngredientAt(int index, string value)
        //{
        //    bool ok = false;

        //    if (CheckIndex(index) && (value != null))
        //    {
        //        ingredients[index] = value;
        //    }

        //    return ok;
        //}

        //public void DeleteIngredientAt(int index)
        //{
        //    if (CheckIndex(index))
        //    {
        //        ingredients[index] = null;
        //    }
        //}

        //private bool CheckIndex(int index)
        //{
        //    bool ok = (index >= 0) && (index < GetCurrentNumOfIngredients());

        //    return ok;
        //}
        #endregion

        // This method returns the current number of non-null ingredients in the "ingredients" array
        // and it iterates through the array and counts the number of elements that are not null
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

        // This method returns a string containing a comma-separated list of all the non-null ingredients in the "ingredients" array 
        // it uses a loop to concatenate the ingredients into a string with commas between them, this is used to print the ingredients
        // as a string in a nice looking order
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

        // This method overrides the "ToString()" method to return a formatted string
        // that displays the name, category and number of ingredients for the recipe
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

        // This method returns a string containing the name, category, ingredients, and description of the recipe
        // it calls the "GetIngredientsString()" method and concatenates the resulting string with the "description" string
        // separated by two newline characters
        public string ToStringDetailed()
        {
            string strOut = "INGREDIENTS\n";

            strOut += GetIngredientsString();
            strOut += "\n\n" + description;

            return strOut;
        }
    }
}
