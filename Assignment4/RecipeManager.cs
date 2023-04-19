using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// This class is the manager for the recipes, it adds or changes the recipes if the values are valid.
    /// </summary>
    internal class RecipeManager
    {
        private Recipe[] recipeList; // An array of recipes
        private int maxNumOfRecipes = 0; // Instance variable for easier accessibility

        /// <summary>
        /// This is the constructor of the class, it takes an integer
        /// as an argument that is "maxNumOfRecipes" and sets
        /// the instance variable "maxNumOfRecipes" to this value. It also creates
        /// a new "recipeList" array with a length equal to the value of "maxNumOfRecipes".
        /// </summary>
        /// <param name="maxNumOfRecipes"></param>
        public RecipeManager(int maxNumOfRecipes)
        {
            recipeList = new Recipe[maxNumOfRecipes];
            this.maxNumOfRecipes = maxNumOfRecipes;
        }

        #region Unused commented out code
        //public bool Add(string name, FoodCategory category, string[] ingredients)
        //{
        //    Recipe recipe = new Recipe(name, category, ingredients);

        //    recipeList[GetCurrentNumOfRecipes()] = recipe;

        //    return true;
        //}

        //public bool ChangeRecipeAt(int index, Recipe recipe)
        //{
        //    bool ok = false;

        //    if (CheckIndex(index) && (recipe != null))
        //    {
        //        recipeList[index] = recipe;
        //    }

        //    return ok;
        //}
        #endregion

        /// <summary>
        /// This method adds a new recipe to the list and it
        /// returns true if the recipe was added successfully, otherwise false.
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns>true or false</returns>
        public bool Add(Recipe recipe)
        {
            int count = GetCurrentNumOfRecipes();

            if (recipe != null && count < maxNumOfRecipes)
            {
                recipeList[count] = recipe;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method deletes the recipe at the specified index in the list and it
        /// returns true if the recipe was deleted successfully, otherwise false.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>true or false</returns>
        public bool DeleteRecipeAt(int index)
        {
            bool ok = false;

            if (CheckIndex(index))
            {
                recipeList[index] = null;
                MoveRecipesOneStepToLeft(index);
                ok = true;
            }

            return ok;
        }

        /// <summary>
        /// This method returns the current number of recipes in the list.
        /// </summary>
        /// <returns>current number of recipes</returns>
        public int GetCurrentNumOfRecipes()
        { 
            int count = 0;
            
            foreach (Recipe currRecipe in recipeList)
            {
                if (currRecipe != null)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// This method returns the recipe at the specified index in the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>recipe at the specified index</returns>
        public Recipe GetRecipeAt(int index)
        {
            return recipeList[index];
        }

        /// <summary>
        /// This method checks whether the specified index is valid, for example
        /// within the range of the current number of recipes.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>true or false</returns>
        private bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < GetCurrentNumOfRecipes());

            return ok;
        }

        /// <summary>
        /// This method moves all recipes in the list one step to the left from the specified index
        /// so that if you delete something that is not the last avalible index at that time
        /// they get sorted correctly.
        /// </summary>
        /// <param name="index"></param>
        private void MoveRecipesOneStepToLeft(int index)
        {
            for (int i = index; i < recipeList.Length - 1; i++)
            {
                recipeList[i] = recipeList[i + 1];
            }
            recipeList[recipeList.Length - 1] = null;
        }
    }
}
