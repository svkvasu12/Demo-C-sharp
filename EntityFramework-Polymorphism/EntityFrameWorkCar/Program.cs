using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EntityFrameWorkCar
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleContect db = new VehicleContect();//Adding the information to db
            Console.WriteLine("Hello World!");
            Company company = new Company("Vasavi motor car");
            //company.Name = "Vasavi motor car";
            Car car = new Car("Volvo", "4e3gf", 1980, 170);
            MotorCycle mc = new MotorCycle("mc", "vfdv5", 1987, 346);
            //company.Cars = new List<Car>();
            company.Cars.Add(car);
            company.Motorcycles.Add(mc);

            db.companies.Add(company);
            db.SaveChanges();



            Console.ReadLine();
        }
    }
    class Car : Vehicle
    {
        //public int Id { get; set; }
        //public string Brand { get; set; }
        // public string Model { get; set; }
        //public int Year { get; set; }
        // public int Speed { get; set; }
        public Car(string brand, string model, int year, int speed) : base(brand, model, year, speed)
        {
        }
    }
    class MotorCycle : Vehicle
    {
        // public int Id { get; set; }
        //public string Brand { get; set; }
        //public string Model { get; set; }
        // public int Year { get; set; }
        // public int Speed { get; set; }
        public MotorCycle(string brand, string model, int year, int speed) : base(brand, model, year, speed)
        {
        }
    }
    class Vehicle
    {
        public Vehicle( string brand, string model, int year, int speed)
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
    class Company
    {
        public Company(string name)
        {
            Name = name;
            Cars = new List<Car>();
            Motorcycles = new List<MotorCycle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
        public List<MotorCycle> Motorcycles { get; set; }
    }
    class VehicleContect : DbContext
    {
       
        public DbSet<Car> Cars { get; set; }
        public DbSet<MotorCycle> MotorCycles { get; set; }
        public DbSet<Company> companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Vehicle_EFTRY; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}

