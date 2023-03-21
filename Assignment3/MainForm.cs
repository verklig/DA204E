using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary>
    /// This class is the main class of this program. Because this is a windows forms program
    /// there is another "Program.cs" class that is there to initialize this class. The rest
    /// is contained here as the main method.
    /// This program is a calculator that can calculate the bmi and bmr of a person, and also calculate
    /// savings from the user input.
    /// </summary>
    public partial class MainForm : Form
    {
        // Setting variables
        private string name = string.Empty; // Name to be set by user input
        private BMICalculator bmiCalc = new BMICalculator();
        private SavingCalculator savingCalc = new SavingCalculator();
        private BMRCalculator bmrCalc = new BMRCalculator();

        
        public MainForm()
        {
            InitializeComponent(); // Contains things for the forms program to work
            InitializeGUI(); // Changing how the gui looks like before using the program
        }
        
        private void InitializeGUI()
        {
            this.Text += " by Eric Blohm";
            calcBMI.Text = string.Empty;
            calcWeightCat.Text = string.Empty;
            calcAmountPaid.Text = string.Empty;
            calcFinalBalance.Text = string.Empty;
            calcAmountEarned.Text = string.Empty;
            calcTotalFees.Text = string.Empty;
            lblNormalBMI.Text = "Normal BMI is between 18.5 and 24.9";
            rbtnMetric.Checked = true;
            rbtnMale.Checked = true;
            rbtnSedentary.Checked = true;
        }

        /// <summary>
        /// This region contains methods that are being used by the BMI Calculator class.
        /// </summary>
        #region BMI Calculator

        // Updates the gui depending on which unit is checked
        // and clears some parts to make it more user friendly
        private void UpdateUnitCheck()
        {
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                txtInch.Visible = false;
                lblQuote1.Visible = false;
                lblQuote2.Visible = false;

            }
            else
            {
                lblHeight.Text = "Height (ft, in)";
                lblWeight.Text = "Weight (lbs)";
                txtInch.Visible = true;
                lblQuote1.Visible = true;
                lblQuote2.Visible = true;
            }
            grpResults.Text = "Results";
            calcBMI.Text = string.Empty;
            calcWeightCat.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtCmFt.Text = string.Empty;
            txtInch.Text = string.Empty;
            listBMR.Items.Clear();
        }

        // Starts the program in the center of the screen
        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        // Updates the gui when the unit is changed
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUnitCheck();
        }

        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUnitCheck();
        }

        // Reads the input and displays the results when the bmi button is pressed
        private void btnBMI_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            // If all input from the user is okay then call the method below
            if (ok)
            {
                CalculateAndDisplayResultsBMI();
            }
        }

        // A method to calculate and display the bmi results
        private void CalculateAndDisplayResultsBMI()
        {
            double bmi = bmiCalc.CalculateBMI();
            calcBMI.Text = bmi.ToString("0.00");
            calcWeightCat.Text = bmiCalc.BmiWeightCategory();

            // If there is a name or any string in the name box
            // then change "Results" to add that
            if (!string.IsNullOrEmpty(name))
                grpResults.Text = "Results for " + name;
        }

        // A method to read all the input to calculate the bmi
        private bool ReadInputBMI()
        {
            ReadUnit();
            ReadName();

            // Read height and weight if the input is okay for them both
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();

            return heightOK && weightOK;
        }

        // Reads and sets the unit for the mbi and mbr
        private void ReadUnit()
        {
            if (rbtnMetric.Checked)
            {
                bmiCalc.SetUnit(UnitType.Metric);
                bmrCalc.SetUnit(UnitType.Metric);
            }
            if (rbtnImperial.Checked)
            {
                bmiCalc.SetUnit(UnitType.Imperial);
                bmrCalc.SetUnit(UnitType.Imperial);
            }
        }

        // Reads the name and trims it down if there are any spaces
        private void ReadName()
        {
            name = txtName.Text.Trim();
        }

        // Reads the height input, displays an error and doesn't proceed with the calculation
        // if the input is not a double or is less than 0
        private bool ReadHeight()
        {
            double height = 0.0;
            double inch = 0.0;

            bool ok = double.TryParse(txtCmFt.Text, out height);
            if (!ok || height < 0)
            {
                MessageBox.Show("The height value is invalid!", "Error");
            }
            
            if (rbtnImperial.Checked)
            {
                ok = ok && double.TryParse(txtInch.Text, out inch);
                if (!ok || inch < 0)
                {
                    MessageBox.Show("The inch value is invalid!", "Error");
                }
            }

            // Changes value depending on the unit used
            if (bmiCalc.GetUnitType() == UnitType.Metric)
                height = height / 100.0;
            else
                height = height * 12.0 + inch;

            if (height < 0 || inch < 0)
            {
                ok = false;
                return ok;
            }
            else
            {
                bmiCalc.SetHeight(height);
                bmrCalc.SetHeight(height);
                return ok;
            }
        }

        // Reads the weight input, displays an error and doesn't proceed with the calculation
        // if the input is not a double or is less than 0
        private bool ReadWeight()
        {
            double weight = 0.0;

            bool ok = double.TryParse(txtWeight.Text, out weight);
            if (!ok || weight < 0)
            {
                MessageBox.Show("The weight value is invalid!", "Error");
                ok = false;
                return ok;
            }
            else
            {
                bmiCalc.SetWeight(weight);
                bmrCalc.SetWeight(weight);
                return ok;
            }
        }
        #endregion

        /// <summary>
        /// This region contains methods that are being used by the Saving Calculator class.
        /// </summary>
        #region Saving Calculator

        // Reads the input and displays the results when the saving button is pressed
        private void btnSaving_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputSaving();

            // If all input from the user is okay then call the method below
            if (ok)
            {
                CalculateAndDisplayResultsSaving();
            }
        }

        // A method to calculate and display the saving results
        private void CalculateAndDisplayResultsSaving()
        {
            savingCalc.CalculateInterestRate();

            double amtPaid = savingCalc.CalculateAmountPaid();
            double finalBalance = savingCalc.CalculateFinalBalance();
            double finalInterestEarned = savingCalc.CalculateFinalInterestEarned();
            double finalFees = savingCalc.CalculateFinalFees();

            finalBalance = finalBalance - finalFees; // Removes the fees from the balance

            // Prints the calculations the their corresponding text boxes
            calcAmountPaid.Text = amtPaid.ToString("0.00");
            calcFinalBalance.Text = finalBalance.ToString("0.00");
            calcAmountEarned.Text = finalInterestEarned.ToString("0.00");
            calcTotalFees.Text = finalFees.ToString("0.00");
        }

        // A method to read all the input to calculate the saving
        private bool ReadInputSaving()
        {
            // Read the different values needed and if they are all okay, return them as a boolean
            bool initialDepositOK = ReadInitialDeposit();
            bool depositOK = ReadMonthlyDeposit();
            bool periodOK = ReadPeriod();
            bool interestRateOK = ReadInterestRate();
            bool feesOK = ReadFees();

            return depositOK && periodOK && initialDepositOK && interestRateOK && feesOK;
        }

        // A method to read the initial deposit from the user, gives an error if the value is invalid
        private bool ReadInitialDeposit()
        {
            double initialDeposit = 0.0;

            bool ok = double.TryParse(txtInitialDeposit.Text, out initialDeposit);
            if (!ok || initialDeposit < 0)
            {
                MessageBox.Show("The initial deposit value is invalid!", "Error");
                ok = false;
                return ok;
            }
            else
            {
                savingCalc.SetInitialDeposit(initialDeposit);
                return ok;
            }
        }

        // A method to read the monthly deposit from the user, gives an error if the value is invalid
        private bool ReadMonthlyDeposit()
        {
            double deposit = 0.0;

            bool ok = double.TryParse(txtMonthlyDeposit.Text, out deposit);
            if (!ok || deposit < 0)
            {
                MessageBox.Show("The monthly deposit value is invalid!", "Error");
                ok = false;
                return ok;
            }
            else
            {
                savingCalc.SetDeposit(deposit);
                return ok;
            }
        }

        // A method to read the period from the user, gives an error if the value is invalid
        private bool ReadPeriod()
        {
            int period = 0;

            bool ok = int.TryParse(txtPeriod.Text, out period);
            if (!ok || period < 0)
            {
                MessageBox.Show("The period value is invalid!", "Error");
                ok = false;
                return ok;
            }
            else
            {
                savingCalc.SetPeriod(period);
                return ok;
            }
        }

        // A method to read the interest rate from the user, gives an error if the value is invalid
        private bool ReadInterestRate()
        {
            double interest = 0.0;

            bool ok = double.TryParse(txtInterest.Text, out interest);
            if (!ok || interest < 0)
            {
                MessageBox.Show("The growth value is invalid!", "Error");
                ok = false;
                return ok;
            }
            else
            {
                savingCalc.SetInterestRate(interest);
                return ok;
            }
        }

        // A method to read the fees from the user, gives an error if the value is invalid
        private bool ReadFees()
        {
            double fees = 0.0;

            bool ok = double.TryParse(txtFees.Text, out fees);
            if (!ok || fees < 0)
            {
                MessageBox.Show("The fees value is invalid!", "Error");
                ok = false;
                return ok;
            }
            else
            {
                savingCalc.SetFees(fees);
                return ok;
            }
        }
        #endregion

        /// <summary>
        /// This region contains methods that are being used by the BMR Calculator class.
        /// </summary>
        #region BMR Calculator

        // Reads the input and displays the results when the bmr button is pressed
        private void btnBMR_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMR();

            // If all input from the user is okay then call the method below
            if (ok)
            {
                CalculateAndDisplayResultsBMR();
            }
        }

        // A method to calculate and display the bmr results
        private void CalculateAndDisplayResultsBMR()
        {
            double bmr = bmrCalc.CalculateBMR();
            double bmrLose1 = bmr - 500;
            double bmrLose2 = bmr - 1000;
            double bmrGain1 = bmr + 500;
            double bmrGain2 = bmr + 1000;

            listBMR.Items.Clear();
            listBMR.Items.Add("BMR RESULTS");

            if (!string.IsNullOrEmpty(name))
            {
                listBMR.Items.Remove("BMR RESULTS");
                listBMR.Items.Add("BMR RESULTS FOR " + name.ToUpper());
            }

            listBMR.Items.Add(string.Empty);
            listBMR.Items.Add("Your BMR (calories/day)");
            listBMR.Items.Add("Calories to maintain your weight                 " + bmr.ToString("0.0"));
            listBMR.Items.Add("Calories to lose 0,5 kg (1.1 lbs) per week       " + bmrLose1.ToString("0.0"));
            listBMR.Items.Add("Calories to lose 1 kg (2.2 lbs) per week         " + bmrLose2.ToString("0.0"));
            listBMR.Items.Add("Calories to gain 0,5 kg (1.1 lbs) per week       " + bmrGain1.ToString("0.0"));
            listBMR.Items.Add("Calories to gain 1 kg (2.2 lbs) per week         " + bmrGain2.ToString("0.0"));

            listBMR.Items.Add(string.Empty);
            listBMR.Items.Add("Losing more than 1000 calories per day is to be avoided.");
        }

        // A method to read all the input to calculate the bmr
        private bool ReadInputBMR()
        {
            ReadUnit();
            ReadName();
            ReadGender();
            ReadExecersiceGroup();

            // Read the different values needed and if they are all okay, return them as a boolean
            bool ageOK = ReadAge();
            bool heightOK = ReadHeight();
            bool weightOK = ReadWeight();

            return ageOK && heightOK && weightOK;
        }

        // A method to read the gender and set it as the checked one
        private void ReadGender()
        {
            if (rbtnMale.Checked)
                bmrCalc.SetGender(Gender.Male);
            if (rbtnFemale.Checked)
                bmrCalc.SetGender(Gender.Female);
        }

        // A method to read the exercise group and set it as the checked one
        private void ReadExecersiceGroup()
        {
            if (rbtnSedentary.Checked)
                bmrCalc.SetExerciseGroup(ExerciseGroup.Sedentary);
            if (rbtnLightlyActive.Checked)
                bmrCalc.SetExerciseGroup(ExerciseGroup.LightlyActive);
            if (rbtnModeratelyActive.Checked)
                bmrCalc.SetExerciseGroup(ExerciseGroup.ModeratelyActive);
            if (rbtnVeryActive.Checked)
                bmrCalc.SetExerciseGroup(ExerciseGroup.VeryActive);
            if (rbtnExtraActive.Checked)
                bmrCalc.SetExerciseGroup(ExerciseGroup.ExtraActive);
        }

        // A method to read the age from the user, gives an error if the value is invalid
        private bool ReadAge()
        {
            int age = 0;

            bool ok = int.TryParse(txtAge.Text, out age);
            if (!ok || age < 10)
            {
                MessageBox.Show("The age value is invalid! (lowest value is 10)", "Error");
                ok = false;
                return ok;
            }
            else
            {
                bmrCalc.SetAge(age);
                return ok;
            }
        }
        #endregion
    }
}