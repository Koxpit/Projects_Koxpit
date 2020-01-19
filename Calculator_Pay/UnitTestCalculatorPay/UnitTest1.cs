using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_Pay;

namespace UnitTestCalculatorPay
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodDefaultPay_1()
        {
            ChargedForm f2 = new ChargedForm();
            double hPay = 120, workHours = 10;
            double test = hPay * workHours;
            f2.WorkTimeTextBox.Text = hPay.ToString();
            f2.WorkedTimeTextBox.Text = workHours.ToString();
            f2.IsHoursPayRadioButton.Checked = true;

            double result = f2.CalcDefaultPay();

            Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void TestMethodDefaultPay_1_Not()
        {
            ChargedForm f2 = new ChargedForm();
            double hPay = 120, workHours = 10;
            double test = 3000;
            f2.WorkTimeTextBox.Text = hPay.ToString();
            f2.WorkedTimeTextBox.Text = workHours.ToString();
            f2.IsHoursPayRadioButton.Checked = true;

            double result = f2.CalcDefaultPay();

            Assert.AreNotEqual(test, result);
        }

        [TestMethod]
        public void TestMethodDefaultPay_2()
        {
            ChargedForm f2 = new ChargedForm();
            double dPay = 1200, workDays = 30;
            double test = dPay * workDays;
            f2.WorkTimeTextBox.Text = dPay.ToString();
            f2.WorkedTimeTextBox.Text = workDays.ToString();
            f2.IsDaysPayRadioButton.Checked = true;

            double result = f2.CalcDefaultPay();

            Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void TestMethodDefaultPay_2_Not()
        {
            ChargedForm f2 = new ChargedForm();
            double dPay = 1200, workDays = 30;
            double test = 100;
            f2.WorkTimeTextBox.Text = dPay.ToString();
            f2.WorkedTimeTextBox.Text = workDays.ToString();
            f2.IsDaysPayRadioButton.Checked = true;

            double result = f2.CalcDefaultPay();

            Assert.AreNotEqual(test, result);
        }

        [TestMethod]
        public void TestMethodDefaultPay_3()
        {
            ChargedForm f2 = new ChargedForm();
            double allPay = 2000, allDays = 30, workDays = 15;
            double test = allDays / workDays * allPay;
            f2.WorkTimeTextBox.Text = allDays.ToString();
            f2.WorkedTimeTextBox.Text = workDays.ToString();
            f2.SalaryTextBox.Text = allPay.ToString();
            f2.IsSalaryRadioButton.Checked = true;

            double result = f2.CalcDefaultPay();

            Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void TestMethodDefaultPay_3_Not()
        {
            ChargedForm f2 = new ChargedForm();
            double allPay = 2000, allDays = 30, workDays = 15;
            double test = 2000;
            f2.WorkTimeTextBox.Text = allDays.ToString();
            f2.WorkedTimeTextBox.Text = workDays.ToString();
            f2.SalaryTextBox.Text = allPay.ToString();
            f2.IsSalaryRadioButton.Checked = true;

            double result = f2.CalcDefaultPay();

            Assert.AreNotEqual(test, result);
        }

        [TestMethod]
        public void TestMethodDefaultPay_Premia()
        {
            ChargedForm f2 = new ChargedForm();
            double test = 2000;
            f2.ExistBonuseCheckBox.Checked = true;
            f2.BonuseTextBox.Text = 2000.ToString();
            f2.IsHoursPayRadioButton.Checked = false;
            f2.IsDaysPayRadioButton.Checked = false;
            f2.IsSalaryRadioButton.Checked = false;

            double result = f2.CalcDefaultPay();

            Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void TestMethodDefaultPay_Premia_Not()
        {
            ChargedForm f2 = new ChargedForm();
            double test = 200;
            f2.ExistBonuseCheckBox.Checked = true;
            f2.BonuseTextBox.Text = 2000.ToString();
            f2.IsHoursPayRadioButton.Checked = false;
            f2.IsDaysPayRadioButton.Checked = false;
            f2.IsSalaryRadioButton.Checked = false;

            double result = f2.CalcDefaultPay();

            Assert.AreNotEqual(test, result);
        }

        [TestMethod]
        public void TestMethodDeductions()
        {
            ChargedForm f2 = new ChargedForm();
            f2.ChildsNumericUpDown.Value = 4;
            f2.DisabledChildsNumericUpDown.Value = 1;
            double test = 8800;
            f2.DeducExistRadioButton.Checked = true;
            f2.IsDisabledChildsCheckBox.Checked = true;

            double result = f2.CalcDeductions();

            Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void TestMethodDeductions_Not()
        {
            ChargedForm f2 = new ChargedForm();
            f2.ChildsNumericUpDown.Value = 4;
            f2.DisabledChildsNumericUpDown.Value = 1;
            double test = 100;
            f2.DeducExistRadioButton.Checked = true;
            f2.IsDisabledChildsCheckBox.Checked = true;

            double result = f2.CalcDeductions();

            Assert.AreNotEqual(test, result);
        }

        [TestMethod]
        public void TestMethodSnd()
        {
            ChargedForm f2 = new ChargedForm();
            double dPay = 1200, workDays = 30, test = 8550;
            f2.WorkTimeTextBox.Text = dPay.ToString();
            f2.WorkedTimeTextBox.Text = workDays.ToString();
            f2.IsDaysPayRadioButton.Checked = true;
            f2.NorthSuppleRateNumericUpDown.Value = 1.25M;
            f2.Premia = 200;

            double result = f2.CalcNorthSupple();

            Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void TestMethodSnd_Not()
        {
            ChargedForm f2 = new ChargedForm();
            double dPay = 1200, workDays = 30, test = 50;
            f2.WorkTimeTextBox.Text = dPay.ToString();
            f2.WorkedTimeTextBox.Text = workDays.ToString();
            f2.IsDaysPayRadioButton.Checked = true;
            f2.NorthSuppleRateNumericUpDown.Value = 1.25M;
            f2.Premia = 200;

            double result = f2.CalcNorthSupple();

            Assert.AreNotEqual(test, result);
        }

        [TestMethod]
        public void TestMethodRko()
        {
            ChargedForm f2 = new ChargedForm();
            double dPay = 1200, workDays = 30, test = 9000;
            f2.WorkTimeTextBox.Text = dPay.ToString();
            f2.WorkedTimeTextBox.Text = workDays.ToString();
            f2.IsDaysPayRadioButton.Checked = true;
            f2.RegionalSuppleRateNumericUpDown.Value = 25;

            double result = f2.CalcRegionSupple();

            Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void TestMethodRko_Not()
        {
            ChargedForm f2 = new ChargedForm();
            double dPay = 1200, workDays = 30, test = 90;
            f2.WorkTimeTextBox.Text = dPay.ToString();
            f2.WorkedTimeTextBox.Text = workDays.ToString();
            f2.IsDaysPayRadioButton.Checked = true;
            f2.RegionalSuppleRateNumericUpDown.Value = 25;

            double result = f2.CalcRegionSupple();

            Assert.AreNotEqual(test, result);
        }
    }
}
