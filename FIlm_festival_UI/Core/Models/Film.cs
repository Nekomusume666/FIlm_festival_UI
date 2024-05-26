using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work_FestivalFilmov_Afonin
{
    public class Film
    {
        public string NameFilm { get; set; }  //название фильма
        public string NominationFilm { get; set; }  //номинация фильма(самый романтичный, смешной)
        public int TicketPrice { get; set; } //цена билета на фестиваль
        public string RatingFilm { get; set; } //рейтинг фильма

        public int GuestsVotes { get; set; } //общее кол-во баллов гостей
        public int GuestsAmount { get; set; } //кол-во баллов гостей

        public int JurysVotes { get; set; } //общее кол-во баллов гостей
        public int JurysAmount { get; set; } //кол-во баллов гостей





        public Film(string nameFilm, string nominationFilm, int ticketPrice, string ratingFilm)
        {
            NameFilm = nameFilm;
            NominationFilm = nominationFilm;
            TicketPrice = ticketPrice;
            RatingFilm = ratingFilm;

            GuestsVotes = 0;
            GuestsAmount = 0;
            JurysVotes = 0;
            JurysAmount = 0;
        }
    }
}