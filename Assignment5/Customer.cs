using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// This class contains a customer to be added in the list of the "CustomerManager" class.
    /// </summary>
    internal class Customer
    {
        private Contact contact; // Contact object
        private int id; // ID of the customer

        // Getter and setters
        public Contact Contact { get { return contact; } set { contact = value; } }
        public int ID { get { return id; } set { id = value; } }

        /// <summary>
        /// The default constructor of the class with the contact as the parameter.
        /// </summary>
        /// <param name="contact"></param>
        public Customer(Contact contact)
        {
            this.contact = contact;
        }

        /// <summary>
        /// This method overrides the "ToString()" method to add the id of the customer.
        /// </summary>
        /// <returns>customer id and contact details</returns>
        public override string ToString()
        {
            return id + "              " + contact.ToString();
        }
    }
}
