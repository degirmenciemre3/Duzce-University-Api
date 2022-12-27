using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniversityWebApi.Model
{
    public class Yayin
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
