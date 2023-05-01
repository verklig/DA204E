using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Phone
    {
        private string cellPhone;
        private string homePhone;

        public string CellPhone { get { return cellPhone; } set { cellPhone = value; } }
        public string HomePhone { get { return homePhone; } set { homePhone = value; } }
    }
}
