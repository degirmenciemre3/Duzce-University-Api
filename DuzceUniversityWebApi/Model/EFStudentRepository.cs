using Microsoft.AspNetCore.Hosting;
using System;
using System.Linq;

namespace DuzceUniversityWebApi.Model
{
    public class EFStudentRepository : IStudentRepository
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private AppIdentityDbContext context;
        
        public EFStudentRepository(AppIdentityDbContext ctx, IWebHostEnvironment hostEnvironment)
        {
            context = ctx;
            _hostEnvironment = hostEnvironment;
        }
        public IQueryable<Students> Students => context.students;
        public void CreateStudent(Students d)
        {
            try
            {
                context.Add(d);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteStudent(Students d)
        {
            context.Remove(d);
            context.SaveChanges();
        }

        public void SaveStudent(Students d)
        {
            context.SaveChanges();
        }
    }
}
