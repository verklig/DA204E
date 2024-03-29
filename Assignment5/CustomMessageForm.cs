﻿using System;
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
        private Label lblQuestion;

        /// <summary>
        /// The default constructor of the class needed to provide the visuals.
        /// </summary>
        public CustomMessageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Code provided by VS.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(22, 27);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(165, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Are you sure you want to cancel?";
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(25, 60);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(63, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.TabStop = false;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Location = new System.Drawing.Point(120, 60);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(63, 23);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // CustomMessageForm
            // 
            this.ClientSize = new System.Drawing.Size(209, 95);
            this.ControlBox = false;
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }

    /// <summary>
    /// Custom message box helper.
    /// </summary>
    public static class CustomMessageBox
    {
        public static void Show()
        {
            using (var form = new CustomMessageForm())
            {
                form.ShowDialog();
            }
        }
    }
}
