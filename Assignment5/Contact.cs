using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Contact
    {
        private Email email;
        private Phone phone;
        private Address address;
        private string firstName;
        private string lastName;

        public Email EmailData { get; set; }
        public Phone PhoneData { get; set; }
        public Address AddressData { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact()
        {

        }

        public Contact(Contact theOther)
        {

        }

        public Contact(string firstName, string lastName, Email email, Phone phone, Address address)
        {

        }

        public bool CheckData()
        {
            return true;
        }

        public string GetAddressInfo()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
