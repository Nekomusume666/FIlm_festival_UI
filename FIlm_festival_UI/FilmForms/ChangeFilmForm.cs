using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIlm_festival_UI
{
    public partial class ChangeFilmForm : Form
    {
        public static string NameFilmForm = "";
        public static string NominationFilmForm = "";
        public static int TicketPriceForm = 0;

        public ChangeFilmForm(string name, string nomination, int price)
        {
            InitializeComponent();
            NameFilmForm = name;
            NominationFilmForm = nomination;
            TicketPriceForm = price;
            FillData();
        }
        private void FillData()
        {
            textBox_name.Text = NameFilmForm;
            comboBox_nomination.SelectedIndex = NameFilmForm.Equals("Самый романтичный") ? 0 : 1;
            numericUpDown_cost.Value = TicketPriceForm;
        }


        private void ChangeFilmForm_Load(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                NameFilmForm = textBox_name.Text;
                NominationFilmForm = comboBox_nomination.SelectedItem as string;
                TicketPriceForm = (int)numericUpDown_cost.Value;

                Close();
            }
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                e.Cancel = true;
                errorProvider_name.SetError(textBox_name, "Введите название фильма!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_name.SetError(textBox_name, "");
            }
        }

        private void comboBox_nomination_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_nomination.Text))
            {
                e.Cancel = true;
                errorProvider_nomination.SetError(comboBox_nomination, "Выберите номинацию фильма!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_nomination.SetError(comboBox_nomination, "");
            }
        }

        private void numericUpDown_cost_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDown_cost.Value < 100 || numericUpDown_cost.Value > 1000)
            {
                e.Cancel = true;
                errorProvider_cost.SetError(numericUpDown_cost, "Цена должна быть в диапазоне от 100 до 1000!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_cost.SetError(numericUpDown_cost, "");
            }
        }

    }
}
