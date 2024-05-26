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
    public partial class ChangeJuryForm : Form
    {
        public static string NameJuryForm = "";
        public static string LastNameJuryForm = "";
        public static string PostJuryForm = "";
        public ChangeJuryForm(string name, string surname, string post)
        {
            InitializeComponent();
            NameJuryForm = name;
            LastNameJuryForm = surname;
            PostJuryForm = post;
            fillData();
        }

        private void fillData()
        {
            textBox_name.Text = NameJuryForm;
            textBox_surname.Text = LastNameJuryForm;
            comboBox_post.SelectedItem = PostJuryForm;
        }

        private void ChangeJuryFilm_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                NameJuryForm = textBox_name.Text;
                LastNameJuryForm = textBox_surname.Text;
                PostJuryForm = comboBox_post.SelectedItem as string;

                Close();
            }
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                e.Cancel = true;
                errorProvider_name.SetError(textBox_name, "Введите имя участника!");
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
                errorProvider_surname.SetError(textBox_surname, "Введите фамилию участника!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_surname.SetError(textBox_surname, "");
            }
        }

        private void comboBox_post_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_post.Text))
            {
                e.Cancel = true;
                errorProvider_post.SetError(comboBox_post, "Выберите номинацию фильма!");
            }
            else
            {
                e.Cancel = false;
                errorProvider_post.SetError(comboBox_post, "");
            }
        }
    }
}
