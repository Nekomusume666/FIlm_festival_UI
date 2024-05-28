using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work_FestivalFilmov_Afonin
{
    public class Jury
    {
        public string NameJury { get; set; }  //имя гостя
        public string LastNameJury { get; set; }  //фамилия гостя
        public string PostJury { get; set; } //Должность члена жюри(актёр, продюсер, режиссёр)
        public bool isVoted { get; set; } //проголосовал?

        public Dictionary<string, int> votes_dict { get; set; }


        public Jury(string nameGuest, string lastNameGuest, string postJury, bool vote, Dictionary<string, int> dict)
        {
            NameJury = nameGuest;
            LastNameJury = lastNameGuest;
            PostJury = postJury;

            isVoted = vote;
            votes_dict = dict;
        }
    }
}
