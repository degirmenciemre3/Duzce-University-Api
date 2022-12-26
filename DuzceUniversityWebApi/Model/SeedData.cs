using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DuzceUniversityWebApi.Model
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DatabaseContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<DatabaseContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            DateTime DateNow = DateTime.Now;

            if (!context.duyurulars.Any())
            {
                context.duyurulars.AddRange(
                    new Duyuru
                    {
                        title = "Title1",
                        category = "Category1",
                        date = "Date1",
                        imgUrl = "imgUrl1",
                        description = "description1"
                    },
                    new Duyuru
                    {
                        title = "Title2",
                        category = "Category2",
                        date = "Date2",
                        imgUrl = "imgUrl2",
                        description = "description2"
                    },
                    new Duyuru
                    {
                        title = "Title3",
                        category = "Category3",
                        date = "Date3",
                        imgUrl = "imgUrl3",
                        description = "description3"
                    },
                    new Duyuru
                    {
                        title = "Title4",
                        category = "Category4",
                        date = "Date4",
                        imgUrl = "imgUrl4",
                        description = "description4"
                    },
                    new Duyuru
                    {
                        title = "Title5",
                        category = "Category5",
                        date = "Date5",
                        imgUrl = "imgUrl5",
                        description = "description5"
                    },
                    new Duyuru
                    {
                        title = "Title6",
                        category = "Category6",
                        date = "Date6",
                        imgUrl = "imgUrl6",
                        description = "description6"
                    },
                    new Duyuru
                    {
                        title = "Title7",
                        category = "Category7",
                        date = "Date7",
                        imgUrl = "imgUrl7",
                        description = "description7"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
