using Microsoft.AspNetCore.Hosting;
using System;
using System.Linq;

namespace DuzceUniversityWebApi.Model
{
    public class EFYayinlarRepository : IYayinRepository
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private DatabaseContext context;

        public EFYayinlarRepository(DatabaseContext ctx, IWebHostEnvironment hostEnvironment)
        {
            context = ctx;
            _hostEnvironment = hostEnvironment;
        }

        public IQueryable<Yayin> Yayinlars => context.yayinlars;
        public void CreateYayin(Yayin y)
        {
            try
            {
                context.Add(y);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteYayin(Yayin y)
        {
            context.Remove(y);
            context.SaveChanges();
        }

        public void SaveYayin(Yayin y)
        {
            context.SaveChanges();
        }
    }
}
