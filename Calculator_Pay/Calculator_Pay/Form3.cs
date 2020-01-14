using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Calculator_Pay
{
    public partial class PieceRateForm : Form
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

        public PieceRateForm()
        {
            InitializeComponent();

            SetFontComponents();
            SetColorComponents();
            SetSettingsButton(CalculateButton);
            SetSettingsButton(PrintButton);
            SetSettingsButton(ExportToExcelButton);
            SetSettingsButton(CertificateButton);
        }
        
        private double allTime = 0, workTime = 0;
        private double ops = 0;
        private double norma = 0;
        private double procent = 0;
        private double tarif = 0;
        private string print = "";

        private void SetFontComponents()
        {
            CalculateButton.Font = font_button;
            PrintButton.Font = font_button;
            ExportToExcelButton.Font = font_button;
            CertificateButton.Font = font_button;

            ExistBonuseCheckBox.Font = font_p;

            label1.Font = font_p;
            label2.Font = font_p;
            label3.Font = font_p;
            PayOnHandLabel.Font = font_p;
            BonuseLabel.Font = font_p;
            label6.Font = font_p;
            label7.Font = font_p;

            StakeGroupBox.Font = font_p_gp;
            FormOfPayGroupBox.Font = font_p_gp;
        }

        private void SetColorComponents()
        {
            StakeGroupBox.ForeColor = text;
            FormOfPayGroupBox.ForeColor = text;

            label1.ForeColor = text;
            label2.ForeColor = text;
            label3.ForeColor = text;
            PayOnHandLabel.ForeColor = text;
            BonuseLabel.ForeColor = text;
            label6.ForeColor = text;
            label7.ForeColor = text;

            CalculateButton.ForeColor = btnc;
            PrintButton.ForeColor = btnc;
            ExportToExcelButton.ForeColor = btnc;
            CertificateButton.ForeColor = btnc;

            ExistBonuseCheckBox.ForeColor = text;

            textBox1.BackColor = color;
            textBox2.BackColor = color;
            textBox3.BackColor = color;
            PayOnHandTextBox.BackColor = color;
            BonuseTextBox.BackColor = color;
            textBox6.BackColor = color;
            textBox7.BackColor = color;

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

        // Расчет полной оплаты труда
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double result = 0;
                SetToNullTextBoxesIfEmpty();

                if (IsIndirectFormRadioButton.Checked == true
                    || IsDirectFormRadioButton.Checked == true
                    || ProgressFormRadioButton.Checked == true)
                {
                    tarif = Convert.ToDouble(textBox2.Text);
                    ops = Convert.ToDouble(textBox3.Text);
                    norma = Convert.ToDouble(textBox1.Text);

                    if (IsIndirectFormRadioButton.Checked == true)
                        result = CalcIndirectForm();

                    if (IsDirectFormRadioButton.Checked == true)
                        result = CalcTarif() * ops;

                    if (ProgressFormRadioButton.Checked == true)
                        result = CalcTarif() * ops +
                            + Convert.ToInt32(textBox6.Text) * Convert.ToDouble(textBox7.Text);
                }

                if (IsAccordFormRadioButton.Checked == true)
                    result = CalcAccordForm();

                if (ExistBonuseCheckBox.Checked == true)
                    result += Convert.ToDouble(BonuseTextBox.Text);

                result -= result * 0.13;
                if (result < 0)
                    result = 0;

                PayOnHandTextBox.Text = result.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetToNullTextBoxesIfEmpty()
        {
            if (textBox1.Text == "")
                textBox1.Text = 0.ToString();
            if (textBox2.Text == "")
                textBox2.Text = 0.ToString();
            if (textBox3.Text == "")
                textBox3.Text = 0.ToString();
            if (BonuseTextBox.Text == "")
                BonuseTextBox.Text = 0.ToString();
            if (textBox6.Text == "")
                textBox6.Text = 0.ToString();
            if (textBox7.Text == "")
                textBox7.Text = 0.ToString();
        }

        private double CalcAccordForm()
        {
            tarif = Convert.ToDouble(textBox1.Text);
            allTime = Convert.ToDouble(textBox2.Text);
            workTime = Convert.ToDouble(textBox3.Text);
            if (allTime * workTime == 0)
                return 0;
            return tarif / allTime * workTime;
        }

        private double CalcIndirectForm()
        {
            procent = Convert.ToDouble(textBox6.Text);

            if (procent < 0 || procent > 100)
                procent = 0.00;

            return CalcTarif() * ops * (procent / 100);
        }

        private double CalcTarif()
        {
            if (IsHoursStakeRadioButton.Checked == true)
                tarif = HoursPay();
            if (IsDaysStakeRadioButton.Checked == true)
                tarif = DaysPay();

            return tarif;
        }

        // Расчет оплаты по часовой ставке
        public double HoursPay()
        {
            return tarif * (norma / 60);
        }

        // Расчет оплаты по дневной ставке
        public double DaysPay()
        {
            if (norma == 0)
                return 0;
            return tarif / norma;
        }

        // Печать
        private async void button2_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Print());
        }

        private void Print()
        {
            try
            {
                CreatePrintString();
                PrintWork printToDoc = new PrintWork(print);
                printToDoc.PrintToDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreatePrintString()
        {
            double ndfl = Convert.ToDouble(PayOnHandTextBox.Text) * 0.13;
            print = "\n\n\t\t\tВаша заработная плата\n\n" +
                "В соответствии с проведенными расчетами, ваша заработная плата равна "
                +PayOnHandTextBox.Text + "руб.\n"
                +"НДФЛ: " + ndfl.ToString("N2") + "руб.\n"
                +"Надбавки: нет.\n"
                +"Вычеты: нет.\n"
                +"Премия: " + BonuseTextBox.Text + "руб.";
        }

        // Вывод окна "О программе"
        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            about.ShowDialog();
        }

        // Сохранение данных в Excel
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                double ndfl = Convert.ToDouble(PayOnHandTextBox.Text)*0.13;

                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter="Файлы Excel |*.xlsx"
                };

                if (dialog.ShowDialog() == DialogResult.Cancel)
                    return;

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
                        sheet.Cells[2, 2] = ndfl.ToString("N2");
                        sheet.Cells[3, 1] = "Надбавки";
                        sheet.Cells[3, 2] = 0.ToString("N2");
                        sheet.Cells[4, 1] = "Вычеты";
                        sheet.Cells[4, 2] = 0.ToString("N2");
                        sheet.Cells[5, 1] = "Премия";
                        sheet.Cells[5, 2] = BonuseTextBox.Text;
                    }
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string path = System.IO
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

        private void Form3_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(label1, "Кол-во времени/работы на одну операцию");
            toolTip.SetToolTip(label2, "Ставка за одну операцию");
            toolTip.SetToolTip(label3, "Месячное кол-во операций");
            toolTip.SetToolTip(label6, "Кол-во работы сверх нормы");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ExistBonuseCheckBox.Checked == true)
                BonuseExist(true);
            else
                BonuseExist(false);
        }

        private void BonuseExist(bool isExist)
        {
            BonuseTextBox.Visible = isExist;
            BonuseLabel.Visible = isExist;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(IsDirectFormRadioButton.Checked == true)
            {
                ResetSettings();
                textBox6.Visible = false;
                textBox7.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label1.Text = "Норматив:";
                label2.Text = "Ставка:";
                label3.Text = "Количество:";
                toolTip.SetToolTip(label1, "Кол-во времени/работы на одну операцию");
                toolTip.SetToolTip(label2, "Ставка за одну операцию");
                toolTip.SetToolTip(label3, "Месячное кол-во операций");
            }
        }

        private void ResetSettings()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox7.Clear();
            textBox6.Clear();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(ProgressFormRadioButton.Checked==true)
            {
                ResetSettings();
                textBox6.Visible = true;
                textBox7.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label1.Text = "Норматив:";
                label2.Text = "Ставка:";
                label3.Text = "Количество:";
                label6.Text = "Сверх нормы:";
                label7.Text = "Повышенная ставка:";
                toolTip.SetToolTip(label1, "Кол-во времени/работы на одну операцию");
                toolTip.SetToolTip(label2, "Ставка за одну операцию");
                toolTip.SetToolTip(label3, "Месячное кол-во операций");
                toolTip.SetToolTip(label6, "Кол-во работы сверх нормы");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(IsIndirectFormRadioButton.Checked==true)
            {
                ResetSettings();
                label6.Visible = true;
                textBox6.Visible = true;
                label7.Visible = false;
                textBox7.Visible = false;
                label1.Text = "Норматив:";
                label2.Text = "Ставка:";
                label3.Text = "Количество:";
                label6.Text = "Процент:";
                toolTip.SetToolTip(label1, "Кол-во времени/работы на одну операцию");
                toolTip.SetToolTip(label2, "Ставка за одну операцию");
                toolTip.SetToolTip(label3, "Месячное кол-во операций");
                toolTip.SetToolTip(label6, "Процент от суммы всей работы");
            }
        }

        private void IsDaysStakeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (IsAccordFormRadioButton.Checked==true)
            {
                ResetSettings();
                label6.Visible = false;
                label1.Text = "Бюджет:";
                label2.Text = "Время на работу:";
                label3.Text = "Отработанное время:";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox6.Visible = false;
                textBox7.Visible = false;
                label7.Visible = false;
                toolTip.SetToolTip(label1, "");
                toolTip.SetToolTip(label2, "");
                toolTip.SetToolTip(label3, "");
            }
        }
    }
}
