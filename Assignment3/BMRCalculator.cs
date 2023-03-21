using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment3
{
    /// <summary>
    /// This class calculates the BMR and has private variables
    /// that can be reached by getter and setter methods.
    /// </summary>
    internal class BMRCalculator
    {
        private string name; // Default name = nothing
        private int age; // Age to be set by the user
        private double height; // Cm, inches
        private double weight; // Kg, lbs
        private UnitType unit; // To change unit type
        private Gender gender; // To change gender
        private ExerciseGroup exerciseGroup; // To change the exercise group

        public BMRCalculator()
        {
            gender = Gender.Male; // Setting default gender to be male
            exerciseGroup = ExerciseGroup.Sedentary; // Setting default exercise group to be sedentary
            unit = UnitType.Metric; // Setting default unit to be the metric system
        }

        #region Getters and setters

        /// <summary>
        /// Methods to set and get values from other classes
        /// such as name, age, height, weight, unit type, gender and exercise group.
        /// </summary>
        /// <returns>Name, age, height, weight, unit type, gender and exercise group.</returns>
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

        // Getting and setting height
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double value)
        {
            if (value >= 0.0)
                this.height = value;
        }

        // Getting and setting weight
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double value)
        {
            if (value >= 0.0)
                this.weight = value;
        }

        // Getting and setting age
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int value)
        {
            if (value >= 0)
                this.age = value;
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

        // Getting and setting gender
        public Gender GetGender()
        {
            return gender;
        }
        public void SetGender(Gender value)
        {
            this.gender = value;
        }

        // Getting and setting exercise group
        public ExerciseGroup GetExerciseGroup()
        {
            return exerciseGroup;
        }
        public void SetExerciseGroup(ExerciseGroup value)
        {
            this.exerciseGroup = value;
        }
        #endregion

        #region BMR Calculation

        /// <summary>
        /// The method calculates the bmr of the user input
        /// depending on the unit type chosen.
        /// </summary>
        /// <returns>The bmr value.</returns>
        public double CalculateBMR()
        {
            double factor = 0.0;
            double maintainWeightBMR = 0.0;
            double BMR = 0.0;

            // Changing the factor to multiply depening on what option is checked
            if (exerciseGroup == ExerciseGroup.Sedentary)
            {
                factor = 1.2;
            }
            if (exerciseGroup == ExerciseGroup.LightlyActive)
            {
                factor = 1.375;
            }
            if (exerciseGroup == ExerciseGroup.ModeratelyActive)
            {
                factor = 1.55;
            }
            if (exerciseGroup == ExerciseGroup.VeryActive)
            {
                factor = 1.725;
            }
            if (exerciseGroup == ExerciseGroup.ExtraActive)
            {
                factor = 1.9;
            }

            // If the unit is imperial, convert to metric
            if (unit == UnitType.Imperial)
            {
                height = height * 2.54;
                weight = weight * 0.45359237;
            }
            // If the unit is metric, multiply by 100 because of other calculation done before that was deviding by 100
            if (unit == UnitType.Metric)
            {
                height = height * 100;
            }

            // The main calculation for the bmr
            BMR = 10 * weight + 6.25 * height - 5 * age;

            // Depending on if the gender is male or female, add this on top of the mbr value to get the real bmr value
            if (gender == Gender.Male)
            {
                BMR = BMR += 5;
            }
            if (gender == Gender.Female)
            {
                BMR = BMR -= 161;
            }

            maintainWeightBMR = BMR * factor;

            return maintainWeightBMR;
        }
        #endregion
    }
}
