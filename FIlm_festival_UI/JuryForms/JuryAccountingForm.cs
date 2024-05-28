using course_work_FestivalFilmov_Afonin;
using FIlm_festival_UI.GuestForms;
using FIlm_festival_UI.JuryForms;
using Newtonsoft.Json;
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
    public partial class JuryAccountingForm : Form
    {
        const string FileJury = "Jury.json";

        int numbersJury = 0;
        int countJury = 0;
        public JuryAccountingForm()
        {
            Task.Run(() => File.Open(FileJury, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }
        //запись в файл json
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        //чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync())
                ?? new List<T>());
            }
        }
        private void film_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btn_add_film_Click(object sender, EventArgs e)
        {
            AddJuryForm formJury = new AddJuryForm();
            formJury.ShowDialog();
            string nameJuryForm = AddJuryForm.NameJuryForm;
            string lastNameJuryForm = AddJuryForm.LastNameJuryForm;
            string postJuryForm = AddJuryForm.PostJuryForm;
            bool vote = false;
            Dictionary<string, int> dict = new Dictionary<string, int>();


            Jury newJury = new Jury(nameJuryForm, lastNameJuryForm, postJuryForm, vote, dict);

            if (!string.IsNullOrEmpty(nameJuryForm) &&
                !string.IsNullOrEmpty(lastNameJuryForm) &&
                !string.IsNullOrEmpty(postJuryForm))
            {
                var jurys = await ReadFromFile<Jury>(FileJury);

                if (!jurys.Contains(newJury))
                {
                    foreach (var twoJury in jurys)
                    {
                        if (twoJury.NameJury == nameJuryForm &&
                            twoJury.LastNameJury == lastNameJuryForm &&
                            twoJury.PostJury == postJuryForm)
                        {
                            MessageBox.Show($"Жюри {twoJury.NameJury} уже занесён в базу " +
                                $"Фестиваль фильмов. ", "Добавление жюри", 0,
                                MessageBoxIcon.Information);
                            return;
                        }
                    }

                    jurys.Add(newJury);
                    countJury = jurys.Count;
                    label_Count.Text = "Количество жюри: " + Convert.ToString(countJury);


                    await WriteToFile(jurys, FileJury);

                    dataGridView.Rows.Add(nameJuryForm, lastNameJuryForm, postJuryForm, "-");
                    MessageBox.Show($"Член жюри {nameJuryForm} успешно добавлен в базу " +
                           $"Фестиваль фильмов. ", "Добавление члена жюри", 0,
                           MessageBoxIcon.Information);
                    AddJuryForm.NameJuryForm = "";
                    AddJuryForm.LastNameJuryForm = "";
                    AddJuryForm.PostJuryForm = "";
                }
                else
                {
                    MessageBox.Show($"Этот член жюри был занесён в базу фестиваль фильмов ранее",
                        "Добавление жюри", 0,
                        MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private async void JuryAccountingForm_Load(object sender, EventArgs e)
        {

            if (File.Exists(FileJury))
            {
                var tableOfJury = await ReadFromFile<Jury>(FileJury);
                numbersJury = 0;
                countJury = tableOfJury.Count;
                label_Count.Text = "Количество жюри: " + Convert.ToString(countJury);
                if (tableOfJury != null)

                    foreach (var jurys in tableOfJury)
                    {
                        dataGridView.Rows.Add();
                        dataGridView.Rows[numbersJury].Cells[0].Value = jurys.NameJury;
                        dataGridView.Rows[numbersJury].Cells[1].Value = jurys.LastNameJury;
                        dataGridView.Rows[numbersJury].Cells[2].Value = jurys.PostJury;

                        if (jurys.isVoted) dataGridView.Rows[numbersJury].Cells[3].Value = "+";
                        else dataGridView.Rows[numbersJury].Cells[3].Value = "-";

                        numbersJury++;
                    }
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Нет ни одного фильма или вы не выбрали фильм для удаленя!",
                   "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
            int selectCount = dataGridView.SelectedRows[0].Index;

            if (selectCount >= 0 && dataGridView.SelectedRows.Count != 0)
            {
                var jurys = await ReadFromFile<Jury>(FileJury);
                //if (jurys.Count == 1)
                //{
                //    TextBoxFilterJury.Text = "";
                //    TextBoxFilterJury.Enabled = false;
                //    ComboBoxFilterJury.SelectedIndex = -1;
                //}
                string nameJury = dataGridView.Rows[selectCount].Cells[0].Value.ToString();
                string lastNameJury = dataGridView.Rows[selectCount].Cells[1].Value.ToString();
                string postJury = dataGridView.Rows[selectCount].Cells[2].Value.ToString();

                foreach (var twoJury in jurys)
                {
                    if (nameJury == twoJury.NameJury && lastNameJury == twoJury.LastNameJury
                        && postJury == twoJury.PostJury)
                    {
                        jurys.Remove(twoJury);
                        countJury = jurys.Count;
                        label_Count.Text = "Количество жюри: " + Convert.ToString(countJury);
                        dataGridView.Rows.Remove(dataGridView.Rows[selectCount]);
                        dataGridView.Refresh();
                        MessageBox.Show($"Член жюри {twoJury.NameJury}  удалён!", "Удаление одного члена жюри",
                            0, MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(jurys, FileJury);
            }
            else
            {
                MessageBox.Show("Нет ни одного члена жюри или вы не выбрали члена жюри для удаления!",
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        private void comboBox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            textBox_filter.Enabled = true;
        }

        private async void textBox_filter_Enter(object sender, EventArgs e)
        {
            var jurys = await ReadFromFile<Jury>(FileJury);
            countJury = jurys.Count;
            if (countJury == 0)
            {
                textBox_filter.Enabled = false;
                comboBox_filter.Text = "";
                MessageBox.Show("Нет ни одного члена жюри!", "Неудачная фильтрация", 0, MessageBoxIcon.Information);
                return;
            }
            await WriteToFile(jurys, FileJury);
        }

        private void textBox_filter_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_filter.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите поле для фильтрации!", "Внимание", 0, MessageBoxIcon.Information);
                return;
            }
            string searchValue = textBox_filter.Text;
            int columnIndex = comboBox_filter.SelectedIndex;
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString().Contains(searchValue))
                {
                    row.Visible = true;
                    hasVisibleRows = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
            if (hasVisibleRows)
            {
                dataGridView.Rows[0].Selected = true;
            }
            if (!hasVisibleRows && !string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show($"Полей с такими данными: {searchValue} - нет!", "Внимание", 0, MessageBoxIcon.Information);
            }
        }

        private async void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string surname = selectedRow.Cells[1].Value.ToString();
            string post = selectedRow.Cells[2].Value.ToString();

            ChangeJuryForm juryFestival = new ChangeJuryForm(name, surname, post);
            juryFestival.ShowDialog();

            string modName = ChangeJuryForm.NameJuryForm;
            string modSurname = ChangeJuryForm.LastNameJuryForm;
            string modPost = ChangeJuryForm.PostJuryForm;
            bool vote;
            if (selectedRow.Cells[4].Value.Equals("+")) vote = true;
            else vote = false;
            Dictionary<string, int> dict = new Dictionary<string, int>();

            Jury modifiedJury = new Jury(modName,
                modSurname, modPost, vote, dict);

            var jurys = await ReadFromFile<Jury>(FileJury);

            foreach (var j in jurys)
            {
                if (name == j.NameJury && surname == j.LastNameJury &&
                     post == j.PostJury)
                {
                    if (!(modName.Equals(name) && modSurname.Equals(surname) && modPost.Equals(post)))
                    {
                        jurys.Remove(j);
                        jurys.Add(modifiedJury);
                        selectedRow.Cells[0].Value = modName;
                        selectedRow.Cells[1].Value = modSurname;
                        selectedRow.Cells[2].Value = modPost;
                        dataGridView.Refresh();
                        MessageBox.Show($"Жюри {j.NameJury} изменён!", "Изменение жюри", 0,
                            MessageBoxIcon.Information);
                        ChangeJuryForm.NameJuryForm = "";
                        ChangeJuryForm.LastNameJuryForm = "";
                        ChangeJuryForm.PostJuryForm = "";
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Жюри {j.NameJury} не был изменён, внесите изменения!", "Неудачное изменение жюри", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(jurys, FileJury);
        }

        private async void btn_voting_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string curValue = dataGridView.CurrentRow.Cells[0].Value.ToString();

                var jurys = await ReadFromFile<Jury>(FileJury);

                foreach (var jury in jurys)
                {
                    if (jury.NameJury.Equals(curValue))
                    {
                        VotingJuryForm votingGuestForm = new VotingJuryForm(jury);
                        votingGuestForm.ShowDialog();

                        if (jury.isVoted) dataGridView.CurrentRow.Cells[3].Value = "+";
                        else dataGridView.CurrentRow.Cells[3].Value = "-";
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать гостя!");
            }
        }

        private void nav_bar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
