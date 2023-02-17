using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class FunFeatures
    {
        private string name = "";
        private string email = "";

        public void Start()
        {
            // Get information from user
            Info();

            bool repeat = false;
            do
            {
                FortuneTeller();
                CalculateTextLength();

                repeat = DoAgain();
            }while(repeat);
        }
    }
}
