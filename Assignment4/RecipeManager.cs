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
    internal class RecipeManager
    {
        private Recipe[] recipeList;
        private int maxNumOfRecipes = 0;

        public RecipeManager(int maxNumOfRecipes)
        {
            recipeList = new Recipe[maxNumOfRecipes];
            this.maxNumOfRecipes = maxNumOfRecipes;
        }

        //public string[] RecipeListToString()
        //{
        //}

        public bool Add(Recipe recipe)
        {
            int count = GetCurrentNumOfRecipes();

            if (recipe != null && count < maxNumOfRecipes)
            {
                recipeList[count] = recipe;
                MessageBox.Show($"count: {count} recipe: {recipe.Name}");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Add(string name, FoodCategory category, string[] ingredients)
        {
            Recipe recipe = new Recipe(name, category.ToString(), ingredients);

            recipeList[GetCurrentNumOfRecipes()] = recipe;

            return true;
        }

        public bool ChangeRecipeAt(int index, Recipe recipe)
        {
            bool ok = false;

            if (CheckIndex(index) && (recipe != null))
            {
                recipeList[index] = recipe;
            }

            return ok;
        }

        public bool DeleteRecipeAt(int index)
        {
            bool ok = false;

            if (CheckIndex(index))
            {
                recipeList[index] = null;
                ok = true;
            }

            return ok;
        }

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

        public Recipe GetRecipeAt(int index)
        {
            // TODO: recipeList gets duplicated values on add
            return recipeList[index];
        }

        private bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < GetCurrentNumOfRecipes());

            return ok;
        }

        //private int FindVacantPosition()
        //{
        //}

        private void MoveRecipesOneStepToLeft(int index)
        {
            for (int i = index; i < recipeList.Length - 2; i++)
            {
                recipeList[i] = recipeList[i + 1];
            }
            recipeList[recipeList.Length - 1] = null;
        }
    }
}
