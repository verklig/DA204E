using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            btnEditBegin.Enabled = false;
            btnEditFinish.Enabled = false;
            btnDelete.Enabled = false;
            MaximizeBox = false;
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            bool ok = ReadRecipeInput();

            if (ok)
            {
                bool arrayFull = !recipeMngr.Add(currRecipe);

                if (!arrayFull)
                {
                    currRecipe = new Recipe(maxNumOfIngredients);

                    UpdateGUI();

                    txtRecipe.Clear();
                    txtNameOfRecipe.Clear();
                    cboxCat.SelectedIndex = -1;
                    errorRecipeList.SetError(btnAddRecipe, "");
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
                listRecipe.Items.Add(recipe.ToString());
            }
        }

        private bool ReadRecipeName()
        {
            string recipeName = txtNameOfRecipe.Text.Trim();

            bool ok = ValidateRecipeName();

            if (ok)
            {
                currRecipe.Name = recipeName;
            }

            return ok;
        }

        private bool ReadRecipeCategory()
        {
            FoodCategory recipeCat = (FoodCategory)Enum.Parse(typeof(FoodCategory), cboxCat.Text);

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
                    listRecipe.SelectedIndex = -1;
                    errorRecipeList.SetError(btnAddRecipe, "");
                    UpdateGUI();
                }
            }
        }

        private void btnEditBegin_Click(object sender, EventArgs e)
        {
            if (listRecipe.SelectedIndex != -1)
            {
                int index = listRecipe.SelectedIndex;

                btnAddRecipe.Enabled = false;
                btnEditBegin.Enabled = false;
                btnDelete.Enabled = false;
                btnEditFinish.Enabled = true;

                if (index >= 0)
                {
                    currRecipe = recipeMngr.GetRecipeAt(index);

                    if (currRecipe != null)
                    {
                        txtNameOfRecipe.Text = currRecipe.Name;
                        txtRecipe.Text = currRecipe.Description;
                        cboxCat.Text = currRecipe.Category.ToString();
                    }
                }
            }
        }

        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            bool ok = ReadRecipeInput();

            if (ok)
            {
                currRecipe = new Recipe(maxNumOfIngredients);

                UpdateGUI();

                txtRecipe.Clear();
                txtNameOfRecipe.Clear();
                cboxCat.SelectedIndex = -1;
                btnAddRecipe.Enabled = true;
                btnEditFinish.Enabled = false;
            }
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            listRecipe.ClearSelected();
            txtRecipe.Clear();
            txtNameOfRecipe.Clear();
            cboxCat.SelectedIndex = -1;
            btnAddRecipe.Enabled = true;
            btnEditFinish.Enabled = false;

            currRecipe = new Recipe(maxNumOfIngredients);
        }

        private void listRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listRecipe.SelectedIndex >= 0)
            {
                btnEditBegin.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEditBegin.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void listRecipe_DoubleClick(object sender, EventArgs e)
        {
            int recipeIndex = listRecipe.SelectedIndex;
            Recipe clickedRecipe = recipeMngr.GetRecipeAt(recipeIndex);

            // Recipe recipe = recipeMngr.recipeList;
            MessageBox.Show(clickedRecipe.ToStringDetailed(), "Cooking Instructions");
        }
    }
}
