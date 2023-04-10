using System.Windows.Forms;
using System;

namespace Assignment4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listRecipe = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCat2 = new System.Windows.Forms.Label();
            this.lblNoOf = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblNameOfRecipe = new System.Windows.Forms.Label();
            this.txtNameOfRecipe = new System.Windows.Forms.TextBox();
            this.grpAddRecipe = new System.Windows.Forms.GroupBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.cboxCat = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.btnEditBegin = new System.Windows.Forms.Button();
            this.btnEditFinish = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorRecipeName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRecipeCat = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRecipeText = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRecipeList = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAddRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecipeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecipeCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecipeText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecipeList)).BeginInit();
            this.SuspendLayout();
            // 
            // listRecipe
            // 
            this.listRecipe.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRecipe.FormattingEnabled = true;
            this.listRecipe.ItemHeight = 16;
            this.listRecipe.Location = new System.Drawing.Point(327, 45);
            this.listRecipe.Name = "listRecipe";
            this.listRecipe.Size = new System.Drawing.Size(444, 244);
            this.listRecipe.TabIndex = 1;
            this.listRecipe.SelectedIndexChanged += new System.EventHandler(this.listRecipe_SelectedIndexChanged);
            this.listRecipe.DoubleClick += new System.EventHandler(this.listRecipe_DoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(328, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblCat2
            // 
            this.lblCat2.AutoSize = true;
            this.lblCat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat2.Location = new System.Drawing.Point(528, 13);
            this.lblCat2.Name = "lblCat2";
            this.lblCat2.Size = new System.Drawing.Size(62, 16);
            this.lblCat2.TabIndex = 3;
            this.lblCat2.Text = "Category";
            // 
            // lblNoOf
            // 
            this.lblNoOf.AutoSize = true;
            this.lblNoOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOf.Location = new System.Drawing.Point(696, 13);
            this.lblNoOf.Name = "lblNoOf";
            this.lblNoOf.Size = new System.Drawing.Size(42, 16);
            this.lblNoOf.TabIndex = 4;
            this.lblNoOf.Text = "No. of";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(696, 26);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(73, 16);
            this.lblIngredients.TabIndex = 5;
            this.lblIngredients.Text = "ingredients";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.Teal;
            this.lblHelp.Location = new System.Drawing.Point(357, 328);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(381, 16);
            this.lblHelp.TabIndex = 6;
            this.lblHelp.Text = "Double click on an item for ingredients and cooking instructions!";
            // 
            // lblNameOfRecipe
            // 
            this.lblNameOfRecipe.AutoSize = true;
            this.lblNameOfRecipe.Location = new System.Drawing.Point(6, 24);
            this.lblNameOfRecipe.Name = "lblNameOfRecipe";
            this.lblNameOfRecipe.Size = new System.Drawing.Size(79, 13);
            this.lblNameOfRecipe.TabIndex = 0;
            this.lblNameOfRecipe.Text = "Name of recipe";
            // 
            // txtNameOfRecipe
            // 
            this.txtNameOfRecipe.Location = new System.Drawing.Point(91, 21);
            this.txtNameOfRecipe.Name = "txtNameOfRecipe";
            this.txtNameOfRecipe.Size = new System.Drawing.Size(190, 20);
            this.txtNameOfRecipe.TabIndex = 1;
            // 
            // grpAddRecipe
            // 
            this.grpAddRecipe.Controls.Add(this.btnAddRecipe);
            this.grpAddRecipe.Controls.Add(this.txtRecipe);
            this.grpAddRecipe.Controls.Add(this.btnAddIngredients);
            this.grpAddRecipe.Controls.Add(this.cboxCat);
            this.grpAddRecipe.Controls.Add(this.lblCat);
            this.grpAddRecipe.Controls.Add(this.txtNameOfRecipe);
            this.grpAddRecipe.Controls.Add(this.lblNameOfRecipe);
            this.grpAddRecipe.Location = new System.Drawing.Point(13, 13);
            this.grpAddRecipe.Name = "grpAddRecipe";
            this.grpAddRecipe.Size = new System.Drawing.Size(299, 323);
            this.grpAddRecipe.TabIndex = 0;
            this.grpAddRecipe.TabStop = false;
            this.grpAddRecipe.Text = "Add new recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(9, 291);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(272, 23);
            this.btnAddRecipe.TabIndex = 6;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtRecipe
            // 
            this.txtRecipe.Location = new System.Drawing.Point(9, 84);
            this.txtRecipe.Multiline = true;
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(272, 201);
            this.txtRecipe.TabIndex = 5;
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(189, 55);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(92, 23);
            this.btnAddIngredients.TabIndex = 4;
            this.btnAddIngredients.Text = "Add Ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // cboxCat
            // 
            this.cboxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCat.FormattingEnabled = true;
            this.cboxCat.Location = new System.Drawing.Point(61, 56);
            this.cboxCat.Name = "cboxCat";
            this.cboxCat.Size = new System.Drawing.Size(112, 21);
            this.cboxCat.TabIndex = 3;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(6, 59);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(49, 13);
            this.lblCat.TabIndex = 2;
            this.lblCat.Text = "Category";
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Location = new System.Drawing.Point(683, 302);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(87, 23);
            this.btnClearSelection.TabIndex = 7;
            this.btnClearSelection.Text = "Clear Selection";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // btnEditBegin
            // 
            this.btnEditBegin.Location = new System.Drawing.Point(327, 302);
            this.btnEditBegin.Name = "btnEditBegin";
            this.btnEditBegin.Size = new System.Drawing.Size(87, 23);
            this.btnEditBegin.TabIndex = 8;
            this.btnEditBegin.Text = "Edit-Begin";
            this.btnEditBegin.UseVisualStyleBackColor = true;
            this.btnEditBegin.Click += new System.EventHandler(this.btnEditBegin_Click);
            // 
            // btnEditFinish
            // 
            this.btnEditFinish.Location = new System.Drawing.Point(416, 302);
            this.btnEditFinish.Name = "btnEditFinish";
            this.btnEditFinish.Size = new System.Drawing.Size(87, 23);
            this.btnEditFinish.TabIndex = 9;
            this.btnEditFinish.Text = "Edit-Finish";
            this.btnEditFinish.UseVisualStyleBackColor = true;
            this.btnEditFinish.Click += new System.EventHandler(this.btnEditFinish_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(505, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Tag = "";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorRecipeName
            // 
            this.errorRecipeName.ContainerControl = this;
            // 
            // errorRecipeCat
            // 
            this.errorRecipeCat.ContainerControl = this;
            // 
            // errorRecipeText
            // 
            this.errorRecipeText.ContainerControl = this;
            // 
            // errorRecipeList
            // 
            this.errorRecipeList.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 353);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditFinish);
            this.Controls.Add(this.btnEditBegin);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblNoOf);
            this.Controls.Add(this.lblCat2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.listRecipe);
            this.Controls.Add(this.grpAddRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apu Recipe Book By Eric Blohm";
            this.grpAddRecipe.ResumeLayout(false);
            this.grpAddRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecipeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecipeCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecipeText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecipeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listRecipe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCat2;
        private System.Windows.Forms.Label lblNoOf;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblNameOfRecipe;
        private System.Windows.Forms.TextBox txtNameOfRecipe;
        private System.Windows.Forms.GroupBox grpAddRecipe;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.ComboBox cboxCat;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnEditBegin;
        private System.Windows.Forms.Button btnEditFinish;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorRecipeName;
        private System.Windows.Forms.ErrorProvider errorRecipeCat;
        private System.Windows.Forms.ErrorProvider errorRecipeText;
        private System.Windows.Forms.ErrorProvider errorRecipeList;
    }
}

