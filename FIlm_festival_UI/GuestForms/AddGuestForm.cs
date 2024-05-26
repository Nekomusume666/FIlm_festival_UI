using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIlm_festival_UI
{
    public partial class AddGuestForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        public static string NameGuestForm = "";
        public static string LastNameGuestForm = "";
        public static int SeatNumberGuestForm = 0;
        public static string EmailGuestForm = "";
        public static bool isVoted = false;

        public AddGuestForm()
        {
            InitializeComponent(); 
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                e.Cancel = true;
                errorProvider_name.SetError(textBox_name, "Введите имя гостя!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_name.SetError(textBox_name, "");
            }
        }

        private void textBox_surname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_surname.Text))
            {
                e.Cancel = true;
                errorProvider_surname.SetError(textBox_surname, "Введите фамилию гостя!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_surname.SetError(textBox_surname, "");
            }
        }

        private void textBox_city_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                e.Cancel = true;
                errorProvider_email.SetError(textBox_email, "Введите email гостя!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_email.SetError(textBox_email, "");
            }
        }

        private void numericUpDown_age_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown_nubmer.Value < 0 || numericUpDown_nubmer.Value > 1000)
            {
                e.Cancel = true;
                errorProvider_number.SetError(numericUpDown_nubmer, "Номер места должен быть в диапазоне от 0 до 1000!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_number.SetError(numericUpDown_nubmer, "");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                NameGuestForm = textBox_name.Text;
                LastNameGuestForm = textBox_surname.Text;
                EmailGuestForm = textBox_email.Text;
                SeatNumberGuestForm = (int)numericUpDown_nubmer.Value;
                isVoted = false;

                Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddParticipantForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
