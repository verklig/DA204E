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

        // Does this work?
        internal Contact ContactData { get { return contact; } set { contact = value; } }

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
            foreach (Countries country in Enum.GetValues(typeof(Countries)))
            {
                cmbCountry.Items.Add(country.ToString());
            }

            ControlBox = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool namesOK = ReadNames();
            bool emailsOK = ReadEmails();
            bool phonesOK = ReadPhones();
            bool addressesOK = ReadAddresses();

            if (namesOK && emailsOK && phonesOK && addressesOK)
            {
                Close();
            }
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

        private bool ReadNames()
        {
            Contact contact = new Contact();
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

        private bool ReadEmails()
        {
            Email email = new Email();
            string emailBusiness = txtEmailBusiness.Text.Trim();
            string emailPrivate = txtEmailPrivate.Text.Trim();

            bool ok = ValidateEmails();

            if (ok)
            {
                email.Work = emailBusiness;
                email.Personal = emailPrivate;
            }

            return ok;
        }

        private bool ReadPhones()
        {
            Phone phone = new Phone();
            string cellPhone = txtCellPhone.Text.Trim();
            string homePhone = txtHomePhone.Text.Trim();

            bool ok = ValidatePhones();

            if (ok)
            {
                phone.CellPhone = cellPhone;
                phone.HomePhone = homePhone;
            }

            return ok;
        }

        private bool ReadAddresses()
        {
            Address address = new Address();
            string street = txtStreet.Text.Trim();
            string city = txtCity.Text.Trim();
            string zipcode = txtZipcode.Text.Trim();

            Countries country;
            Enum.TryParse(cmbCountry.Text, out country);

            bool ok = ValidateAddresses();

            if (ok)
            {
                address.Street = street;
                address.City = city;
                address.Zipcode = zipcode;
                address.Country = country;
            }

            return ok;
        }

        #region Validators
        private bool ValidateNames()
        {
            bool firstNameOK = true;
            bool lastNameOK = true;

            if (txtFirstName.Text == "")
            {
                errorFirstName.SetError(txtFirstName, "Please add a first name");
                firstNameOK = false;
            }
            else
            {
                errorFirstName.SetError(txtFirstName, "");
            }

            if (txtLastName.Text == "")
            {
                errorLastName.SetError(txtLastName, "Please add a last name");
                firstNameOK = false;
            }
            else
            {
                errorLastName.SetError(txtLastName, "");
            }

            return firstNameOK && lastNameOK;
        }

        private bool ValidateEmails()
        {
            bool emailBusinessOK = true;
            bool emailPrivateOK = true;

            if (txtEmailBusiness.Text == "")
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

            if (txtStreet.Text == "")
            {
                errorStreet.SetError(txtStreet, "Please add a street");
                streetOK = false;
            }
            else
            {
                errorStreet.SetError(txtStreet, "");
            }

            if (txtCity.Text == "")
            {
                errorCity.SetError(txtCity, "Please add a city");
                cityOK = false;
            }
            else
            {
                errorCity.SetError(txtCity, "");
            }

            if (txtZipcode.Text == "")
            {
                errorZipcode.SetError(txtZipcode, "Please add a zipcode");
                zipcodeOK = false;
            }
            else
            {
                errorZipcode.SetError(txtZipcode, "");
            }

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
    }
}
