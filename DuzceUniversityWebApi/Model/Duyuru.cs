using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DuzceUniversityWebApi.Model
{
    public class Duyuru
    {
        [Key]
        public int Id { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string date { get; set; }
        public string imgUrl { get; set; }
        public string description { get; set; }
    }
}
