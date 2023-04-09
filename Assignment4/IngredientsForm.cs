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

namespace Assignment4
{
    public partial class IngredientsForm : Form
    {
        private Recipe recipe;

        public Recipe Recipe { get { return recipe; } set { recipe = value; } }

        public IngredientsForm(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.ControlBox = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] currIngredients = { "apple", "egg" };
            this.recipe.Ingredients = currIngredients;

            this.Close();
        }
    }
}
