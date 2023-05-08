using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// This class passes the phone information to the "Contact" class.
    /// </summary>
    public class Phone
    {
        private string cellPhone; // Office phone
        private string homePhone; // Private phone

        // Getter and setters
        public string CellPhone { get { return cellPhone; } set { cellPhone = value; } }
        public string HomePhone { get { return homePhone; } set { homePhone = value; } }

        /// <summary>
        /// This is the first constructor of the class, it passes the
        /// info to the next constructor if no parameter was given.
        /// </summary>
        public Phone() : this(string.Empty)
        {
        }

        /// <summary>
        /// This is the second constructor of the class, it sets the
        /// "homePhone" variable to an empty string and passes the info to the next constructor.
        /// </summary>
        /// <param name="cellPhone"></param>
        public Phone(string cellPhone) : this(cellPhone, string.Empty)
        {
        }

        /// <summary>
        /// This is the third constructor of the class, it either
        /// gets called by the second constructor or it gets the values
        /// from the input.
        /// <param name="cellPhone"></param>
        /// <param name="homePhone"></param>
        public Phone(string cellPhone, string homePhone)
        {
            this.cellPhone = cellPhone;
            this.homePhone = homePhone;
        }

        /// <summary>
        /// This method overrides the "ToString()" method to return a formatted string
        /// that displays the phone numbers.
        /// </summary>
        /// <returns>a formatted string of the phone numbers</returns>
        public override string ToString()
        {
            string strOut = "\r\n" + "Phone Numbers" + "\r\n";

            strOut += string.Format(" {0,-10} {1, -10}\r\n", "Private", homePhone);
            strOut += string.Format(" {0,-10} {1, -10}\r\n\r\n", "Office", cellPhone);

            return strOut;
        }
    }
}
