using course_work_FestivalFilmov_Afonin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIlm_festival_UI.GuestForms
{
    public partial class VotingGuestForm : Form
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

        public Guests curGuest { get; set; }
        const string FileGuest = "Guest.json";
        const string FileFilm = "Films.json";

        int numbersFilm = 0;
        int countFilm = 0;


        public VotingGuestForm(Guests guest)
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            curGuest = guest;
        }

        private async void VotingGuestForm_Load(object sender, EventArgs e)
        {
            Title_of_current_page.Text = Title_of_current_page.Text + curGuest.NameGuest;

            dataGridView.AllowUserToAddRows = false;
            if (File.Exists(FileFilm))
            {
                var tableOfFilms = await ReadFromFile<Film>(FileFilm);
                var curDict = curGuest.votes_dict;
                numbersFilm = 0;

                if (tableOfFilms != null)
                {
                    foreach (var film in tableOfFilms)
                    {
                        dataGridView.Rows.Add();
                        dataGridView.Rows[numbersFilm].Cells[0].Value = film.NameFilm;
                        dataGridView.Rows[numbersFilm].Cells[1].Value = "";
                        numbersFilm++;
                    }


                    if (curDict != null)
                    {
                        numbersFilm = 0;
                        foreach (var film in tableOfFilms)
                        {
                            foreach (var item in curDict)
                            {
                                if (item.Key == film.NameFilm)
                                {
                                    dataGridView.Rows[numbersFilm].Cells[1].Value = item.Value;
                                    break;
                                }
                            }
                            numbersFilm++;
                        }
                    }
                }
            }

            dataGridView.CellValueChanged += new DataGridViewCellEventHandler(dataGridView_CellValueChanged);
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

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell != null)
            {
                if (Int32.TryParse(dataGridView.CurrentCell.Value.ToString(), out int value))
                {
                    if (!CheckCellValue(value))
                    {
                        dataGridView.CellValueChanged -= new DataGridViewCellEventHandler(dataGridView_CellValueChanged);
                        dataGridView.CurrentCell.Value = "";
                        MessageBox.Show("Баллы могут быть в диапозоне от 0 до 10!");
                        dataGridView.CellValueChanged += new DataGridViewCellEventHandler(dataGridView_CellValueChanged);
                    }
                }
                else
                {
                    dataGridView.CellValueChanged -= new DataGridViewCellEventHandler(dataGridView_CellValueChanged);
                    dataGridView.CurrentCell.Value = "";
                    MessageBox.Show("Баллы могут быть в диапозоне от 0 до 10!");
                    dataGridView.CellValueChanged += new DataGridViewCellEventHandler(dataGridView_CellValueChanged);

                }
            }

        }

        private bool CheckCellValue(int value)
        {
            if (value >= 0 && value <= 10) return true;
            else return false;
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[1].Value == "")
                {
                    MessageBox.Show("Не все баллы проставлены!");
                    dataGridView.Rows[i].Cells[1].Selected = true;
                    dataGridView.Focus();
                    return;
                }
            }

            var tableOfFilms = await ReadFromFile<Film>(FileFilm);
            foreach (var film in tableOfFilms)
            {
                //film.GuestsVotes +=
            }

             Close();
        }
    }
}
