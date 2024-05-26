using course_work_FestivalFilmov_Afonin;
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
    public partial class FIlmАccountingForm : Form
    {
        const string FileFilm = "Films.json";

        int numbersFilm = 0;
        int countFilm = 0;

        public FIlmАccountingForm()
        {
            Task.Run(() => File.Open(FileFilm, FileMode.OpenOrCreate).Close());
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

        private async void FIlmАccountingForm_Load(object sender, EventArgs e)
        {
            film_dataGridView.AllowUserToAddRows = false;
            if (File.Exists(FileFilm))
            {
                var tableOfFilms = await ReadFromFile<Film>(FileFilm);
                numbersFilm = 0;
                countFilm = tableOfFilms.Count;
                label_CountOfFilms.Text = "Количество фильмов: " + Convert.ToString(countFilm);

                if (tableOfFilms != null)
                    foreach (var film in tableOfFilms)
                    {
                        film_dataGridView.Rows.Add();
                        film_dataGridView.Rows[numbersFilm].Cells[0].Value = film.NameFilm;
                        film_dataGridView.Rows[numbersFilm].Cells[1].Value = film.NominationFilm;
                        film_dataGridView.Rows[numbersFilm].Cells[2].Value = film.TicketPrice;
                        film_dataGridView.Rows[numbersFilm].Cells[3].Value = film.RatingFilm;
                        numbersFilm++;
                    }
            }
        }

        private async void btn_add_film_Click(object sender, EventArgs e)
        {
            AddFilmForm addFilmForm = new AddFilmForm();
            addFilmForm.ShowDialog();

            string nameFilmForm = AddFilmForm.NameFilmForm;
            string nominationFilmForm = AddFilmForm.NominationFilmForm;
            int ticketPriceForm = AddFilmForm.TicketPriceForm;
            string ratingFilmForm = AddFilmForm.RatingFilmForm;

            Film newFilm = new Film(nameFilmForm,
                nominationFilmForm, ticketPriceForm, ratingFilmForm);

            if (!string.IsNullOrEmpty(nameFilmForm) &&
                !string.IsNullOrEmpty(nominationFilmForm) &&
                (ticketPriceForm > 0) &&
                !string.IsNullOrEmpty(ratingFilmForm))
            {
                var films = await ReadFromFile<Film>(FileFilm);

                if (!films.Contains(newFilm))
                {
                    foreach (var twoFilms in films)
                    {
                        if (twoFilms.NameFilm == nameFilmForm &&
                            twoFilms.NominationFilm == nominationFilmForm &&
                            twoFilms.TicketPrice == ticketPriceForm &&
                            twoFilms.RatingFilm == ratingFilmForm)
                        {
                            MessageBox.Show($"Фильм {twoFilms.NameFilm} уже занесён в базу " +
                                $"Фестиваль фильмов. ", "Добавление фильма", 0,
                                MessageBoxIcon.Information);
                            return;
                        }
                    }

                    films.Add(newFilm);
                    countFilm = films.Count;
                    label_CountOfFilms.Text = "Количество фильмов: " + Convert.ToString(countFilm);

                    await WriteToFile(films, FileFilm);

                    film_dataGridView.Rows.Add(nameFilmForm, nominationFilmForm, ticketPriceForm,
                              ratingFilmForm);
                    MessageBox.Show($"Фильм {nameFilmForm} успешно добавлен в базу " +
                                $"Фестиваль фильмов. ", "Добавление фильма", 0,
                                MessageBoxIcon.Information);
                    AddFilmForm.NameFilmForm = "";
                    AddFilmForm.NominationFilmForm = "";
                    AddFilmForm.TicketPriceForm = 0;
                    AddFilmForm.RatingFilmForm = "";

                }
                else
                {
                    MessageBox.Show($"Этот фильм был занесён в базу фестиваль фильмов ранее",
                        "Добавление фильма", 0,
                        MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private async void film_dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = film_dataGridView.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string nomination = selectedRow.Cells[1].Value.ToString();
            int ticketPrice = Convert.ToInt32(selectedRow.Cells[2].Value);
            string rating = selectedRow.Cells[3].Value.ToString();

            ChangeFilmForm formFilm = new ChangeFilmForm(name, nomination, ticketPrice, rating);
            formFilm.ShowDialog();

            string nameFilmForm = ChangeFilmForm.NameFilmForm;
            string nominationFilmForm = ChangeFilmForm.NominationFilmForm;
            int ticketPriceForm = ChangeFilmForm.TicketPriceForm;
            string ratingFilmForm = ChangeFilmForm.RatingFilmForm;

            Film modifiedFilm = new Film(nameFilmForm,
                nominationFilmForm, ticketPriceForm, ratingFilmForm);

            var films = await ReadFromFile<Film>(FileFilm);

            foreach (var f in films)
            {
                if (name == f.NameFilm && nomination == f.NominationFilm
                    && ticketPrice == f.TicketPrice && rating == f.RatingFilm)
                {
                    if (!(nameFilmForm.Equals(name) && nominationFilmForm.Equals(nomination) && ticketPriceForm == ticketPrice && ratingFilmForm.Equals(rating)))
                    {
                        films.Remove(f);
                        films.Add(modifiedFilm);
                        selectedRow.Cells[0].Value = nameFilmForm;
                        selectedRow.Cells[1].Value = nominationFilmForm;
                        selectedRow.Cells[2].Value = ticketPriceForm;
                        selectedRow.Cells[3].Value = ratingFilmForm;
                        film_dataGridView.Refresh();
                        MessageBox.Show($"Фильм {f.NameFilm}  изменён!", "Изменение фильма", 0,
                            MessageBoxIcon.Information);
                        ChangeFilmForm.NameFilmForm = "";
                        ChangeFilmForm.NominationFilmForm = "";
                        ChangeFilmForm.TicketPriceForm = 0;
                        ChangeFilmForm.RatingFilmForm = "";
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Фильм {f.NameFilm} не был изменён, внесите изменения!", "Неудачное изменение фильма", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(films, FileFilm);
        }

        private void nav_bar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {

            if (film_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Нет ни одного фильма или вы не выбрали фильм для удаленя!",
                   "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
            int selectCount = film_dataGridView.SelectedRows[0].Index;

            if (selectCount >= 0 && film_dataGridView.SelectedRows.Count != 0)
            {
                var films = await ReadFromFile<Film>(FileFilm);
                //if (films.Count == 1)
                //{
                //    TextBoxFilterFilm.Text = "";
                //    TextBoxFilterFilm.Enabled = false;
                //    ComboBoxFilterFilm.SelectedIndex = -1;
                //}
                string nameFilm = film_dataGridView.Rows[selectCount].Cells[0].Value.ToString();
                string nominationFilm = film_dataGridView.Rows[selectCount].Cells[1].Value.ToString();
                int ticketPrice = Convert.ToInt32(film_dataGridView.Rows[selectCount].Cells[2].Value.ToString());
                string ratingFilm = film_dataGridView.Rows[selectCount].Cells[3].Value.ToString(); ;

                foreach (var f in films)
                {
                    if (nameFilm == f.NameFilm && nominationFilm == f.NominationFilm
                        && ticketPrice == f.TicketPrice && ratingFilm == f.RatingFilm)
                    {
                        films.Remove(f);
                        countFilm = films.Count;
                        label_CountOfFilms.Text = "Количество фильмов: " + Convert.ToString(countFilm);
                        film_dataGridView.Rows.Remove(film_dataGridView.Rows[selectCount]);
                        film_dataGridView.Refresh();
                        //TextBoxKolvoSearchFilm.Text = film_dataGridView.SelectedRows.Count.ToString();
                        MessageBox.Show($"Фильм {f.NameFilm}  удалён!", "Удаление одного фильма", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(films, FileFilm);
            }
            else
            {
                MessageBox.Show("Нет ни одного фильма или вы не выбрали фильм для удаленя!",
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        private void comboBox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            film_dataGridView.ClearSelection();
            textBox_filter.Enabled = true;
        }

        private void textBox_filter_TextChanged(object sender, EventArgs e)
        {

            //if (textBox_filter.Text.Length != 0)
            //{
            //    labelFilterShowFilm.Visible = true;
            //}
            //else
            //    labelFilterShowFilm.Visible = false;
            if (comboBox_filter.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите поле для фильтрации!", "Внимание", 0, MessageBoxIcon.Information);
                return;
            }
            string searchValue = textBox_filter.Text;
            int columnIndex = comboBox_filter.SelectedIndex;
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in film_dataGridView.Rows)
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
                film_dataGridView.Rows[0].Selected = true;
            }
            //if (!hasVisibleRows && !string.IsNullOrEmpty(searchValue))
            //{
            //    MessageBox.Show($"Полей с такими данными: {searchValue} - нет!", "Внимание", 0, MessageBoxIcon.Information);
            //}
        }

        private async void textBox_filter_Enter(object sender, EventArgs e)
        {
            var films = await ReadFromFile<Film>(FileFilm);
            countFilm = films.Count;
            if (countFilm == 0)
            {
                textBox_filter.Enabled = false;
                comboBox_filter.Text = "";
                MessageBox.Show("Нет ни одного фильма!", "Неудачная фильтрация", 0, MessageBoxIcon.Information);
                return;
            }
            await WriteToFile(films, FileFilm);
        }

        private void film_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
