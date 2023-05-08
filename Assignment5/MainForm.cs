using Assignment5.Properties;
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

namespace Assignment5
{
    /// <summary>
    /// This program is a customer registry that the user can use to store different customers. It allows users to add, edit, and delete customers.
    /// The program has a GUI that includes a listbox to show a list of customers and a contact details box that provides the info about the customer
    /// with more details.
    /// </summary>
    public partial class MainForm : Form
    {
        private CustomerManager customerMngr = new CustomerManager(); // Creating new object of the CustomerManager class

        /// <summary>
        /// The constructor of the class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// This method initializes the gui elements and sets different properties for the form at program start.
        /// </summary>
        private void InitializeGUI()
        {
            MaximizeBox = false;
            EnableButtons(false);
        }

        /// <summary>
        /// This method is for when the user clicks the "Add" button and
        /// it handles reading and validating the input, if the input is ok
        /// it also adds it in the list and updates the ui, it prints an error
        /// if the input was not valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            lstCustomer.SelectedIndex = -1;
            ContactForm dlg = new ContactForm("Add New Customer");
            
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                customerMngr.AddCustomer(new Customer(dlg.ContactData));
                UpdateCustomerList();
            }
        }

        /// <summary>
        /// This method is for when the user clicks the "Edit" button.
        /// It gives back all the information stored in the customer list to the various input methods
        /// so that the user can edit the customer after one has been made.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = customerMngr.GetCustomer(lstCustomer.SelectedIndex);

            EnableButtons(false);
            ContactForm dlg = new ContactForm("Edit Customer", selectedCustomer.Contact);
            DialogResult dlgResult = dlg.ShowDialog();


            if (dlgResult == DialogResult.OK)
            {
                Customer editedCustomer = new Customer(dlg.ContactData);
                customerMngr.ChangeCustomer(editedCustomer, lstCustomer.SelectedIndex);
                UpdateCustomerList();
            }
            else
            {
                lstCustomer.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// This method is for when the user clicks the "Delete" button.
        /// It deletes the currently selected customer and clears the selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstCustomer.SelectedIndex;

            if (index >= 0)
            {
                customerMngr.DeleteCustomer(index);

                lstCustomer.SelectedIndex = -1;
                UpdateCustomerList();
            }
        }

        /// <summary>
        /// This method gets called every time the user clicks different items in the list.
        /// It checks if the user has an item selected, if so the "Edit" and "Delete" buttons
        /// become clickable, otherwise they become not clickable.
        /// It also handles printing the customer info to the contact details text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedIndex >= 0)
            {
                EnableButtons(true);
            }
            else
            {
                EnableButtons(false);
            }

            if (lstCustomer.SelectedIndex >= 0)
            {
                Customer selectedCustomer = customerMngr.GetCustomer(lstCustomer.SelectedIndex);
                Email selectedEmail = selectedCustomer.Contact.EmailData;
                Phone selectedPhone = selectedCustomer.Contact.PhoneData;
                string selectedAddress = selectedCustomer.Contact.GetAddressInfo();

                txtContactDetails.Text = $"{selectedAddress}{selectedEmail}{selectedPhone}";
            }
            else
            {
                txtContactDetails.Clear();
            }
        }

        /// <summary>
        /// This method enables or disables the buttons according to the setting parameter.
        /// </summary>
        /// <param name="setting"></param>
        private void EnableButtons(bool setting)
        {
            btnEdit.Enabled = setting;
            btnDelete.Enabled = setting;
        }

        /// <summary>
        /// This method updates the items in the list box.
        /// </summary>
        private void UpdateCustomerList()
        {
            lstCustomer.Items.Clear();

            int amtCustomers = customerMngr.CustomerCount;

            for (int index = 0; index < amtCustomers; index++)
            {
                lstCustomer.Items.Add(customerMngr.GetCustomer(index));
            }
        }
    }
}
