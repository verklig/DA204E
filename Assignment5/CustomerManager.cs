using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// This class is the manager for the customers, it adds or changes the customers if the values are valid.
    /// </summary>
    internal class CustomerManager
    {
        List<Customer> customers = new List<Customer>(); // List of customers
        private int lastID = 100; // Customer ID that starts with 100

        //Getter
        public int CustomerCount { get { return customers.Count; } }

        /// <summary>
        /// The constructor of the class.
        /// </summary>
        public CustomerManager()
        {
        }

        /// <summary>
        /// This method adds a new customer to the list
        /// and changes the id for the next customer.
        /// </summary>
        /// <param name="contactIn"></param>
        public void AddCustomer(Customer contactIn)
        {
            if (contactIn != null)
            {
                contactIn.ID = lastID++;
                customers.Add(contactIn);
            }
        }

        /// <summary>
        /// This method edits the customer and saves it if input is valid.
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="index"></param>
        public void ChangeCustomer(Customer customer, int index)
        {
            if (CheckIndex(index))
            {
                int oldID = customers[index].ID;
                customer.ID = oldID;
                customers[index] = customer;
            }
        }

        /// <summary>
        /// This method deletes the customer at the specified index in the list.
        /// </summary>
        /// <param name="index"></param>
        public void DeleteCustomer(int index)
        {
            if (CheckIndex(index))
            {
                customers.RemoveAt(index);
            }
        }

        /// <summary>
        /// This method checks so that the index is within the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>true or false</returns>
        public bool CheckIndex(int index)
        {
            bool ok = (index >= 0) && (index < customers.Count);

            return ok;
        }

        /// <summary>
        /// This method is a getter for the customer.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Customer GetCustomer(int index)
        {
            return customers[index];
        }

        #region Unused commented out code
        //public string GetAddressInfo(int index)
        //{
        //    return null;
        //}

        //public string[] GetCustomerInfoStrings(int index)
        //{
        //    return null;
        //}

        //public string GetEmailInfo(int index)
        //{
        //    return null;
        //}

        //public string GetPhoneInfo(int index)
        //{
        //    return null;
        //}
        #endregion
    }
}
