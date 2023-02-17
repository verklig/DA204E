using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    internal class Pet
    {
        private string name; // Name of the pet
        private int age; // Age as an integer
        private bool isFemale; // True if female, false otherwise
        private string gender; // Gender of the pet
    
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Starting the pet program!");
            Console.WriteLine();

            ReadAndSavePetData();
            ShowPetInfo();
        }

        private void ReadAndSavePetData()
        {
            ReadName();
            ReadAge();
            ReadGender();
            GetGender();
        }

        private void ShowPetInfo()
        {
            // Writes text out to the console containing the pet's name, age and gender
            string textOut = "Name: " + name + "\n" + "Age: " + age + "\n" + name + " is a good " + gender + "!";

            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine(textOut); // Writes the above string to the console
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine(); // Blank line
        }

        private void ReadName()
        {
            // Reads the name of the pet put in by user
            Console.WriteLine("What's the name of your pet?" + "\n");

            name = Console.ReadLine();
            Console.WriteLine();
        }

        private void ReadAge()
        {
            // Reads the age of the pet put in by user
            Console.WriteLine("What age is " + name + "?" + "\n");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        private void ReadGender()
        {
            // Reads a logical value y or n put in by the user
            Console.Write("Is your pet female (y/n)?" + "\n");
            Console.WriteLine();

            string strGender = Console.ReadLine();

            char response = strGender[0];

            if ((response == 'y') || (response == 'Y'))
                isFemale = true;
            else
                isFemale = false;

            Console.WriteLine();
        }

        private void GetGender()
        {
            // If gender is female, gender = girl, otherwise boy
            if (isFemale)
            {
                gender = "girl";
            }
            else
            {
                gender = "boy";
            }
        }
    }
}
