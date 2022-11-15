using Microsoft.AspNetCore.Hosting;
using System.Linq;
using System;

namespace DuzceUniversityWebApi.Model
{
    public class EFDuyurularRepository : IDuyurularRepository
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private DatabaseContext context;

        public EFDuyurularRepository(DatabaseContext ctx, IWebHostEnvironment hostEnvironment)
        {
            context = ctx;
            _hostEnvironment = hostEnvironment;
        }

        public IQueryable<Duyuru> Duyurulars => context.duyurulars;
        public void CreateDuyuru(Duyuru d)
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

        public void DeleteDuyuru(Duyuru d)
        {
            context.Remove(d);
            context.SaveChanges();
        }

        public void SaveDuyuru(Duyuru d)
        {
            context.SaveChanges();
        }
    }
}
