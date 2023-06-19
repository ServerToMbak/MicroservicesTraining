using System;
using System.Linq;
using ManagementService.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ManagementService.Data
{
    public static class PrebDb
    {   
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
                SeedDataToInstructor(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if(!context.Classes.Any())
            {
                Console.WriteLine("-->Seeding Data");           

                context.Classes.AddRange(
                    new Class() {Name = "Deneme1", Population="Free"},
                    new Class() {Name = "Deneme2", Population="Free"},
                    new Class() {Name = "Deneme3", Population="Free"}

                ); 

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> Already Have data");
            }
        }
        private static void SeedDataToInstructor(AppDbContext context)
        {

        if(!context.Instructors.Any())
        {
            Console.WriteLine("-->Seeding Data to Instructor");
            
            
            context.Instructors.AddRange(
                new Instructor() {Name = "Server", Subject=".Net"},
                new Instructor() {Name = "Server", Subject=".Net"},
                new Instructor() {Name = "Server", Subject=".Net"}
            );
        }
        else
        {
            Console.WriteLine("Already Have Data");
        }
        }

    }
}