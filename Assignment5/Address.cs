using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Address
    {
        private string street;
        private string city;
        private string zipcode;
        private Countries country;

        public string Street { get { return street; } set { street = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Zipcode { get { return zipcode; } set { zipcode = value; } }
        public Countries Country { get { return country; } set { country = value; } }
    }
}
