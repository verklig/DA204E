namespace Assignment4
{
    partial class IngredientsForm
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
            this.grpAddRecipe = new System.Windows.Forms.GroupBox();
            this.lblIngredientCount = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblNoOf = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listIngredient = new System.Windows.Forms.ListBox();
            this.txtNameOfIngredient = new System.Windows.Forms.TextBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.errorIngredientName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorIngredientList = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAddRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIngredientName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIngredientList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddRecipe
            // 
            this.grpAddRecipe.Controls.Add(this.lblIngredientCount);
            this.grpAddRecipe.Controls.Add(this.lblIngredients);
            this.grpAddRecipe.Controls.Add(this.lblNoOf);
            this.grpAddRecipe.Controls.Add(this.btnDelete);
            this.grpAddRecipe.Controls.Add(this.btnEdit);
            this.grpAddRecipe.Controls.Add(this.btnAdd);
            this.grpAddRecipe.Controls.Add(this.listIngredient);
            this.grpAddRecipe.Controls.Add(this.txtNameOfIngredient);
            this.grpAddRecipe.Controls.Add(this.lblIngredient);
            this.grpAddRecipe.Location = new System.Drawing.Point(13, 13);
            this.grpAddRecipe.Name = "grpAddRecipe";
            this.grpAddRecipe.Size = new System.Drawing.Size(299, 297);
            this.grpAddRecipe.TabIndex = 1;
            this.grpAddRecipe.TabStop = false;
            this.grpAddRecipe.Text = "Ingredients list";
            // 
            // lblIngredientCount
            // 
            this.lblIngredientCount.AutoSize = true;
            this.lblIngredientCount.Location = new System.Drawing.Point(255, 262);
            this.lblIngredientCount.Name = "lblIngredientCount";
            this.lblIngredientCount.Size = new System.Drawing.Size(13, 13);
            this.lblIngredientCount.TabIndex = 15;
            this.lblIngredientCount.Text = "0";
            this.lblIngredientCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(235, 240);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(58, 13);
            this.lblIngredients.TabIndex = 14;
            this.lblIngredients.Text = "ingredients";
            // 
            // lblNoOf
            // 
            this.lblNoOf.AutoSize = true;
            this.lblNoOf.Location = new System.Drawing.Point(235, 227);
            this.lblNoOf.Name = "lblNoOf";
            this.lblNoOf.Size = new System.Drawing.Size(36, 13);
            this.lblNoOf.TabIndex = 13;
            this.lblNoOf.Text = "No. of";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(243, 48);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(243, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listIngredient
            // 
            this.listIngredient.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.listIngredient.FormattingEnabled = true;
            this.listIngredient.ItemHeight = 16;
            this.listIngredient.Location = new System.Drawing.Point(9, 47);
            this.listIngredient.Name = "listIngredient";
            this.listIngredient.Size = new System.Drawing.Size(218, 228);
            this.listIngredient.TabIndex = 7;
            this.listIngredient.SelectedIndexChanged += new System.EventHandler(this.listIngredient_SelectedIndexChanged);
            // 
            // txtNameOfIngredient
            // 
            this.txtNameOfIngredient.Location = new System.Drawing.Point(66, 21);
            this.txtNameOfIngredient.Name = "txtNameOfIngredient";
            this.txtNameOfIngredient.Size = new System.Drawing.Size(161, 20);
            this.txtNameOfIngredient.TabIndex = 1;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(6, 24);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(54, 13);
            this.lblIngredient.TabIndex = 0;
            this.lblIngredient.Text = "Ingredient";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(86, 318);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // errorIngredientName
            // 
            this.errorIngredientName.ContainerControl = this;
            // 
            // errorIngredientList
            // 
            this.errorIngredientList.ContainerControl = this;
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpAddRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IngredientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add ingredients";
            this.grpAddRecipe.ResumeLayout(false);
            this.grpAddRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIngredientName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIngredientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddRecipe;
        private System.Windows.Forms.TextBox txtNameOfIngredient;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.ListBox listIngredient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblIngredientCount;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblNoOf;
        private System.Windows.Forms.ErrorProvider errorIngredientName;
        private System.Windows.Forms.ErrorProvider errorIngredientList;
    }
}