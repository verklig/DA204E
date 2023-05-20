using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    /// <summary>
    /// This form is my custom messagebox to keep the language the same.
    /// </summary>
    internal partial class CustomMessageForm : Form
    {
        private Button btnYes;
        private Button btnNo;
        private Label lblDescription;

        /// <summary>
        /// The default constructor of the class needed to provide the visuals.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        public CustomMessageForm(string title, string description)
        {
            InitializeComponent();
            Text = title;
            lblDescription.Text = description;
        }

        /// <summary>
        /// The second constructor with more parameters to set the needed visuals.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="btnYes"></param>
        /// <param name="btnNo"></param>
        public CustomMessageForm(string title, string description, bool btnYes, string btnNo)
        {
            InitializeComponent();
            Text = title;
            lblDescription.Text = description;
            this.btnYes.Visible = btnYes;
            this.btnNo.Text = btnNo;
        }

        /// <summary>
        /// Code provided by VS.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageForm));
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(3, 3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(228, 70);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(12, 76);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(76, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.TabStop = false;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Location = new System.Drawing.Point(145, 76);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(77, 23);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // CustomMessageForm
            // 
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomMessageForm";
            this.ResumeLayout(false);

        }
    }

    /// <summary>
    /// Custom message box helper.
    /// </summary>
    public static class CustomMessageBox
    {
        public static void Show()
        {
            using (var form = new CustomMessageForm("", ""))
            {
                form.ShowDialog();
            }
        }
    }
}
