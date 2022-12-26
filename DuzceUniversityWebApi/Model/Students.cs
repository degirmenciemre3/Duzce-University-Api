using System;
using System.ComponentModel.DataAnnotations;

namespace DuzceUniversityWebApi.Model
{
    public class Students
    {
        [Key]
        public int id { get; set; }
        public DateTime createdAt { get; set; }
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
