using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// This class passes the address information to the "Contact" class.
    /// </summary>
    public class Address
    {
        private string street; // Street as a string
        private string city; // City as a string
        private string zipcode; // Zipcode as a string
        private Countries country; // Countries object

        // Getter and setters
        public string Street { get { return street; } set { street = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Zipcode { get { return zipcode; } set { zipcode = value; } }
        public Countries Country { get { return country; } set { country = value; } }

        /// <summary>
        /// This is the first constructor of the class, it passes the
        /// info to the next constructor.
        /// </summary>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Address(string city, Countries country) : this(string.Empty, city, string.Empty, country)
        {
        }

        /// <summary>
        /// This is the second constructor of the class, it gets info
        /// from the previous constructor if it was called, otherwise
        /// it takes the info passed in the parameters when called.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="zipcode"></param>
        /// <param name="country"></param>
        public Address(string street, string city, string zipcode, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zipcode = zipcode;
            this.country = country;
        }
    }
}
