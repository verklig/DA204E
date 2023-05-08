using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    /// <summary>
    /// This class temporarily saves data to be sent to the "Customer" class.
    /// </summary>
    internal class Contact
    {
        private Email email; // Email object
        private Phone phone; // Phone object
        private Address address; // Address object
        private string firstName; // First name as a string
        private string lastName; // First name as a string

        // Getter and setters
        public Email EmailData { get { return email; } set { email = value; } }
        public Phone PhoneData { get { return phone; } set { phone = value; } }
        public Address AddressData { get { return address; } set { address = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        /// <summary>
        /// The constructor of the class.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// This method gets the address info and send it out as a formatted string.
        /// </summary>
        /// <returns>a formatted string</returns>
        public string GetAddressInfo()
        {
            string name = "";
            string street = "";
            string zipcodeAndCity = "";

            if (firstName == "" || lastName == "")
            {
                name = firstName + lastName;
            }
            else
            {
                name = firstName + " " + lastName;
            }

            if (address.Street == "")
            {
                street = "";
            }
            else
            {
                street = address.Street + "\r\n";
            }

            if (address.Zipcode == "")
            {
                zipcodeAndCity = address.City;
            }
            else
            {
                zipcodeAndCity = address.Zipcode + " " + address.City;
            }

            return string.Format("{0}\r\n{1}{2}\r\n{3}", name, street, zipcodeAndCity, address.Country.ToString().Replace("_", " "));
        }

        /// <summary>
        /// This method overrides the "ToString()" method to return a formatted string
        /// that displays the name, cellphone and office email to the list.
        /// </summary>
        /// <returns>string with name, cellphone and office email</returns>
        public override string ToString()
        {
            string name = "";
            string cellPhone = "";
            string officeMail = "";


            if (firstName == "" || lastName == "")
            {
                name = lastName + firstName;
            }
            else
            {
                name = lastName.ToUpper() + ", " + firstName;
            }

            if (phone.ToString() != "" && phone.CellPhone.ToString() != "") 
            {
                cellPhone = phone.CellPhone;
            }
            else
            {
                cellPhone = "-";
            }

            if (email.ToString() != "" && email.Work.ToString() != "")
            {
                officeMail = email.Work;
            }
            else
            {
                officeMail = "-";
            }

            return string.Format("{0,-30} {1, -24} {2}", name, cellPhone, officeMail);
        }

        #region Unused commented out code
        //public Contact(Contact theOther)
        //{
        //}

        //public Contact(string firstName, string lastName, Email email, Phone phone, Address address)
        //{
        //}

        //public bool CheckData()
        //{
        //    return true;
        //}
        #endregion
    }
}
