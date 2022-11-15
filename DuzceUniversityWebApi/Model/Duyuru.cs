using System;
using System.ComponentModel.DataAnnotations;

namespace DuzceUniversityWebApi.Model
{
    public class Duyuru
    {
        [Key]
        public double Id { get; set; }
        public DateTime Tarih { get; set; }
        public string KisaAciklama { get; set; }
        public string Aciklama { get; set; }
        public string Baslik { get; set; }
        public string Image { get; set; }
    }
}
