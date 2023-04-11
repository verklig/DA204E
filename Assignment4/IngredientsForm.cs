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
    public partial class IngredientsForm : Form
    {
        private Recipe recipe;

        public Recipe Recipe { get { return recipe; } set { recipe = value; } }

        public IngredientsForm(Recipe recipe)
        {
            InitializeComponent();

            this.recipe = recipe;

            InitializeGUI();
        }

        private void InitializeGUI()
        {
            txtNameOfIngredient.MaxLength = 24;
            btnOK.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            ControlBox = false;
        }

        private void SaveIngredients()
        {
            int amtIngredients = listIngredient.Items.Count;
            Array.Clear(recipe.Ingredients, 0, recipe.Ingredients.Length); // Clear array for the delete to update ingredients

            for (int index = 0; index < amtIngredients; index++)
            {
                recipe.Ingredients[index] = listIngredient.Items[index].ToString();
            }
        }

        public void LoadIngredients()
        {
            int amtIngredients = recipe.GetCurrentNumOfIngredients();

            for (int index = 0; index < amtIngredients; index++)
            {
                listIngredient.Items.Add(recipe.Ingredients[index]);
            }

            lblIngredientCount.Text = listIngredient.Items.Count.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveIngredients();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listIngredient.SelectedIndex;
            int.TryParse(lblIngredientCount.Text, out int count);

            if (index >= 0)
            {
                listIngredient.Items.RemoveAt(index);

                listIngredient.SelectedIndex = -1;
                count--;
                lblIngredientCount.Text = count.ToString();
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
