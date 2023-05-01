namespace Assignment5
{
    partial class ContactForm
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
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpEmailAndPhone = new System.Windows.Forms.GroupBox();
            this.lblEmailPrivate = new System.Windows.Forms.Label();
            this.lblEmailBusiness = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.txtEmailPrivate = new System.Windows.Forms.TextBox();
            this.txtEmailBusiness = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.grpAdress = new System.Windows.Forms.GroupBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHomePhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCellPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmailBusiness = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmailPrivate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStreet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorZipcode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCountry = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpName.SuspendLayout();
            this.grpEmailAndPhone.SuspendLayout();
            this.grpAdress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHomePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCellPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmailBusiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmailPrivate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorZipcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.txtLastName);
            this.grpName.Controls.Add(this.txtFirstName);
            this.grpName.Controls.Add(this.lblLastName);
            this.grpName.Controls.Add(this.lblFirstName);
            this.grpName.Location = new System.Drawing.Point(13, 23);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(392, 97);
            this.grpName.TabIndex = 0;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(98, 55);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(276, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(98, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(276, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(36, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(37, 32);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First name";
            // 
            // grpEmailAndPhone
            // 
            this.grpEmailAndPhone.Controls.Add(this.lblEmailPrivate);
            this.grpEmailAndPhone.Controls.Add(this.lblEmailBusiness);
            this.grpEmailAndPhone.Controls.Add(this.lblCellPhone);
            this.grpEmailAndPhone.Controls.Add(this.txtEmailPrivate);
            this.grpEmailAndPhone.Controls.Add(this.txtEmailBusiness);
            this.grpEmailAndPhone.Controls.Add(this.txtCellPhone);
            this.grpEmailAndPhone.Controls.Add(this.lblHomePhone);
            this.grpEmailAndPhone.Controls.Add(this.txtHomePhone);
            this.grpEmailAndPhone.Location = new System.Drawing.Point(13, 126);
            this.grpEmailAndPhone.Name = "grpEmailAndPhone";
            this.grpEmailAndPhone.Size = new System.Drawing.Size(392, 149);
            this.grpEmailAndPhone.TabIndex = 1;
            this.grpEmailAndPhone.TabStop = false;
            this.grpEmailAndPhone.Text = "Email and phone";
            // 
            // lblEmailPrivate
            // 
            this.lblEmailPrivate.AutoSize = true;
            this.lblEmailPrivate.Location = new System.Drawing.Point(22, 109);
            this.lblEmailPrivate.Name = "lblEmailPrivate";
            this.lblEmailPrivate.Size = new System.Drawing.Size(70, 13);
            this.lblEmailPrivate.TabIndex = 10;
            this.lblEmailPrivate.Text = "Email, private";
            // 
            // lblEmailBusiness
            // 
            this.lblEmailBusiness.AutoSize = true;
            this.lblEmailBusiness.Location = new System.Drawing.Point(13, 83);
            this.lblEmailBusiness.Name = "lblEmailBusiness";
            this.lblEmailBusiness.Size = new System.Drawing.Size(79, 13);
            this.lblEmailBusiness.TabIndex = 9;
            this.lblEmailBusiness.Text = "Email, business";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(35, 57);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(57, 13);
            this.lblCellPhone.TabIndex = 8;
            this.lblCellPhone.Text = "Cell phone";
            // 
            // txtEmailPrivate
            // 
            this.txtEmailPrivate.Location = new System.Drawing.Point(98, 106);
            this.txtEmailPrivate.Name = "txtEmailPrivate";
            this.txtEmailPrivate.Size = new System.Drawing.Size(276, 20);
            this.txtEmailPrivate.TabIndex = 7;
            // 
            // txtEmailBusiness
            // 
            this.txtEmailBusiness.Location = new System.Drawing.Point(98, 80);
            this.txtEmailBusiness.Name = "txtEmailBusiness";
            this.txtEmailBusiness.Size = new System.Drawing.Size(276, 20);
            this.txtEmailBusiness.TabIndex = 6;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(98, 54);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(276, 20);
            this.txtCellPhone.TabIndex = 5;
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(24, 31);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(68, 13);
            this.lblHomePhone.TabIndex = 4;
            this.lblHomePhone.Text = "Home phone";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(98, 28);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(276, 20);
            this.txtHomePhone.TabIndex = 4;
            // 
            // grpAdress
            // 
            this.grpAdress.Controls.Add(this.lblCountry);
            this.grpAdress.Controls.Add(this.lblZipcode);
            this.grpAdress.Controls.Add(this.lblCity);
            this.grpAdress.Controls.Add(this.lblStreet);
            this.grpAdress.Controls.Add(this.cmbCountry);
            this.grpAdress.Controls.Add(this.txtZipcode);
            this.grpAdress.Controls.Add(this.txtCity);
            this.grpAdress.Controls.Add(this.txtStreet);
            this.grpAdress.Location = new System.Drawing.Point(13, 281);
            this.grpAdress.Name = "grpAdress";
            this.grpAdress.Size = new System.Drawing.Size(392, 151);
            this.grpAdress.TabIndex = 2;
            this.grpAdress.TabStop = false;
            this.grpAdress.Text = "Adress";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(49, 110);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 14;
            this.lblCountry.Text = "Country";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(43, 83);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(49, 13);
            this.lblZipcode.TabIndex = 13;
            this.lblZipcode.Text = "Zip code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(68, 57);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(57, 31);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 11;
            this.lblStreet.Text = "Street";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(98, 107);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(276, 21);
            this.cmbCountry.TabIndex = 11;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(98, 80);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(276, 20);
            this.txtZipcode.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(98, 54);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(276, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(98, 28);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(276, 20);
            this.txtStreet.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(85, 445);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorFirstName
            // 
            this.errorFirstName.ContainerControl = this;
            // 
            // errorLastName
            // 
            this.errorLastName.ContainerControl = this;
            // 
            // errorHomePhone
            // 
            this.errorHomePhone.ContainerControl = this;
            // 
            // errorCellPhone
            // 
            this.errorCellPhone.ContainerControl = this;
            // 
            // errorEmailBusiness
            // 
            this.errorEmailBusiness.ContainerControl = this;
            // 
            // errorEmailPrivate
            // 
            this.errorEmailPrivate.ContainerControl = this;
            // 
            // errorStreet
            // 
            this.errorStreet.ContainerControl = this;
            // 
            // errorCity
            // 
            this.errorCity.ContainerControl = this;
            // 
            // errorZipcode
            // 
            this.errorZipcode.ContainerControl = this;
            // 
            // errorCountry
            // 
            this.errorCountry.ContainerControl = this;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 478);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpAdress);
            this.Controls.Add(this.grpEmailAndPhone);
            this.Controls.Add(this.grpName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "null";
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpEmailAndPhone.ResumeLayout(false);
            this.grpEmailAndPhone.PerformLayout();
            this.grpAdress.ResumeLayout(false);
            this.grpAdress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHomePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCellPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmailBusiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmailPrivate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorZipcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpEmailAndPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.GroupBox grpAdress;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEmailPrivate;
        private System.Windows.Forms.TextBox txtEmailBusiness;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblEmailPrivate;
        private System.Windows.Forms.Label lblEmailBusiness;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ErrorProvider errorFirstName;
        private System.Windows.Forms.ErrorProvider errorLastName;
        private System.Windows.Forms.ErrorProvider errorHomePhone;
        private System.Windows.Forms.ErrorProvider errorCellPhone;
        private System.Windows.Forms.ErrorProvider errorEmailBusiness;
        private System.Windows.Forms.ErrorProvider errorEmailPrivate;
        private System.Windows.Forms.ErrorProvider errorStreet;
        private System.Windows.Forms.ErrorProvider errorCity;
        private System.Windows.Forms.ErrorProvider errorZipcode;
        private System.Windows.Forms.ErrorProvider errorCountry;
    }
}