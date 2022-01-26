using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_PRAC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VehicleContext db = new VehicleContext();

            // Create
            // car car1 = new car("Volvo", "245 GHT", 1980, 175);
            // db.Cars.Add(car1);
            // car car2 = new car("Saab", "24 GHT", 1986, 173);
            // db.Cars.Add(car2);
            // db.SaveChanges();
            // Read

            List<car> CarsRead = db.Cars.ToList();

            // Update
            // car carUpdate = db.Cars.Where(car => car.Id == 3).FirstOrDefault();
            //.Model = "900 Turbo";
            //.Speed = 455;
            //db.Cars.Update(carUpdate);
            //db.SaveChanges();

            // Delete
            car carDelete = db.Cars.Where(car => car.Id == 2).FirstOrDefault();
            db.Cars.Remove(carDelete);
            db.SaveChanges();
            Console.ReadLine();
        }
    }

    class car
    {
        public car(string brand, string model, int year, int speed)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Speed = speed;
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }
    }

    class VehicleContext : DbContext
    {
        public DbSet<car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EF PRAC; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
}
