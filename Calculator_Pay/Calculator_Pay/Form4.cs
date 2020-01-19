using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator_Pay
{
    public partial class Form4 : Form
    {
        Color btnc = Color.FromArgb(8, 0, 0);
        Font font_button = new Font("Arial Black", 11, FontStyle.Regular);
        Color color = Color.FromArgb(248, 212, 136);
        Color bound_element = Color.FromArgb(179, 113, 34);
        ChargedForm f2 = null;
        PieceRateForm f3 = null;

        public Form4()
        {
            InitializeComponent();

            SetFontButtons();
            SetColorButtons();
            SetSettingsButton(ChargedFormPayButton);
            SetSettingsButton(PieceRateFormPayButton);
            SetSettingsButton(AboutProgramButton);
        }

        private void SetFontButtons()
        {
            ChargedFormPayButton.Font = font_button;
            PieceRateFormPayButton.Font = font_button;
            AboutProgramButton.Font = font_button;
        }

        private void SetColorButtons()
        {
            ChargedFormPayButton.BackColor = color;
            PieceRateFormPayButton.BackColor = color;
            AboutProgramButton.BackColor = color;

            PieceRateFormPayButton.ForeColor = btnc;
            ChargedFormPayButton.ForeColor = btnc;
            AboutProgramButton.ForeColor = btnc;
        }

        private void SetSettingsButton(Button button)
        {
            button.FlatAppearance.BorderSize = 2;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = bound_element;
        }

        private void ChargedFormPayButton_Click(object sender, EventArgs e)
        {
            if (FormIsNotOpened(f2))
            {
                f2 = new ChargedForm();
                f2.Show();
            }
        }

        private void PieceRateFormPayButton_Click(object sender, EventArgs e)
        {
            if (FormIsNotOpened(f3))
            {
                f3 = new PieceRateForm();
                f3.Show();
            }
        }

        private bool FormIsNotOpened(Form form)
        {
            if (form == null || form.IsDisposed)
                return true;
            return false;
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            about.ShowDialog();
        }
    }
}
