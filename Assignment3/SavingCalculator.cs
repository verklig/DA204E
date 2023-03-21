using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /// <summary>
    /// This class calculates the saving from the user input and has private variables
    /// that can be reached by getter and setter methods.
    /// </summary>
    internal class SavingCalculator
    {
        private double interestRate; // In % from user input
        private double fees; // In % from user input
        private double initialDeposit; // First deposit from user input
        private double monthlyDeposit; // The rest of the monthly deposits from user input
        private int periodYears; // How many years from user input
        private int numOfMonths; // To calculate the number of months and be used in for loop

        #region Getters and setters

        /// <summary>
        /// Methods to set and get values from other classes
        /// such as interest rate, fees, initial deposit, monthly deposit and period.
        /// </summary>
        /// <returns>interest rate, fees, initial deposit, monthly deposit and period.</returns>
        // Getting and setting interest rate
        public double GetInterestRate()
        {
            return interestRate;
        }
        public void SetInterestRate(double value)
        {
            if (value >= 0)
                this.interestRate = value;
        }

        // Getting and setting fees
        public double GetFees()
        {
            return fees;
        }
        public void SetFees(double value)
        {
            if (value >= 0)
                this.fees = value;
        }

        // Getting and setting initial deposit
        public double GetInitialDeposit()
        {
            return initialDeposit;
        }
        public void SetInitialDeposit(double value)
        {
            if (value >= 0)
                this.initialDeposit = value;
        }

        // Getting and setting monthly deposit
        public double GetDeposit()
        { 
            return monthlyDeposit; 
        }
        public void SetDeposit(double value)
        {
            if (value >= 0)
                this.monthlyDeposit = value;
        }

        // Getting and setting period
        public int GetPeriod()
        { 
            return periodYears;
        }
        public void SetPeriod(int value)
        {
            if (value >= 0)
                this.periodYears = value;
        }
        #endregion

        #region Saving Calculation

        /// <summary>
        /// The methods calculates the interest rate, amount paid, interest earned, 
        /// fees and final balance for the saving calculation
        /// </summary>
        /// <returns>Interest rate, amount paid, interest earned, fees and final balance.</returns>
        // Calculating interest rate to be used mothly
        public double CalculateInterestRate()
        {
            interestRate = interestRate / 100 / 12;

            return interestRate;
        }

        public double CalculateAmountPaid()
        {
            double amtPaid = 0.0;
            numOfMonths = periodYears * 12;
            amtPaid = monthlyDeposit * numOfMonths + initialDeposit;

            return amtPaid;
        }

        public double CalculateFinalBalance()
        {
            double interestEarned = 0.0;
            double balance = 0.0;
            balance += initialDeposit;

            for (int i = 1; i <= numOfMonths; i++)
            {
                interestEarned = interestRate * balance;
                balance += interestEarned + monthlyDeposit;
            }

            return balance;
        }

        public double CalculateFinalInterestEarned()
        {
            double finalInterestEarned = 0.0;
            double interestEarned = 0.0;
            double balance = 0.0;
            balance += initialDeposit;

            for (int i = 1; i <= numOfMonths; i++)
            {
                interestEarned = interestRate * balance;
                finalInterestEarned += interestEarned;
                balance += interestEarned + monthlyDeposit;
            }

            return finalInterestEarned;
        }

        public double CalculateFinalFees()
        {
            double finalFee = 0.0;
            double interestEarned = 0.0;
            double balance = 0.0;
            balance += initialDeposit;

            fees = fees / 100 / 12;

            for (int i = 1; i <= numOfMonths; i++)
            {
                interestEarned = interestRate * balance;
                finalFee += balance * fees;
                balance += interestEarned + monthlyDeposit;
            }
            fees = finalFee;

            return finalFee;
        }
        #endregion
    }
}
