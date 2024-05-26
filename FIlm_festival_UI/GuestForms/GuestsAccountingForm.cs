using course_work_FestivalFilmov_Afonin;
using FIlm_festival_UI.GuestForms;
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
    public partial class GuestsAccountingForm : Form
    {
        const string FileGuest = "Guest.json";

        int numbersGuest = 0;
        int countGuest = 0;

        public GuestsAccountingForm()
        {
            Task.Run(() => File.Open(FileGuest, FileMode.OpenOrCreate).Close());

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

        //  чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nav_bar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            AddGuestForm formGuest = new AddGuestForm();
            formGuest.ShowDialog();
            string nameGuestForm = AddGuestForm.NameGuestForm;
            string lastNameGuestForm = AddGuestForm.LastNameGuestForm;
            int seatNumberGuestForm = AddGuestForm.SeatNumberGuestForm;
            string emailGuestForm = AddGuestForm.EmailGuestForm;

            Guests newGuest = new Guests(nameGuestForm,
                lastNameGuestForm, emailGuestForm, seatNumberGuestForm);

            if (!string.IsNullOrEmpty(nameGuestForm) &&
                !string.IsNullOrEmpty(lastNameGuestForm) &&
                (seatNumberGuestForm > 0) &&
                !string.IsNullOrEmpty(emailGuestForm))
            {
                var guest = await ReadFromFile<Guests>(FileGuest);

                if (!guest.Contains(newGuest))
                {
                    foreach (var twoGuest in guest)
                    {
                        if (twoGuest.NameGuest == nameGuestForm &&
                            twoGuest.LastNameGuest == lastNameGuestForm &&
                            twoGuest.SeatNumberGuest == seatNumberGuestForm &&
                            twoGuest.EmailGuest == emailGuestForm)
                        {
                            MessageBox.Show($"Гость {twoGuest.NameGuest} уже занесён в базу " +
                                $"Фестиваль фильмов. ", "Добавление гостя", 0,
                                MessageBoxIcon.Information);
                            return;
                        }
                        if (twoGuest.SeatNumberGuest == seatNumberGuestForm)
                        {
                            MessageBox.Show($"Гость c номером места {twoGuest.SeatNumberGuest} уже занесён в базу " +
                               $"Фестиваль фильмов. ", "Добавление гостя", 0,
                               MessageBoxIcon.Information);
                            return;
                        }
                    }

                    guest.Add(newGuest);
                    countGuest = guest.Count;
                    label_Count.Text = "Количество гостей: " + Convert.ToString(countGuest);


                    await WriteToFile(guest, FileGuest);

                    dataGridView.Rows.Add(nameGuestForm, lastNameGuestForm, emailGuestForm, seatNumberGuestForm, "-");
                    MessageBox.Show($"Гость {nameGuestForm} успешно добавлен в базу " +
                           $"Фестиваль фильмов. ", "Добавление гостя", 0,
                           MessageBoxIcon.Information);
                    AddGuestForm.NameGuestForm = "";
                    AddGuestForm.LastNameGuestForm = "";
                    AddGuestForm.SeatNumberGuestForm = 0;
                    AddGuestForm.EmailGuestForm = "";
                }
                else
                {
                    MessageBox.Show($"Этот гость был занесён в базу фестиваль фильмов ранее",
                        "Добавление гостя", 0, MessageBoxIcon.Information);
                    return;
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
                var guests = await ReadFromFile<Guests>(FileGuest);
                //if (guests.Count == 1)
                //{
                //    TextBoxFilterGuest.Text = "";
                //    TextBoxFilterGuest.Enabled = false;
                //    ComboBoxFilterGuest.SelectedIndex = -1;
                //}
                string nameGuest = dataGridView.Rows[selectCount].Cells[0].Value.ToString();
                string lastNameGuest = dataGridView.Rows[selectCount].Cells[1].Value.ToString();
                string emailGuest = dataGridView.Rows[selectCount].Cells[2].Value.ToString();
                int seatNumberGuest = Convert.ToInt32(dataGridView.Rows[selectCount].Cells[3].Value.ToString());

                foreach (var twoGuests in guests)
                {
                    if (nameGuest == twoGuests.NameGuest && lastNameGuest == twoGuests.LastNameGuest
                        && emailGuest == twoGuests.EmailGuest && seatNumberGuest == twoGuests.SeatNumberGuest)
                    {
                        guests.Remove(twoGuests);
                        countGuest = guests.Count;
                        label_Count.Text = "Количество гостей: " + Convert.ToString(countGuest);
                        dataGridView.Rows.Remove(dataGridView.Rows[selectCount]);
                        dataGridView.Refresh();
                        MessageBox.Show($"Гость {twoGuests.NameGuest}  удалён!", "Удаление одного гостя", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(guests, FileGuest);
            }
            else
            {
                MessageBox.Show("Нет ни одного гостя или вы не выбрали гостя для удаления!",
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        private async void ParticipantsAccountingForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileGuest))
            {
                var tableOfGuest = await ReadFromFile<Guests>(FileGuest);
                numbersGuest = 0;
                countGuest = tableOfGuest.Count;
                label_Count.Text = "Количество гостей: " + Convert.ToString(countGuest);

                if (tableOfGuest != null)
                    foreach (var guests in tableOfGuest)
                    {
                        dataGridView.Rows.Add();
                        dataGridView.Rows[numbersGuest].Cells[0].Value = guests.NameGuest;
                        dataGridView.Rows[numbersGuest].Cells[1].Value = guests.LastNameGuest;
                        dataGridView.Rows[numbersGuest].Cells[2].Value = guests.EmailGuest;
                        dataGridView.Rows[numbersGuest].Cells[3].Value = guests.SeatNumberGuest;
                        if (guests.isVoted) dataGridView.Rows[numbersGuest].Cells[4].Value = "+";
                        else dataGridView.Rows[numbersGuest].Cells[4].Value = "-";

                        numbersGuest++;
                    }
            }
        }

        private void comboBox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            textBox_filter.Enabled = true;
        }

        private async void textBox_filter_Enter(object sender, EventArgs e)
        {
            var guests = await ReadFromFile<Guests>(FileGuest);
            countGuest = guests.Count;
            if (countGuest == 0)
            {
                textBox_filter.Enabled = false;
                comboBox_filter.Text = "";
                MessageBox.Show("Нет ни одного гостя!", "Неудачная фильтрация", 0, MessageBoxIcon.Information);
                return;
            }
            await WriteToFile(guests, FileGuest);
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

        private async void participants_dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string surname = selectedRow.Cells[1].Value.ToString();
            string email = selectedRow.Cells[2].Value.ToString();
            int seatNumber = Convert.ToInt32(selectedRow.Cells[3].Value);

            ChangeGuestForm guestForm = new ChangeGuestForm(name, surname, email, seatNumber);
            guestForm.ShowDialog();

            string modName = ChangeGuestForm.NameGuestForm;
            string modSurname = ChangeGuestForm.LastNameGuestForm;
            string modEmail = ChangeGuestForm.EmailGuestForm;
            int modNumberPlace = ChangeGuestForm.SeatNumberGuestForm;

            Guests modifiedParticipant = new Guests(modName,
                modSurname, modEmail, modNumberPlace);

            var guests = await ReadFromFile<Guests>(FileGuest);

            foreach (var g in guests)
            {
                if (name == g.NameGuest && surname == g.LastNameGuest
                    && seatNumber == g.SeatNumberGuest && email == g.EmailGuest)
                {
                    if (!(modName.Equals(name) && modSurname.Equals(surname) && modEmail.Equals(email) && modNumberPlace == seatNumber))
                    {
                        guests.Remove(g);
                        guests.Add(modifiedParticipant);
                        selectedRow.Cells[0].Value = modName;
                        selectedRow.Cells[1].Value = modSurname;
                        selectedRow.Cells[2].Value = modEmail;
                        selectedRow.Cells[3].Value = modNumberPlace;
                        dataGridView.Refresh();
                        MessageBox.Show($"Гость {g.NameGuest} изменён!", "Изменение участника", 0,
                            MessageBoxIcon.Information);
                        ChangeGuestForm.NameGuestForm = "";
                        ChangeGuestForm.LastNameGuestForm = "";
                        ChangeGuestForm.EmailGuestForm = "";
                        ChangeGuestForm.SeatNumberGuestForm = 0;
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Гость {g.NameGuest} не был изменён, внесите изменения!",
                            "Неудачное изменение участника", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(guests, FileGuest);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btn_voting_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int curValue = (int)dataGridView.CurrentRow.Cells[3].Value;

                var guests = await ReadFromFile<Guests>(FileGuest);

                foreach (var guest in guests)
                {
                    if (guest.SeatNumberGuest == curValue)
                    {
                        VotingGuestForm votingGuestForm = new VotingGuestForm(guest);
                        votingGuestForm.ShowDialog();

                        if (guest.isVoted) dataGridView.CurrentRow.Cells[4].Value = "+";
                        else dataGridView.CurrentRow.Cells[4].Value = "-";
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать гостя!");
            }
        }
    }
}
