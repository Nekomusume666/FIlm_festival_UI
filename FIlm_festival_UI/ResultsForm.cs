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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        const string FileGuest = "Guest.json";
        const string FileJury = "Jury.json";
        const string FileFilm = "Films.json";

        private async void ResultsForm_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            int index = 0;

            if (File.Exists(FileFilm))
            {
                var tableOfFilms = await ReadFromFile<Film>(FileFilm);

                if (File.Exists(FileGuest) && File.Exists(FileJury))
                {
                    var tableOfGuests = await ReadFromFile<Guests>(FileGuest);

                    bool isVotedG = true;

                    foreach (var guest in tableOfGuests)
                    {
                        if (!guest.isVoted)
                        {
                            isVotedG = false;
                            break;
                        }
                    }

                    var tableOfJurys = await ReadFromFile<Jury>(FileJury);

                    bool isVotedJ = true;

                    foreach (var jury in tableOfJurys)
                    {
                        if (!jury.isVoted)
                        {
                            isVotedJ = false;
                            break;
                        }
                    }

                    if (isVotedG && isVotedJ)
                    {
                        foreach (var film in tableOfFilms)
                        {
                            dataGridView.Rows.Add();
                            dataGridView.Rows[index].Cells[0].Value = film.NameFilm;
                            dataGridView.Rows[index].Cells[1].Value = (double)film.JurysVotes / film.JurysAmount;
                            dataGridView.Rows[index].Cells[2].Value = (double)film.GuestsVotes / film.GuestsAmount;


                            index++;
                        }

                        //guests
                        double maxGuest = -1;
                        List<string> maxGuestName = new List<string>();
                        //jurys
                        double maxJury = -1;
                        List<string> maxJuryName = new List<string>();

                        if (dataGridView.RowCount > 1)
                        {
                            //guests
                            maxGuest = double.Parse(dataGridView.Rows[0].Cells[2].Value.ToString());
                            maxGuestName.Add(dataGridView.Rows[0].Cells[0].Value.ToString());
                            //jurys
                            maxJury = double.Parse(dataGridView.Rows[0].Cells[1].Value.ToString());
                            maxJuryName.Add(dataGridView.Rows[0].Cells[0].Value.ToString());

                            for (int i = 1; i < dataGridView.Rows.Count; i++)
                            {
                                //guests
                                double current = double.Parse(dataGridView.Rows[i].Cells[2].Value.ToString());
                                if (maxGuest < current)
                                {
                                    maxGuest = current;
                                    maxGuestName.Clear();
                                    maxGuestName.Add(dataGridView.Rows[i].Cells[0].Value.ToString());
                                }
                                if (maxGuest == current)
                                {
                                    maxGuestName.Add(dataGridView.Rows[i].Cells[0].Value.ToString());
                                }

                                //jurys
                                double currentJ = double.Parse(dataGridView.Rows[i].Cells[1].Value.ToString());
                                if (maxJury < currentJ)
                                {
                                    maxJury = currentJ;
                                    maxJuryName.Clear();
                                    maxJuryName.Add(dataGridView.Rows[i].Cells[0].Value.ToString());
                                }
                                if (maxJury == currentJ)
                                {
                                    maxJuryName.Add(dataGridView.Rows[i].Cells[0].Value.ToString());
                                }

                            }
                        }
                        else
                        {
                            //guests
                            maxGuest = double.Parse(dataGridView.Rows[0].Cells[2].Value.ToString());
                            maxGuestName.Add(dataGridView.Rows[0].Cells[0].Value.ToString());
                            //jurys
                            maxJury = double.Parse(dataGridView.Rows[0].Cells[1].Value.ToString());
                            maxJuryName.Add(dataGridView.Rows[0].Cells[0].Value.ToString());

                        }

                        //guests
                        if (maxGuestName.Count == 1)
                        {
                            label_guest_name.Text = maxGuestName[0];
                        }
                        else
                        {
                            label_guest_name.Text = maxGuestName[0];
                            for (int i = 1; i < maxGuestName.Count; i++)
                            {
                                label_guest_name.Text = label_guest_name.Text + ", " + maxGuestName[i];
                            }
                        }

                        //jurys
                        if (maxJuryName.Count == 1)
                        {
                            label_jury_name.Text = maxJuryName[0];
                        }
                        else
                        {
                            label_jury_name.Text = maxJuryName[0];
                            for (int i = 1; i < maxJuryName.Count; i++)
                            {
                                label_jury_name.Text = label_jury_name.Text + ", " + maxJuryName[i];
                            }
                        }

                    }
                }
            }
        }

        private void nav_bar_panel_Paint(object sender, PaintEventArgs e)
        {

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

    }
}
