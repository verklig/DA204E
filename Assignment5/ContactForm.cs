using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class ContactForm : Form
    {
        private Contact contact;
        private bool closeForm = false;

        public Contact ContactData { get; set; }

        public ContactForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public ContactForm(string title)
        {

        }

        private void InitializeGUI()
        {
            ControlBox = false;
            Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void UpdateGUI()
        {

        }

        private void ReadEmails()
        {

        }

        private void ReadPhones()
        {

        }

        private void ReadAddresses()
        {

        }

        private void ReadNames()
        {

        }
    }
}
