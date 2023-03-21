namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtCmFt = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnBMI = new System.Windows.Forms.Button();
            this.lblNormalBMI = new System.Windows.Forms.Label();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.calcBMI = new System.Windows.Forms.Label();
            this.calcWeightCat = new System.Windows.Forms.Label();
            this.lblWeightCat = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblQuote1 = new System.Windows.Forms.Label();
            this.lblQuote2 = new System.Windows.Forms.Label();
            this.grpSavingPlan = new System.Windows.Forms.GroupBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtMonthlyDeposit = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblMonthlyDeposit = new System.Windows.Forms.Label();
            this.grpFutureValue = new System.Windows.Forms.GroupBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.calcTotalFees = new System.Windows.Forms.Label();
            this.calcAmountEarned = new System.Windows.Forms.Label();
            this.calcFinalBalance = new System.Windows.Forms.Label();
            this.calcAmountPaid = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblAmountEarned = new System.Windows.Forms.Label();
            this.lblFinalBalance = new System.Windows.Forms.Label();
            this.btnSaving = new System.Windows.Forms.Button();
            this.grpBmiCalculator = new System.Windows.Forms.GroupBox();
            this.listBMR = new System.Windows.Forms.ListBox();
            this.grpBmrCalculator = new System.Windows.Forms.GroupBox();
            this.btnBMR = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.grpActivityLevel = new System.Windows.Forms.GroupBox();
            this.rbtnExtraActive = new System.Windows.Forms.RadioButton();
            this.rbtnVeryActive = new System.Windows.Forms.RadioButton();
            this.rbtnModeratelyActive = new System.Windows.Forms.RadioButton();
            this.rbtnLightlyActive = new System.Windows.Forms.RadioButton();
            this.rbtnSedentary = new System.Windows.Forms.RadioButton();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.grpUnit.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.grpSavingPlan.SuspendLayout();
            this.grpFutureValue.SuspendLayout();
            this.grpBmiCalculator.SuspendLayout();
            this.grpBmrCalculator.SuspendLayout();
            this.grpActivityLevel.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(16, 32);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(16, 72);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(46, 16);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height";
            // 
            // txtCmFt
            // 
            this.txtCmFt.Location = new System.Drawing.Point(97, 71);
            this.txtCmFt.Name = "txtCmFt";
            this.txtCmFt.Size = new System.Drawing.Size(85, 20);
            this.txtCmFt.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(16, 96);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(49, 16);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "Weight";
            // 
            // txtInch
            // 
            this.txtInch.Location = new System.Drawing.Point(200, 71);
            this.txtInch.Name = "txtInch";
            this.txtInch.Size = new System.Drawing.Size(85, 20);
            this.txtInch.TabIndex = 5;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(97, 95);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(85, 20);
            this.txtWeight.TabIndex = 6;
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(12, 151);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(182, 38);
            this.btnBMI.TabIndex = 7;
            this.btnBMI.Text = "Calculate BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // lblNormalBMI
            // 
            this.lblNormalBMI.ForeColor = System.Drawing.Color.Green;
            this.lblNormalBMI.Location = new System.Drawing.Point(19, 114);
            this.lblNormalBMI.Name = "lblNormalBMI";
            this.lblNormalBMI.Size = new System.Drawing.Size(333, 27);
            this.lblNormalBMI.TabIndex = 12;
            this.lblNormalBMI.Text = "(normalweight)";
            this.lblNormalBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.rbtnImperial);
            this.grpUnit.Controls.Add(this.rbtnMetric);
            this.grpUnit.Location = new System.Drawing.Point(340, 12);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(133, 78);
            this.grpUnit.TabIndex = 14;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // rbtnImperial
            // 
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.Location = new System.Drawing.Point(21, 43);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(95, 17);
            this.rbtnImperial.TabIndex = 1;
            this.rbtnImperial.TabStop = true;
            this.rbtnImperial.Text = "Imperial (lbs, ft)";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            this.rbtnImperial.CheckedChanged += new System.EventHandler(this.rbtnImperial_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(21, 20);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(95, 17);
            this.rbtnMetric.TabIndex = 0;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric (kg, cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.calcBMI);
            this.grpResults.Controls.Add(this.calcWeightCat);
            this.grpResults.Controls.Add(this.lblWeightCat);
            this.grpResults.Controls.Add(this.lblBMI);
            this.grpResults.Controls.Add(this.lblNormalBMI);
            this.grpResults.Location = new System.Drawing.Point(12, 195);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(384, 155);
            this.grpResults.TabIndex = 15;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // calcBMI
            // 
            this.calcBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calcBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBMI.Location = new System.Drawing.Point(146, 32);
            this.calcBMI.Name = "calcBMI";
            this.calcBMI.Size = new System.Drawing.Size(206, 26);
            this.calcBMI.TabIndex = 17;
            this.calcBMI.Text = "(bmi)";
            this.calcBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcWeightCat
            // 
            this.calcWeightCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calcWeightCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcWeightCat.Location = new System.Drawing.Point(146, 66);
            this.calcWeightCat.Name = "calcWeightCat";
            this.calcWeightCat.Size = new System.Drawing.Size(206, 26);
            this.calcWeightCat.TabIndex = 16;
            this.calcWeightCat.Text = "(weightcat)";
            this.calcWeightCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeightCat
            // 
            this.lblWeightCat.AutoSize = true;
            this.lblWeightCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightCat.Location = new System.Drawing.Point(16, 71);
            this.lblWeightCat.Name = "lblWeightCat";
            this.lblWeightCat.Size = new System.Drawing.Size(107, 16);
            this.lblWeightCat.TabIndex = 15;
            this.lblWeightCat.Text = "Weight Category";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(16, 37);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(61, 16);
            this.lblBMI.TabIndex = 14;
            this.lblBMI.Text = "Your BMI";
            // 
            // lblQuote1
            // 
            this.lblQuote1.Location = new System.Drawing.Point(184, 68);
            this.lblQuote1.Name = "lblQuote1";
            this.lblQuote1.Size = new System.Drawing.Size(10, 23);
            this.lblQuote1.TabIndex = 16;
            this.lblQuote1.Text = "\'";
            // 
            // lblQuote2
            // 
            this.lblQuote2.Location = new System.Drawing.Point(291, 68);
            this.lblQuote2.Name = "lblQuote2";
            this.lblQuote2.Size = new System.Drawing.Size(21, 23);
            this.lblQuote2.TabIndex = 17;
            this.lblQuote2.Text = "\'\'";
            // 
            // grpSavingPlan
            // 
            this.grpSavingPlan.Controls.Add(this.lblFees);
            this.grpSavingPlan.Controls.Add(this.txtFees);
            this.grpSavingPlan.Controls.Add(this.txtInterest);
            this.grpSavingPlan.Controls.Add(this.lblInterest);
            this.grpSavingPlan.Controls.Add(this.txtInitialDeposit);
            this.grpSavingPlan.Controls.Add(this.lblInitialDeposit);
            this.grpSavingPlan.Controls.Add(this.txtPeriod);
            this.grpSavingPlan.Controls.Add(this.txtMonthlyDeposit);
            this.grpSavingPlan.Controls.Add(this.lblPeriod);
            this.grpSavingPlan.Controls.Add(this.lblMonthlyDeposit);
            this.grpSavingPlan.Location = new System.Drawing.Point(530, 12);
            this.grpSavingPlan.Name = "grpSavingPlan";
            this.grpSavingPlan.Size = new System.Drawing.Size(355, 189);
            this.grpSavingPlan.TabIndex = 18;
            this.grpSavingPlan.TabStop = false;
            this.grpSavingPlan.Text = "Saving plan";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(18, 139);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(66, 16);
            this.lblFees.TabIndex = 12;
            this.lblFees.Text = "Fees in %";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(203, 138);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(118, 20);
            this.txtFees.TabIndex = 11;
            this.txtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(203, 112);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(118, 20);
            this.txtInterest.TabIndex = 10;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(18, 113);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(145, 16);
            this.lblInterest.TabIndex = 9;
            this.lblInterest.Text = "Growth (or interest) in %";
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.Location = new System.Drawing.Point(203, 35);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(118, 20);
            this.txtInitialDeposit.TabIndex = 8;
            this.txtInitialDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialDeposit.Location = new System.Drawing.Point(18, 36);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(85, 16);
            this.lblInitialDeposit.TabIndex = 7;
            this.lblInitialDeposit.Text = "Initial deposit";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(203, 86);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(118, 20);
            this.txtPeriod.TabIndex = 6;
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMonthlyDeposit
            // 
            this.txtMonthlyDeposit.Location = new System.Drawing.Point(203, 61);
            this.txtMonthlyDeposit.Name = "txtMonthlyDeposit";
            this.txtMonthlyDeposit.Size = new System.Drawing.Size(118, 20);
            this.txtMonthlyDeposit.TabIndex = 5;
            this.txtMonthlyDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(18, 87);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(92, 16);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "Period (years)";
            // 
            // lblMonthlyDeposit
            // 
            this.lblMonthlyDeposit.AutoSize = true;
            this.lblMonthlyDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyDeposit.Location = new System.Drawing.Point(18, 62);
            this.lblMonthlyDeposit.Name = "lblMonthlyDeposit";
            this.lblMonthlyDeposit.Size = new System.Drawing.Size(101, 16);
            this.lblMonthlyDeposit.TabIndex = 3;
            this.lblMonthlyDeposit.Text = "Monthly deposit";
            // 
            // grpFutureValue
            // 
            this.grpFutureValue.Controls.Add(this.lblTotalFees);
            this.grpFutureValue.Controls.Add(this.calcTotalFees);
            this.grpFutureValue.Controls.Add(this.calcAmountEarned);
            this.grpFutureValue.Controls.Add(this.calcFinalBalance);
            this.grpFutureValue.Controls.Add(this.calcAmountPaid);
            this.grpFutureValue.Controls.Add(this.lblAmountPaid);
            this.grpFutureValue.Controls.Add(this.lblAmountEarned);
            this.grpFutureValue.Controls.Add(this.lblFinalBalance);
            this.grpFutureValue.Location = new System.Drawing.Point(530, 251);
            this.grpFutureValue.Name = "grpFutureValue";
            this.grpFutureValue.Size = new System.Drawing.Size(355, 190);
            this.grpFutureValue.TabIndex = 19;
            this.grpFutureValue.TabStop = false;
            this.grpFutureValue.Text = "Future value";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(18, 142);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(67, 16);
            this.lblTotalFees.TabIndex = 26;
            this.lblTotalFees.Text = "Total fees";
            // 
            // calcTotalFees
            // 
            this.calcTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calcTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcTotalFees.Location = new System.Drawing.Point(203, 137);
            this.calcTotalFees.Name = "calcTotalFees";
            this.calcTotalFees.Size = new System.Drawing.Size(118, 26);
            this.calcTotalFees.TabIndex = 25;
            this.calcTotalFees.Text = "(totalfees)";
            this.calcTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calcAmountEarned
            // 
            this.calcAmountEarned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calcAmountEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcAmountEarned.Location = new System.Drawing.Point(203, 67);
            this.calcAmountEarned.Name = "calcAmountEarned";
            this.calcAmountEarned.Size = new System.Drawing.Size(118, 26);
            this.calcAmountEarned.TabIndex = 24;
            this.calcAmountEarned.Text = "(amtearned)";
            this.calcAmountEarned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calcFinalBalance
            // 
            this.calcFinalBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calcFinalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcFinalBalance.Location = new System.Drawing.Point(203, 102);
            this.calcFinalBalance.Name = "calcFinalBalance";
            this.calcFinalBalance.Size = new System.Drawing.Size(118, 26);
            this.calcFinalBalance.TabIndex = 22;
            this.calcFinalBalance.Text = "(finalbalance)";
            this.calcFinalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calcAmountPaid
            // 
            this.calcAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calcAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcAmountPaid.Location = new System.Drawing.Point(203, 32);
            this.calcAmountPaid.Name = "calcAmountPaid";
            this.calcAmountPaid.Size = new System.Drawing.Size(118, 26);
            this.calcAmountPaid.TabIndex = 21;
            this.calcAmountPaid.Text = "(amtpaid)";
            this.calcAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.Location = new System.Drawing.Point(18, 37);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(82, 16);
            this.lblAmountPaid.TabIndex = 3;
            this.lblAmountPaid.Text = "Amount paid";
            // 
            // lblAmountEarned
            // 
            this.lblAmountEarned.AutoSize = true;
            this.lblAmountEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountEarned.Location = new System.Drawing.Point(18, 72);
            this.lblAmountEarned.Name = "lblAmountEarned";
            this.lblAmountEarned.Size = new System.Drawing.Size(98, 16);
            this.lblAmountEarned.TabIndex = 23;
            this.lblAmountEarned.Text = "Amount earned";
            // 
            // lblFinalBalance
            // 
            this.lblFinalBalance.AutoSize = true;
            this.lblFinalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalBalance.Location = new System.Drawing.Point(18, 107);
            this.lblFinalBalance.Name = "lblFinalBalance";
            this.lblFinalBalance.Size = new System.Drawing.Size(88, 16);
            this.lblFinalBalance.TabIndex = 4;
            this.lblFinalBalance.Text = "Final balance";
            // 
            // btnSaving
            // 
            this.btnSaving.Location = new System.Drawing.Point(703, 207);
            this.btnSaving.Name = "btnSaving";
            this.btnSaving.Size = new System.Drawing.Size(182, 38);
            this.btnSaving.TabIndex = 20;
            this.btnSaving.Text = "Calculate saving";
            this.btnSaving.UseVisualStyleBackColor = true;
            this.btnSaving.Click += new System.EventHandler(this.btnSaving_Click);
            // 
            // grpBmiCalculator
            // 
            this.grpBmiCalculator.Controls.Add(this.txtName);
            this.grpBmiCalculator.Controls.Add(this.lblQuote2);
            this.grpBmiCalculator.Controls.Add(this.lblName);
            this.grpBmiCalculator.Controls.Add(this.lblQuote1);
            this.grpBmiCalculator.Controls.Add(this.txtInch);
            this.grpBmiCalculator.Controls.Add(this.txtCmFt);
            this.grpBmiCalculator.Controls.Add(this.lblWeight);
            this.grpBmiCalculator.Controls.Add(this.lblHeight);
            this.grpBmiCalculator.Controls.Add(this.txtWeight);
            this.grpBmiCalculator.Location = new System.Drawing.Point(12, 12);
            this.grpBmiCalculator.Name = "grpBmiCalculator";
            this.grpBmiCalculator.Size = new System.Drawing.Size(322, 133);
            this.grpBmiCalculator.TabIndex = 21;
            this.grpBmiCalculator.TabStop = false;
            this.grpBmiCalculator.Text = "BMI Calculator";
            // 
            // listBMR
            // 
            this.listBMR.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBMR.ForeColor = System.Drawing.Color.Green;
            this.listBMR.FormattingEnabled = true;
            this.listBMR.ItemHeight = 14;
            this.listBMR.Location = new System.Drawing.Point(390, 43);
            this.listBMR.Name = "listBMR";
            this.listBMR.Size = new System.Drawing.Size(449, 158);
            this.listBMR.TabIndex = 22;
            // 
            // grpBmrCalculator
            // 
            this.grpBmrCalculator.Controls.Add(this.btnBMR);
            this.grpBmrCalculator.Controls.Add(this.txtAge);
            this.grpBmrCalculator.Controls.Add(this.lblAge);
            this.grpBmrCalculator.Controls.Add(this.grpActivityLevel);
            this.grpBmrCalculator.Controls.Add(this.grpGender);
            this.grpBmrCalculator.Controls.Add(this.listBMR);
            this.grpBmrCalculator.Location = new System.Drawing.Point(12, 447);
            this.grpBmrCalculator.Name = "grpBmrCalculator";
            this.grpBmrCalculator.Size = new System.Drawing.Size(873, 245);
            this.grpBmrCalculator.TabIndex = 23;
            this.grpBmrCalculator.TabStop = false;
            this.grpBmrCalculator.Text = "BMR Calculator";
            // 
            // btnBMR
            // 
            this.btnBMR.Location = new System.Drawing.Point(19, 165);
            this.btnBMR.Name = "btnBMR";
            this.btnBMR.Size = new System.Drawing.Size(133, 38);
            this.btnBMR.TabIndex = 24;
            this.btnBMR.Text = "Calculate BMR";
            this.btnBMR.UseVisualStyleBackColor = true;
            this.btnBMR.Click += new System.EventHandler(this.btnBMR_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(67, 131);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(85, 20);
            this.txtAge.TabIndex = 26;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(16, 132);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 25;
            this.lblAge.Text = "Age";
            // 
            // grpActivityLevel
            // 
            this.grpActivityLevel.Controls.Add(this.rbtnExtraActive);
            this.grpActivityLevel.Controls.Add(this.rbtnVeryActive);
            this.grpActivityLevel.Controls.Add(this.rbtnModeratelyActive);
            this.grpActivityLevel.Controls.Add(this.rbtnLightlyActive);
            this.grpActivityLevel.Controls.Add(this.rbtnSedentary);
            this.grpActivityLevel.Location = new System.Drawing.Point(158, 37);
            this.grpActivityLevel.Name = "grpActivityLevel";
            this.grpActivityLevel.Size = new System.Drawing.Size(226, 167);
            this.grpActivityLevel.TabIndex = 24;
            this.grpActivityLevel.TabStop = false;
            this.grpActivityLevel.Text = "Weekly activity level";
            // 
            // rbtnExtraActive
            // 
            this.rbtnExtraActive.AutoSize = true;
            this.rbtnExtraActive.Location = new System.Drawing.Point(15, 140);
            this.rbtnExtraActive.Name = "rbtnExtraActive";
            this.rbtnExtraActive.Size = new System.Drawing.Size(196, 17);
            this.rbtnExtraActive.TabIndex = 4;
            this.rbtnExtraActive.TabStop = true;
            this.rbtnExtraActive.Text = "Extra active (hard exercises or work)";
            this.rbtnExtraActive.UseVisualStyleBackColor = true;
            // 
            // rbtnVeryActive
            // 
            this.rbtnVeryActive.AutoSize = true;
            this.rbtnVeryActive.Location = new System.Drawing.Point(15, 110);
            this.rbtnVeryActive.Name = "rbtnVeryActive";
            this.rbtnVeryActive.Size = new System.Drawing.Size(141, 17);
            this.rbtnVeryActive.TabIndex = 3;
            this.rbtnVeryActive.TabStop = true;
            this.rbtnVeryActive.Text = "Very active (6 to 7 times)";
            this.rbtnVeryActive.UseVisualStyleBackColor = true;
            // 
            // rbtnModeratelyActive
            // 
            this.rbtnModeratelyActive.AutoSize = true;
            this.rbtnModeratelyActive.Location = new System.Drawing.Point(15, 80);
            this.rbtnModeratelyActive.Name = "rbtnModeratelyActive";
            this.rbtnModeratelyActive.Size = new System.Drawing.Size(172, 17);
            this.rbtnModeratelyActive.TabIndex = 2;
            this.rbtnModeratelyActive.TabStop = true;
            this.rbtnModeratelyActive.Text = "Moderately active (3 to 5 times)";
            this.rbtnModeratelyActive.UseVisualStyleBackColor = true;
            // 
            // rbtnLightlyActive
            // 
            this.rbtnLightlyActive.AutoSize = true;
            this.rbtnLightlyActive.Location = new System.Drawing.Point(15, 50);
            this.rbtnLightlyActive.Name = "rbtnLightlyActive";
            this.rbtnLightlyActive.Size = new System.Drawing.Size(150, 17);
            this.rbtnLightlyActive.TabIndex = 1;
            this.rbtnLightlyActive.TabStop = true;
            this.rbtnLightlyActive.Text = "Lightly active (1 to 3 times)";
            this.rbtnLightlyActive.UseVisualStyleBackColor = true;
            // 
            // rbtnSedentary
            // 
            this.rbtnSedentary.AutoSize = true;
            this.rbtnSedentary.Location = new System.Drawing.Point(15, 20);
            this.rbtnSedentary.Name = "rbtnSedentary";
            this.rbtnSedentary.Size = new System.Drawing.Size(169, 17);
            this.rbtnSedentary.TabIndex = 0;
            this.rbtnSedentary.TabStop = true;
            this.rbtnSedentary.Text = "Sedentary (little or no exercise)";
            this.rbtnSedentary.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbtnFemale);
            this.grpGender.Controls.Add(this.rbtnMale);
            this.grpGender.Location = new System.Drawing.Point(19, 37);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(133, 78);
            this.grpGender.TabIndex = 23;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(21, 43);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(21, 20);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 704);
            this.Controls.Add(this.grpBmrCalculator);
            this.Controls.Add(this.grpBmiCalculator);
            this.Controls.Add(this.btnSaving);
            this.Controls.Add(this.grpFutureValue);
            this.Controls.Add(this.grpSavingPlan);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpUnit);
            this.Controls.Add(this.btnBMI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.grpSavingPlan.ResumeLayout(false);
            this.grpSavingPlan.PerformLayout();
            this.grpFutureValue.ResumeLayout(false);
            this.grpFutureValue.PerformLayout();
            this.grpBmiCalculator.ResumeLayout(false);
            this.grpBmiCalculator.PerformLayout();
            this.grpBmrCalculator.ResumeLayout(false);
            this.grpBmrCalculator.PerformLayout();
            this.grpActivityLevel.ResumeLayout(false);
            this.grpActivityLevel.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtCmFt;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtInch;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label lblNormalBMI;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.RadioButton rbtnImperial;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label calcBMI;
        private System.Windows.Forms.Label calcWeightCat;
        private System.Windows.Forms.Label lblWeightCat;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblQuote1;
        private System.Windows.Forms.Label lblQuote2;
        private System.Windows.Forms.GroupBox grpSavingPlan;
        private System.Windows.Forms.GroupBox grpFutureValue;
        private System.Windows.Forms.Button btnSaving;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtMonthlyDeposit;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblMonthlyDeposit;
        private System.Windows.Forms.Label calcFinalBalance;
        private System.Windows.Forms.Label calcAmountPaid;
        private System.Windows.Forms.Label lblFinalBalance;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.GroupBox grpBmiCalculator;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.TextBox txtInitialDeposit;
        private System.Windows.Forms.Label lblInitialDeposit;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label calcTotalFees;
        private System.Windows.Forms.Label calcAmountEarned;
        private System.Windows.Forms.Label lblAmountEarned;
        private System.Windows.Forms.ListBox listBMR;
        private System.Windows.Forms.GroupBox grpBmrCalculator;
        private System.Windows.Forms.Button btnBMR;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.GroupBox grpActivityLevel;
        private System.Windows.Forms.RadioButton rbtnExtraActive;
        private System.Windows.Forms.RadioButton rbtnVeryActive;
        private System.Windows.Forms.RadioButton rbtnModeratelyActive;
        private System.Windows.Forms.RadioButton rbtnLightlyActive;
        private System.Windows.Forms.RadioButton rbtnSedentary;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
    }
}

