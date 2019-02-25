using System;
using MyApp.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new sakilaContext();
            // var actors = dbContext.Actor.ToList();
            // foreach (var a in actors) 
            // {
            //     Console.WriteLine($"ID:{a.ActorId} First Name:{a.FirstName} Last Name: {a.LastName} Created on: {a.LastUpdate}");
            // }
            
            // var records = dbContext.Film.Include(f => f.FilmActor).ThenInclude(r => r.Actor).ToList();
            // foreach (var record in records) 
            // {
            //     Console.WriteLine($"Film: {record.Title}");
            //     var counter = 1;
            //     foreach (var fa in record.FilmActor) 
            //     {
            //         Console.WriteLine($"\tActor {counter++}: {fa.Actor.FirstName} {fa.Actor.LastName}");
            //     }       
            // }
            
            // var city = new City() { CityId = 601, Name = "Redmond", CountryId = 103 };
            // dbContext.Add(city);
            // dbContext.SaveChanges();

            // var uTarget = dbContext.City.SingleOrDefault(c => c.CityId == 601);
            // if (uTarget != null) 
            // {
            //     uTarget.Name = "Kirkland";  // change Name to City1 if you did not update the City class file
            //     dbContext.Update(uTarget);
            //     dbContext.SaveChanges();
            // }

            var dTarget = dbContext.City.SingleOrDefault(c => c.CityId == 601);
            if (dTarget != null) 
            {
                dbContext.Remove(dTarget);
                dbContext.SaveChanges();
            }
        }
    }
}
