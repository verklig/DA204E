using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment4
{
    public partial class MainForm : Form
    {
        private const int maxNumOfIngredients = 50;
        private const int maxNumOfRecipes = 200;

        private Recipe currRecipe = new Recipe(maxNumOfIngredients);
        private RecipeManager recipeMngr = new RecipeManager(maxNumOfRecipes);

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            FoodCategory addCategory = new FoodCategory();
            Array itemNames = Enum.GetNames(typeof(FoodCategory));

            for (int i = 0; i < itemNames.Length; i++)
            {
                cboxCat.Items.Add(addCategory);
                addCategory++;
            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            bool ok = ReadRecipeInput();

            if (ok)
            {
                bool arrayFull = !recipeMngr.Add(currRecipe);

                if (!arrayFull)
                {
                    UpdateGUI();

                    txtRecipe.Clear();
                    txtNameOfRecipe.Clear();
                    cboxCat.SelectedIndex = -1;
                }
                else
                {
                    errorRecipeList.SetError(btnAddRecipe, "List is full");
                }
            }
        }

        private bool ReadRecipeInput()
        {
            bool nameOK = ReadRecipeName();
            bool catOK = ReadRecipeCategory();
            bool textOK = ReadRecipeDescription();

            return nameOK && catOK && textOK;
        }

        private void UpdateGUI()
        {
            listRecipe.Items.Clear();

            int amtRecipes = recipeMngr.GetCurrentNumOfRecipes();

            for (int index = 0; index < amtRecipes; index++)
            {
                Recipe recipe = recipeMngr.GetRecipeAt(index);
                // MessageBox.Show($"i: {index} recipe: {recipe.Name}");
                listRecipe.Items.Add(recipe.ToString());
            }
        }

        private bool ReadRecipeName()
        {
            string recipeName = txtNameOfRecipe.Text;

            bool ok = ValidateRecipeName();

            if (ok)
            {
                currRecipe.Name = recipeName;
            }

            return ok;
        }

        private bool ReadRecipeCategory()
        {
            string recipeCat = cboxCat.Text;

            bool ok = ValidateRecipeCategory();

            if (ok)
            {
                currRecipe.Category = recipeCat;
            }

            return ok;
        }

        private bool ReadRecipeDescription()
        {
            string recipeDesc = txtRecipe.Text;

            bool ok = ValidateRecipeDescription();

            if (ok)
            {
                currRecipe.Description = recipeDesc;
            }

            return ok;
        }

        private bool ValidateRecipeName()
        {
            bool ok = true;
            if (txtNameOfRecipe.Text == "")
            {
                errorRecipeName.SetError(txtNameOfRecipe, "Please add a name for the recipe");
                ok = false;
            }
            else
            {
                errorRecipeName.SetError(txtNameOfRecipe, "");
            }

            return ok;
        }

        private bool ValidateRecipeCategory()
        {
            bool ok = true;
            if (cboxCat.Text == "")
            {
                errorRecipeCat.SetError(cboxCat, "Please select a category");
                ok = false;
            }
            else
            {
                errorRecipeCat.SetError(cboxCat, "");
            }

            return ok;
        }

        private bool ValidateRecipeDescription()
        {
            bool ok = true;
            if (txtRecipe.Text == "")
            {
                errorRecipeText.SetError(txtRecipe, "Please add instructions");
                ok = false;
            }
            else
            {
                errorRecipeText.SetError(txtRecipe, "");
            }

            return ok;
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            IngredientsForm dlg = new IngredientsForm(currRecipe);
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                if (currRecipe.CurrentNumOfIngredients() <= 0)
                {

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listRecipe.SelectedIndex;

            if (index >= 0)
            {
                bool ok = recipeMngr.DeleteRecipeAt(index);

                if (ok)
                {
                    UpdateGUI();
                }
            }
        }

        private void btnEditBegin_Click(object sender, EventArgs e)
        {
            int index = listRecipe.SelectedIndex;

            if (index >= 0)
            {
                currRecipe = recipeMngr.GetRecipeAt(index);

                if (currRecipe != null)
                {
                    txtNameOfRecipe.Text = currRecipe.Name;
                    txtRecipe.Text = currRecipe.Description;
                    cboxCat.Text = currRecipe.Category;
                }
            }
        }
    }
}
