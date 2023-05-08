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
    /// <summary>
    /// This form is used to display a GUI for the user to add contact information that gets added in the list.
    /// </summary>
    public partial class ContactForm : Form
    {
        private Contact contact; // Setting the Contact class to be used as contact

        // Getter and setter
        internal Contact ContactData { get { return contact; } set { contact = value; } }

        /// <summary>
        /// The default constructor of the class with the title of the form as the parameter.
        /// </summary>
        /// <param name="title"></param>
        public ContactForm(string title)
        {
            InitializeComponent();
            InitializeGUI();

            Text = title;
        }

        /// <summary>
        /// Constructor with the title and contact as parameters.
        /// The contact is passed so that it can be printed back to the ui for editing.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="contact"></param>
        internal ContactForm(string title, Contact contact)
        {
            InitializeComponent();
            InitializeGUI();

            Text = title;

            txtFirstName.Text = contact.FirstName;
            txtLastName.Text = contact.LastName;

            txtHomePhone.Text = contact.PhoneData.HomePhone;
            txtCellPhone.Text = contact.PhoneData.CellPhone;
            txtEmailBusiness.Text = contact.EmailData.Work;
            txtEmailPrivate.Text = contact.EmailData.Personal;

            txtStreet.Text = contact.AddressData.Street;
            txtCity.Text = contact.AddressData.City;
            txtZipcode.Text = contact.AddressData.Zipcode;
            cmbCountry.Text = contact.AddressData.Country.ToString().Replace("_", " ");
        }

        /// <summary>
        /// This method initializes the gui elements and sets different properties for the form at program start.
        /// </summary>
        private void InitializeGUI()
        {
            foreach (Countries country in Enum.GetValues(typeof(Countries)))
            {
                cmbCountry.Items.Add(country.ToString().Replace("_", " "));
            }

            ControlBox = false;

            txtFirstName.MaxLength = 12;
            txtLastName.MaxLength = 12;

            txtHomePhone.MaxLength = 24;
            txtCellPhone.MaxLength = 24;
            txtEmailBusiness.MaxLength = 24;
            txtEmailPrivate.MaxLength = 24;

            txtStreet.MaxLength = 24;
            txtCity.MaxLength = 24;
            txtZipcode.MaxLength = 24;
        }

        /// <summary>
        /// This method is for when the user clicks the "OK" button.
        /// It reads the input and sends an ok if the input is ok,
        /// otherwise nothing is done.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            contact = new Contact();

            bool namesOK = ReadNames();
            bool emailsOK = ReadEmails();
            bool phonesOK = ReadPhones();
            bool addressesOK = ReadAddresses();

            if (namesOK && emailsOK && phonesOK && addressesOK)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// This method is for when the user clicks the "Cancel" button.
        /// It shows another form asking the user if they are sure they wan to cancel,
        /// if yes both forms close, otherwise only the form asking closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomMessageForm dlg = new CustomMessageForm();
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        /// <summary>
        /// This method reads the names and validates them
        /// and also sends a boolean that is either true or false depening on the validation.
        /// </summary>
        /// <returns>true or false</returns>
        private bool ReadNames()
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            bool ok = ValidateNames();

            if (ok)
            {
                contact.FirstName = firstName;
                contact.LastName = lastName;
            }

            return ok;
        }

        /// <summary>
        /// This method reads the emails and validates them
        /// and also sends a boolean that is either true or false depening on the validation.
        /// </summary>
        /// <returns>true or false</returns>
        private bool ReadEmails()
        {
            string emailBusiness = txtEmailBusiness.Text.Trim();
            string emailPrivate = txtEmailPrivate.Text.Trim();

            bool ok = true; // = ValidateEmails();

            if (ok)
            {
                contact.EmailData = new Email();
                contact.EmailData.Work = emailBusiness;
                contact.EmailData.Personal = emailPrivate;
            }

            return ok;
        }

        /// <summary>
        /// This method reads the phone numbers and validates them
        /// and also sends a boolean that is either true or false depening on the validation.
        /// </summary>
        /// <returns>true or false</returns>
        private bool ReadPhones()
        {
            string cellPhone = txtCellPhone.Text.Trim();
            string homePhone = txtHomePhone.Text.Trim();

            bool ok = true; // ValidatePhones();

            if (ok)
            {
                contact.PhoneData = new Phone();
                contact.PhoneData.CellPhone = cellPhone;
                contact.PhoneData.HomePhone = homePhone;
            }

            return ok;
        }

        /// <summary>
        /// This method reads the addresses and validates them
        /// and also sends a boolean that is either true or false depening on the validation.
        /// </summary>
        /// <returns>true or false</returns>
        private bool ReadAddresses()
        {
            string street = txtStreet.Text.Trim();
            string city = txtCity.Text.Trim();
            string zipcode = txtZipcode.Text.Trim();

            Countries country;
            Enum.TryParse(cmbCountry.Text.Replace(" ", "_"), out country);

            bool ok = ValidateAddresses();

            if (ok)
            {
                contact.AddressData = new Address(city, country);
                contact.AddressData.Street = street;
                contact.AddressData.Zipcode = zipcode;
            }

            return ok;
        }

        #region Validators
        private bool ValidateNames()
        {
            bool NameOK = true;

            if (String.IsNullOrWhiteSpace(txtFirstName.Text) && String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorName.SetError(txtNameError, "Please add a first name or last name");
                NameOK = false;
            }
            else
            {
                errorName.SetError(txtNameError, "");
            }

            return NameOK;
        }

        private bool ValidateEmails()
        {
            bool emailBusinessOK = true;
            bool emailPrivateOK = true;

            if (txtEmailBusiness.Text != null)
            {
                errorEmailBusiness.SetError(txtEmailBusiness, "Please add a business email");
                emailBusinessOK = false;
            }
            else
            {
                errorEmailBusiness.SetError(txtEmailBusiness, "");
            }

            if (txtEmailPrivate.Text == "")
            {
                errorEmailPrivate.SetError(txtEmailPrivate, "Please add a private email");
                emailPrivateOK = false;
            }
            else
            {
                errorEmailPrivate.SetError(txtEmailPrivate, "");
            }

            return emailBusinessOK && emailPrivateOK;
        }

        private bool ValidatePhones()
        {
            bool cellPhoneOK = true;
            bool homePhoneOK = true;

            if (txtCellPhone.Text == "")
            {
                errorCellPhone.SetError(txtCellPhone, "Please add a cellphone number");
                cellPhoneOK = false;
            }
            else
            {
                errorCellPhone.SetError(txtCellPhone, "");
            }

            if (txtHomePhone.Text == "")
            {
                errorHomePhone.SetError(txtHomePhone, "Please add a home phone number");
                homePhoneOK = false;
            }
            else
            {
                errorHomePhone.SetError(txtHomePhone, "");
            }

            return cellPhoneOK && homePhoneOK;
        }

        private bool ValidateAddresses()
        {
            bool streetOK = true;
            bool cityOK = true;
            bool zipcodeOK = true;
            bool countryOK = true;

            //if (txtStreet.Text == "")
            //{
            //    errorStreet.SetError(txtStreet, "Please add a street");
            //    streetOK = false;
            //}
            //else
            //{
            //    errorStreet.SetError(txtStreet, "");
            //}

            if (String.IsNullOrWhiteSpace(txtCity.Text))
            {
                errorCity.SetError(txtCity, "Please add a city");
                cityOK = false;
            }
            else
            {
                errorCity.SetError(txtCity, "");
            }

            //if (txtZipcode.Text == "")
            //{
            //    errorZipcode.SetError(txtZipcode, "Please add a zipcode");
            //    zipcodeOK = false;
            //}
            //else
            //{
            //    errorZipcode.SetError(txtZipcode, "");
            //}

            if (cmbCountry.Text == "")
            {
                errorCountry.SetError(cmbCountry, "Please select a country");
                countryOK = false;
            }
            else
            {
                errorCountry.SetError(cmbCountry, "");
            }

            return streetOK && cityOK && zipcodeOK && countryOK;
        }
        #endregion

        #region Unused commented out code
        //private bool MessageBoxConfirmation()
        //{
        //    string message = "Are you sure you want to cancel?";
        //    string title = "Cancel";

        //    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        //    DialogResult result = MessageBox.Show(message, title, buttons);

        //    if (result == DialogResult.Yes)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //private void UpdateGUI()
        //{
        //}
        #endregion
    }
}
