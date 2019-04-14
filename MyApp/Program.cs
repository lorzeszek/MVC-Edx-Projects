using System;
using System.Linq;
using MyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //List actors names and lastnames:

            var dbContext = new sakilaContext();
            var actors = dbContext.Actor.ToList();
            foreach (var a in actors) 
            {
                System.Console.WriteLine($"ID:{a.ActorId} Name:{a.FirstName} {a.LastName}");
            }



            //List films and their actors:

            // var dbContext = new sakilaContext();
            // var records = dbContext.Film.Include(f => f.FilmActor).ThenInclude(r => r.Actor).ToList();
            // foreach (var record in records) 
            // {
            //     System.Console.WriteLine($"Film: {record.Title}");
            //     var counter = 1;
            //     foreach (var fa in record.FilmActor) 
            //     {
            //         System.Console.WriteLine($"\tActor {counter++}: {fa.Actor.FirstName} {fa.Actor.LastName}");
            //     }
            // }



            //CREATE NEW VALUE ON db:

            // var dbContext = new sakilaContext();
            // var city = new City() { CityId = 1001, Name = "Gdansk", CountryId = 103 };
            // dbContext.Add(city);
            // dbContext.SaveChanges();


            
            //Update record od the DB:

            // var dbContext = new sakilaContext();
            // var uTarget = dbContext.City.SingleOrDefault(c => c.CityId == 1001);
            // if (uTarget != null) 
            // {
            //     uTarget.Name = "Sopot";  // change Name to City1 if you did not update the City class file
            //     dbContext.Update(uTarget);
            //     dbContext.SaveChanges();
            // }



            //Delete record from DB:

            // var dbContext = new sakilaContext();
            // var dTarget = dbContext.City.SingleOrDefault(c => c.CityId == 1001);
            // if (dTarget != null) 
            // {
            //     dbContext.Remove(dTarget);
            //     dbContext.SaveChanges();
            // }
        }
    }
}
