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

        private Recipe currRecipe = new Recipe(maxNumOfIngredients); // Creating new object of the Recipe class and sends maxNumOfIngredients as an argument
        private RecipeManager recipeMngr = new RecipeManager(maxNumOfRecipes); // Creating new object of the RecipeManager class and sends maxNumOfRecipes as an argument

        // The constructor of the class
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        // This method initializes the gui elements and sets different properties for the form at program start
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

        // This method reads the user input and validates them
        // and also sends a boolean that is either true or false depening on the validation
        private bool ReadRecipeInput()
        {
            bool ingrOK;

            // This if statemaent checks so that the number of ingredients
            // is above 0 before accepting the input
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

        // This method updates the items in the list box
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

        // This method reads the name and validates it
        // and also sends a boolean that is either true or false depening on the validation
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

        // This method reads the category and validates it
        // and also sends a boolean that is either true or false depening on the validation
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

        // This method reads the description and validates it
        // and also sends a boolean that is either true or false depening on the validation
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
        
        #region Validators
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
        #endregion

        // This method is for when the user clicks the "Add Recipe" button and
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

        // This method is for when the user clicks the "Add Ingredients" button
        // It opens a new instance of the "IngredientsForm" for the user
        // to add new ingredients to be saved
        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            IngredientsForm dlg = new IngredientsForm(currRecipe);
            dlg.LoadIngredients();
            DialogResult dlgResult = dlg.ShowDialog();
        }

        // This method is for when the user clicks the "Delete" button
        // It deletes the currently selected recipe and clears the selected item
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

        // This method is for when the user clicks the "Edit-Begin" button
        // It gives back all the information stored in the recipe to the various input methods
        // so that the user can edit the recipe after one has been made
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
                btnClearSelection.Enabled = false;

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

        // This method is for when the user clicks the "Edit-Finish" button
        // It essentially does the same thing as the "Add Recipe" button
        // does, but instead of adding a new recipe, it edits the selected item instead.
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
                btnClearSelection.Enabled = true;
            }
        }

        // This method is for when the user clicks the "Clear Selection" button
        // It clears any inputs made from the user, any errors that was visable before
        // and also clears the selection of an item if the user had one selected
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
            errorIngredients.SetError(btnAddIngredients, "");

            currRecipe = new Recipe(maxNumOfIngredients);
        }

        // This method gets called every time the user clicks different items in the list
        // It checks if the user has an item selected, if so the "Edit-Begin" and "Delete" buttons
        // become clickable, otherwise they become not clickable
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

        // This method gets called every time the user double-clicks and item in the list
        // If the user has an item selected, it shows a message box containing the ingredients
        // and cooking instructions for the recipe
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
