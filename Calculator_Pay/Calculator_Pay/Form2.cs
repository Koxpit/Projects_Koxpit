﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Calculator_Pay
{
    public partial class ChargedForm : Form
    {
        Color color = Color.FromArgb(248, 212, 136);
        Color header = Color.FromArgb(132, 0, 6);
        Color text = Color.FromArgb(128, 24, 0);
        Color btnc = Color.FromArgb(8, 0, 0);
        Color bound_element = Color.FromArgb(179, 113, 34);

        Font font_h = new Font("Arial Narrow", 14, FontStyle.Regular);
        Font font_header = new Font("Arial Black", 14, FontStyle.Underline);
        Font font_p = new Font("Arial Narrow", 12, FontStyle.Regular);
        Font font_p_gp = new Font("Arial Narrow", 12, FontStyle.Underline);
        Font font_button = new Font("Arial Black", 11, FontStyle.Regular);

        public ChargedForm()
        {
            InitializeComponent();

            SetFontComponents();
            SetColorComponents();
            SetSettingsButton(CalculateButton);
            SetSettingsButton(PrintButton);
            SetSettingsButton(ExportToExcelButton);
            SetSettingsButton(CertificateButton);
        }

        private double allDays = 0, workHours = 0, workDays = 0;
        private double allPay = 0, hPay = 0, dPay = 0;
        private double deducs = 0, ndfl = 0;
        private string print = "";
        public double premia = 0;

        private void SetFontComponents()
        {
            WorkTimeLabel.Font = font_p;
            WorkedTimeLabel.Font = font_p;
            SalaryLabel.Font = font_p;
            NorthSuppleLabel.Font = font_p;
            SuppleExistOrNotLabel.Font = font_p;
            RegionalSuppleLabel.Font = font_p;
            BonuseLabel.Font = font_p;
            PayOnHandLabel.Font = font_p;
            DeducExistOrNotLabel.Font = font_p;
            DeducOnChildrenLabel.Font = font_p;
            AvailablilityDisabledChildsLabel.Font = font_p;
            NumberOfChildsLabel.Font = font_p;

            CalculateButton.Font = font_button;
            PrintButton.Font = font_button;
            ExportToExcelButton.Font = font_button;
            CertificateButton.Font = font_button;

            IsHoursPayRadioButton.Font = font_p_gp;
            IsDaysPayRadioButton.Font = font_p_gp;
            IsSalaryRadioButton.Font = font_p_gp;

            ExistBonuseCheckBox.Font = font_p;

            DeducsGroupBox.Font = font_p_gp;
            SupplementsGroupBox.Font = font_p_gp;
        }

        private void SetColorComponents()
        {
            DeducsGroupBox.ForeColor = text;
            SupplementsGroupBox.ForeColor = text;

            CalculateButton.ForeColor = btnc;
            PrintButton.ForeColor = btnc;
            ExportToExcelButton.ForeColor = btnc;
            CertificateButton.ForeColor = btnc;

            IsHoursPayRadioButton.ForeColor = text;
            IsDaysPayRadioButton.ForeColor = text;
            IsSalaryRadioButton.ForeColor = text;

            WorkTimeLabel.ForeColor = text;
            WorkedTimeLabel.ForeColor = text;
            SalaryLabel.ForeColor = text;
            NorthSuppleLabel.ForeColor = text;
            SuppleExistOrNotLabel.ForeColor = text;
            RegionalSuppleLabel.ForeColor = text;
            BonuseLabel.ForeColor = text;
            PayOnHandLabel.ForeColor = text;
            DeducExistOrNotLabel.ForeColor = text;
            DeducOnChildrenLabel.ForeColor = text;
            AvailablilityDisabledChildsLabel.ForeColor = text;
            NumberOfChildsLabel.ForeColor = text;

            ExistBonuseCheckBox.ForeColor = text;

            WorkTimeTextBox.BackColor = color;
            WorkedTimeTextBox.BackColor = color;
            SalaryTextBox.BackColor = color;
            BonuseTextBox.BackColor = color;
            PayOnHandTextBox.BackColor = color;

            CalculateButton.BackColor = color;
            PrintButton.BackColor = color;
            ExportToExcelButton.BackColor = color;
            CertificateButton.BackColor = color;
        }

        private void SetSettingsButton(Button button)
        {
            button.FlatAppearance.BorderSize = 1;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = bound_element;
        }

        // Вывод результата
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (WorkTimeTextBox.Text == "")
                    WorkTimeTextBox.Text = 0.ToString();
                if (WorkedTimeTextBox.Text == "")
                    WorkedTimeTextBox.Text = 0.ToString();
                if (SalaryTextBox.Text == "")
                    SalaryTextBox.Text = 0.ToString();
                if (BonuseTextBox.Text == "")
                    BonuseTextBox.Text = 0.ToString();

                CalcNDFL();

                double result = CalcPayOnHand();

                if (result < 0)
                    result = 0;

                PayOnHandTextBox.Text = result.ToString("N2");

                ResetVarialbes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Расчет НДФЛ 13%
        private double CalcNDFL()
        {
            ndfl = (CalcDefaultPay() - CalcDeductions() + CalcBonuses()) * 0.13;

            if (ndfl <= 0)
                ndfl = 0;

            return ndfl;
        }

        // Зарплата на руки
        private double CalcPayOnHand()
        {
            return CalcDefaultPay() + CalcBonuses() - ndfl;
        }

        // Полная зарплата без вычетов и надбавок
        public double CalcDefaultPay()
        {
            double defPay = 0;

            if (IsHoursPayRadioButton.Checked == true)
            {
                hPay = Convert.ToDouble(WorkTimeTextBox.Text);
                workHours = Convert.ToInt32(WorkedTimeTextBox.Text);
                defPay = hPay * workHours;
            }

            if (IsDaysPayRadioButton.Checked == true)
            {
                dPay = Convert.ToDouble(WorkTimeTextBox.Text);
                workDays = Convert.ToInt32(WorkedTimeTextBox.Text);
                defPay = dPay * workDays;
            }

            if (IsSalaryRadioButton.Checked == true)
            {
                allPay = Convert.ToDouble(SalaryTextBox.Text);
                allDays = Convert.ToInt32(WorkTimeTextBox.Text);
                workDays = Convert.ToInt32(WorkedTimeTextBox.Text);

                if (workDays == 0)
                    defPay = 0;
                else
                    defPay = allDays / workDays * allPay;
            }

            if (ExistBonuseCheckBox.Checked == true)
            {
                premia = Convert.ToDouble(BonuseTextBox.Text);
                defPay += Convert.ToDouble(BonuseTextBox.Text);
            }

            return defPay;
        }

        // Расчет вычетов
        public double CalcDeductions()
        {
            int healthyChilds = 0, disabledChilds = 0;

            if (DeducExistRadioButton.Checked == true)
            {
                healthyChilds = GetNumOfHealthyChilds();

                if (IsDisabledChildsCheckBox.Checked == true)
                {
                    disabledChilds = GetNumOfDisabledChilds();
                    healthyChilds -= disabledChilds;
                    deducs += disabledChilds * 3000;
                }

                if (healthyChilds >= 3)
                {
                    deducs += 1400 * 2;
                    healthyChilds -= 2;
                    deducs += healthyChilds * 3000;
                }
                else
                    deducs += healthyChilds * 1400;
            }

            return deducs;
        }

        private int GetNumOfHealthyChilds()
        {
            return Convert.ToInt32(ChildsNumericUpDown.Value);
        }

        private int GetNumOfDisabledChilds()
        {
            return Convert.ToInt32(DisabledChildsNumericUpDown.Value);
        }

        // Расчет всех надбавок(бонусов)
        private double CalcBonuses()
        {
            if (SupplementedRadioButton.Checked == true)
                return CalcNorthSupple() + CalcRegionSupple();

            return 0;
        }

        // Северные надбавки
        public double CalcNorthSupple()
        {
            double northSupple = 0;
            double rateNSupple = Convert.ToDouble(NorthSuppleRateNumericUpDown.Value);

            if (rateNSupple != 0)
            {
                northSupple = (CalcDefaultPay() - premia) * rateNSupple;
                return northSupple - (CalcDefaultPay() + premia);
            }

            return 0;
        }

        // Расчет районного коэффициента
        public double CalcRegionSupple()
        {
            double regionSupple = 0;
            double rateRSupple = Convert.ToDouble(RegionalSuppleRateNumericUpDown.Value);

            if (rateRSupple != 0)
                return regionSupple = CalcDefaultPay() * (rateRSupple / 100);

            return 0;
        }

        private void ResetVarialbes()
        {
            allDays = 0; workDays = 0; workHours = 0;
            dPay = 0; hPay = 0; allPay = 0;
            premia = 0; deducs = 0; ndfl = 0;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreatePrintString();
                PrintWork printToDoc = new PrintWork(print);
                printToDoc.PrintToDocument();
                deducs = 0;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreatePrintString()
        {
            print ="\n\n\t\t\t\tВаша заработная плата\n\n" +
                    "В соответствии с проведенными расчетами," +
                    "ваша заработная плата равна: " +
                    PayOnHandTextBox.Text
                    + "руб.\n\n\tНДФЛ: "+
                    CalcNDFL().ToString("N2")
                    + "руб.\n\tНадбваки: "+
                    CalcBonuses().ToString("N2")
                    + "руб.\n\tВычеты: "+
                    CalcDeductions().ToString("N2")
                    + "руб.\n\tПремия: "+
                    BonuseTextBox.Text+"руб.";
        }

        // Сохранение данных в Excel
        private void ExportToExcelButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "Файлы Excel |*.xlsx"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application app = new Excel.Application();
                    app.Workbooks.Open(dialog.FileName);
                    Excel.Workbook book = app.ActiveWorkbook;
                    for (int i = 1; i <= book.Worksheets.Count; i++)
                    {
                        Excel.Worksheet sheet = (Excel.Worksheet)book.Worksheets[i];
                        sheet.Cells[1, 1] = "Зарплата";
                        sheet.Cells[1, 2] = PayOnHandTextBox.Text;
                        sheet.Cells[2, 1] = "НДФЛ";
                        sheet.Cells[2, 2] = CalcNDFL().ToString("N2");
                        sheet.Cells[3, 1] = "Надбавки";
                        sheet.Cells[3, 2] = CalcBonuses().ToString("N2");
                        sheet.Cells[4, 1] = "Вычеты";
                        sheet.Cells[4, 2] = CalcDeductions().ToString("N2");
                        sheet.Cells[5, 1] = "Премия";
                        sheet.Cells[5, 2] = BonuseTextBox.Text;
                    }

                    deducs = 0;

                    book.Save();
                    app.Quit();

                    MessageBox.Show("Сохранение завершено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Открытие файл справки
        private void CertificateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path =
                    System.IO
                    .Directory.GetParent(System.IO.Directory.GetCurrentDirectory())
                    .Parent.FullName;
                System.Diagnostics
                    .Process.Start(path + @"\Calculator_Pay_Help\CalculatorPay_Help.chm");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Запуск окна "О программе"
        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            about.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DeducsGroupBox.Height = 50;
            SupplementsGroupBox.Height = 50;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (IsSalaryRadioButton.Checked == true)
            {
                SalaryTextBox.Visible = true;
                SalaryLabel.Visible = true;
                WorkTimeLabel.Text = "Кол-во рабочих дней:";
                WorkedTimeLabel.Text = "Количество отработанных дней:";
            }
        }

        private void IsDaysPayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDaysPayRadioButton.Checked == true)
            {
                SalaryTextBox.Visible = false;
                SalaryLabel.Visible = false;
                WorkTimeLabel.Text = "Кол-во рабочих дней:";
                WorkedTimeLabel.Text = "Количество отработанных дней:";
            }
        }

        private void IsHoursPayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (IsHoursPayRadioButton.Checked == true)
            {
                SalaryTextBox.Visible = false;
                SalaryLabel.Visible = false;
                WorkTimeLabel.Text = "Часовая ставка:";
                WorkedTimeLabel.Text = "Кол-во отработанных часов:";
            }
        }

        private void DeducExistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DeducExistRadioButton.Checked == true)
            {
                DeducExist(true);
                DeducsGroupBox.Height = 150;
            }
            else
            {
                DeducExist(false);
                DeducsGroupBox.Height = 50;
            }
        }

        private void DeducExist(bool isExist)
        {
            DeducOnChildrenLabel.Visible = isExist;
            AvailablilityDisabledChildsLabel.Visible = isExist;
            ChildsNumericUpDown.Visible = isExist;
            IsDisabledChildsCheckBox.Visible = isExist;
        }

        private void SupplementedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SupplementedRadioButton.Checked == true)
            {
                SuppleExist(true);
                SupplementsGroupBox.Height = 150;
            }
            else
            {
                SuppleExist(false);
                SupplementsGroupBox.Height = 50;
            }
        }

        private void SuppleExist(bool isExist)
        {
            NorthSuppleLabel.Visible = isExist;
            RegionalSuppleLabel.Visible = isExist;
            NorthSuppleRateNumericUpDown.Visible = isExist;
            RegionalSuppleRateNumericUpDown.Visible = isExist;
        }

        private void IsDisabledChildsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDisabledChildsCheckBox.Checked == true)
                DisabledChildsExist(true);
            else
                DisabledChildsExist(false);
        }

        private void DisabledChildsExist(bool isExist)
        {
            NumberOfChildsLabel.Visible = isExist;
            DisabledChildsNumericUpDown.Visible = isExist;
        }

        private void ExistBonuseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ExistBonuseCheckBox.Checked == true)
                BonuseExist(true);
            else
                BonuseExist(false);
        }

        private void BonuseExist(bool isExist)
        {
            BonuseTextBox.Visible = isExist;
            BonuseLabel.Visible = isExist;
        }
    }
}
