using System.Collections.Generic;

namespace DuzceUniversityWebApi.Model.ViewModel
{
    public class DuyuruViewModel
    {
        public IEnumerable<Duyuru> Duyurulars { get; set; }
        public Duyuru Duyurular { get; set; }
    }
}
