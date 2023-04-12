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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Assignment4
{
    /// <summary>
    /// This form is used to display a gui for the user to add ingredients to later be saved in an array.
    /// </summary>
    public partial class IngredientsForm : Form
    {
        private Recipe recipe; // Recipe object to be used as recipe

        // The constructor of the class
        public IngredientsForm(Recipe recipe)
        {
            InitializeComponent();

            this.recipe = recipe;

            InitializeGUI();
        }

        // This method initializes the gui elements and sets different properties for the form at start
        private void InitializeGUI()
        {
            txtNameOfIngredient.MaxLength = 24;
            btnOK.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            ControlBox = false;
        }

        // This method saves the ingredients when the "Ok" button is pressed
        private void SaveIngredients()
        {
            int amtIngredients = listIngredient.Items.Count;

            // Clear array for the delete button to update ingredients
            Array.Clear(recipe.Ingredients, 0, recipe.Ingredients.Length);

            for (int index = 0; index < amtIngredients; index++)
            {
                recipe.Ingredients[index] = listIngredient.Items[index].ToString();
            }
        }

        // This method loads the ingredients to the "IngredientsForm" when the "Add Ingredients" button is pressed
        public void LoadIngredients()
        {
            int amtIngredients = recipe.GetCurrentNumOfIngredients();

            for (int index = 0; index < amtIngredients; index++)
            {
                listIngredient.Items.Add(recipe.Ingredients[index]);
            }

            lblIngredientCount.Text = listIngredient.Items.Count.ToString();
        }

        // This method is for when the user clicks the "Ok" button
        // It saves the ingredients and closes the form
        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveIngredients();
            Close();
        }

        // This method is for when the user clicks the "Cancel" button
        // It closes the form without saving anything
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // This method is for when the user clicks the "Add" button
        // It reads the input and adds the ingredient to the list
        // if the input is not empty and the list is not full, and throws
        // various errors if it is
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int.TryParse(lblIngredientCount.Text, out int count);

            if (txtNameOfIngredient.TextLength > 0 && listIngredient.Items.Count < recipe.MaxNumOfIngredients)
            {
                listIngredient.Items.Add(txtNameOfIngredient.Text);

                count++;
                lblIngredientCount.Text = count.ToString();

                errorIngredientName.SetError(txtNameOfIngredient, "");
                errorIngredientList.SetError(txtNameOfIngredient, "");
                txtNameOfIngredient.Clear();
            }
            else if (txtNameOfIngredient.TextLength <= 0)
            {
                errorIngredientList.SetError(txtNameOfIngredient, "");
                errorIngredientName.SetError(txtNameOfIngredient, "Please add a name for the ingredient");
            }
            else
            {
                errorIngredientName.SetError(txtNameOfIngredient, "");
                errorIngredientList.SetError(txtNameOfIngredient, "List is full");
            }

            if (count > 0)
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }

        // This method is for when the user clicks the "Edit" button
        // It removes an item at the chosen index and adds it back with
        // the new values if the input is not empty
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = listIngredient.SelectedIndex;

            if (txtNameOfIngredient.TextLength > 0)
            {
                listIngredient.Items.RemoveAt(index);
                listIngredient.Items.Insert(index, txtNameOfIngredient.Text);
                errorIngredientName.SetError(txtNameOfIngredient, "");
                txtNameOfIngredient.Clear();
            }
            else
            {
                errorIngredientName.SetError(txtNameOfIngredient, "Please add a name for the ingredient");
            }

            if (listIngredient.Items.Count > 0)
            {
                btnOK.Enabled = true;
            }
        }

        // This method is for when the user clicks the "Delete" button
        // It removes an item at the chosen index
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listIngredient.SelectedIndex;
            int.TryParse(lblIngredientCount.Text, out int count);

            if (index >= 0)
            {
                listIngredient.Items.RemoveAt(index);

                count--;
                lblIngredientCount.Text = count.ToString();

                listIngredient.SelectedIndex = -1;
                errorIngredientName.SetError(txtNameOfIngredient, "");
                errorIngredientList.SetError(txtNameOfIngredient, "");
                txtNameOfIngredient.Clear();
            }

            if (count > 0)
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }

        // This method gets called every time the user clicks different items in the list
        // It checks if the user has an item selected, if so the "Edit" and "Delete" buttons
        // become clickable, otherwise they become not clickable
        // It also sets the input text box to mirror the ingredient name
        // so that the user can either add the same ingredient again, or edit it
        private void listIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemStr = listIngredient.GetItemText(listIngredient.SelectedItem);

            if (listIngredient.SelectedIndex >= 0)
            {
                txtNameOfIngredient.Text = itemStr;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
