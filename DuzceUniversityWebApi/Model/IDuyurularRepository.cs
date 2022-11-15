using System.Linq;

namespace DuzceUniversityWebApi.Model
{
    public interface IDuyurularRepository
    {
        IQueryable<Duyuru> Duyurulars { get; }
        void SaveDuyuru(Duyuru d);
        void CreateDuyuru(Duyuru d);
        void DeleteDuyuru(Duyuru d);
    }
}
