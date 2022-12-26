using System;
using System.ComponentModel.DataAnnotations;

namespace DuzceUniversityWebApi.Model.ViewModel
{
    public class RegisterModel
    {
        public string name { get; set; }
        public string profileImage { get; set; }
        public string lastName { get; set; }
        public string bolum { get; set; }
        public string tecrube { get; set; }
        public DateTime mezunDate { get; set; }
        public bool stajDurumu { get; set; }
        public string ogrenciMail { get; set; }
    }
}
