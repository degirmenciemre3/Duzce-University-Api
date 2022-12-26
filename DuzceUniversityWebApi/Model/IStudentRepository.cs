using System.Linq;

namespace DuzceUniversityWebApi.Model
{
    public interface IStudentRepository
    {
        IQueryable<Students> Students { get; }
        void SaveStudent(Students d);
        void CreateStudent(Students d);
        void DeleteStudent(Students d);
    }
}
