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

    /// <summary>
    /// This program is a recipe book that the user can interact with. It allows users to add, edit, and delete recipes.
    /// The program has a GUI that includes text boxes and buttons for users to enter recipe information, and a list box to display
    /// the list of recipes. It also allows users to add ingredients to a recipe.
    /// </summary>
    public partial class MainForm : Form
    {
        private const int maxNumOfIngredients = 50; // Maximum number of ingredients as a constant
        private const int maxNumOfRecipes = 200; // Maximum number of recipes as a constant

        private Recipe currRecipe = new Recipe(maxNumOfIngredients); // Creating new object of the Recipe class and sends maxNumOfIngredients with it
        private RecipeManager recipeMngr = new RecipeManager(maxNumOfRecipes); // Creating new object of the RecipeManager class and sends maxNumOfRecipes with it

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        // This method initializes the GUI elements and sets various properties for the form at program start
        private void InitializeGUI()
        {
            FoodCategory addCategory = new FoodCategory();
            Array itemNames = Enum.GetNames(typeof(FoodCategory));

            for (int i = 0; i < itemNames.Length; i++)
            {
                cboxCat.Items.Add(addCategory);
                addCategory++;
            }

            txtNameOfRecipe.MaxLength = 24;
            btnEditBegin.Enabled = false;
            btnEditFinish.Enabled = false;
            btnDelete.Enabled = false;
            MaximizeBox = false;
        }

        // This method is for when the user clicks the add recipe button and
        // it handles reading and validating the input, if the input is ok
        // it also adds it as a recipe and updates the ui, it prints an error
        // if the input was not valid
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            bool ok = ReadRecipeInput();

            if (ok)
            {
                bool arrayFull = !recipeMngr.Add(currRecipe);

                if (!arrayFull)
                {
                    currRecipe = new Recipe(maxNumOfIngredients);

                    UpdateListBox();

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

        // This method reads the user input and validates them
        // sending a boolean that is either true or false depending on the validation
        private bool ReadRecipeInput()
        {
            bool ingrOK;

            if (currRecipe.GetCurrentNumOfIngredients() == 0)
            {
                errorIngredients.SetError(btnAddIngredients, "Please add ingredients");
                ingrOK = false;
            }
            else
            {
                errorIngredients.SetError(btnAddIngredients, "");
                ingrOK = true;
            }

            bool nameOK = ReadRecipeName();
            bool catOK = ReadRecipeCategory();
            bool textOK = ReadRecipeDescription();

            return ingrOK && nameOK && catOK && textOK;
        }

        private void UpdateListBox()
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
            FoodCategory recipeCat;

            Enum.TryParse(cboxCat.Text, out recipeCat);

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
            dlg.LoadIngredients();
            DialogResult dlgResult = dlg.ShowDialog();
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
                    UpdateListBox();
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
                listRecipe.Enabled = false;

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

                UpdateListBox();

                txtRecipe.Clear();
                txtNameOfRecipe.Clear();
                cboxCat.SelectedIndex = -1;

                btnAddRecipe.Enabled = true;
                btnEditFinish.Enabled = false;
                listRecipe.Enabled = true;
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
            listRecipe.Enabled = true;

            errorRecipeName.SetError(txtNameOfRecipe, "");
            errorRecipeCat.SetError(cboxCat, "");
            errorRecipeText.SetError(txtRecipe, "");

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

            if (recipeIndex >= 0)
            {
                Recipe clickedRecipe = recipeMngr.GetRecipeAt(recipeIndex);
                MessageBox.Show(clickedRecipe.ToStringDetailed(), "Cooking Instructions");
            }
        }
    }
}
