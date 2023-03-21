using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /// <summary>
    /// This class calculates the BMI and has private variables
    /// that can be reached by getter and setter methods.
    /// </summary>
    internal class BMICalculator
    {
        // Instance variables for input
        private string name; // Default name = nothing
        private double height; // Cm, inches
        private double weight; // Kg, lbs
        private double bmiValue; // The bmi value
        private UnitType unit; // To change unit type

        public BMICalculator()
        {
            unit = UnitType.Metric; // Setting default unit to be the metric system
        }

        #region Getters and setters

        /// <summary>
        /// Methods to set and get values from other classes
        /// such as name, height, weight and unit type.
        /// </summary>
        /// <returns>Name, height, weight and unit type.</returns>
        // Getting and setting name
        public string GetName()
        { 
            return name; 
        }
        public void SetName(string value)
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
        }

        // Getting and setting height value
        public double GetHeight()
        { 
            return height;
        }
        public void SetHeight(double value)
        {
            if (value >= 0.0)
                this.height = value;
        }

        // Getting and setting weight value
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double value)
        {
            if (value >= 0.0)
                this.weight = value;
        }

        // Getting and setting unit type
        public UnitType GetUnitType()
        {
            return unit;
        }
        public void SetUnit(UnitType value)
        {
            this.unit = value;
        }
        #endregion

        #region BMI Calculation

        /// <summary>
        /// The method calculates the bmi of the user input
        /// depending on the unit type chosen.
        /// </summary>
        /// <returns>The bmi value.</returns>
        public double CalculateBMI()
        {
            bmiValue = 0.0;
            double factor = 1.0;

            if (unit == UnitType.Imperial)
            {
                factor = 703.0;
            }

            bmiValue = factor * weight / (height * height);

            return bmiValue;
        }
        #endregion

        #region BMI Weight category

        /// <summary>
        /// Depending on the calculation above, this method chooses
        /// wether the user input is considered underweight, normal weight
        /// or overweight.
        /// </summary>
        /// <returns>The weight category as a string.</returns>
        public string BmiWeightCategory()
        {
            double bmi = bmiValue;
            string stringout = string.Empty;

            if (bmi < 18.5)
                stringout = "Underweight";
            else if (bmi <= 24.9)
                stringout = "Normal weight";
            else if (bmi <= 29.9)
                stringout = "Overweight (Pre-obesity)";
            else if (bmi <= 34.9)
                stringout = "Overweight (Obesity class I)";
            else if (bmi <= 39.9)
                stringout = "Overweight (Obesity class II)";
            else // (bmi >= 40)
                stringout = "Overweight (Obesity class III)";

            return stringout;
        }
        #endregion
    }
}