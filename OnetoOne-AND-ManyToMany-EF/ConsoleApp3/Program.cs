using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleContext db = new VehicleContext(); //Gateway to database to store in database
            Console.WriteLine("Many to Many");
            /*Owner owner1 = new Owner("vasu");
            Owner owner2 = new Owner("Teja");
            Owner owner3 = new Owner("Sri");
            // Owner owner4 = new ("Mats"); //We can write like this also
            //var owner5 = new("vasu");//We can write like this also

            Car car1 = new Car("Volvo");
            Car car2 = new Car("saab");
            Car car3 = new Car("BMW");
            Car car4 = new Car("Audi");
            Car car5 = new Car("Volvo2");
            Car car6 = new Car("Volvo3");

            owner1.Cars.Add(car1);//we can say owner 1 is having car1 and car2
            owner1.Cars.Add(car3);
            owner2.Cars.Add(car4);
            owner2.Cars.Add(car3);
            owner3.Cars.Add(car6);
            owner3.Cars.Add(car5);
            owner2.Cars.Add(car2);
            //below is connection to the database
            db.owners.Add(owner1);
            db.owners.AddRange(owner2,owner3);

            db.SaveChanges(); */

            //List<Owner> owners = db.owners.ToList();//Giving this only includes owners and cars will be 0 here so we have to use include option

            // List<Owner> owners = db.owners.Include("Cars").ToList();
            List<Owner> owners = db.owners.Include(owner => owner.Cars).ToList();//this will take already stored data from DB and give cars to specific owners as stored before
            Console.WriteLine("woners and cars {0}", owners);
            Console.ReadLine();

            
        }
    }

    //one owner one car 
    /*class Owner
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Car car { get; set; }
    }
    class Car
    {
        public int Id { get; set; }
        public String Name { get; set; }
         public int OwnerId { get; set; }
        public Owner owner { get; set; }
    }*/
    //Many to many
    class Owner
    {
        public Owner(string name)
        {
            Name = name;

        }

        public int Id { get; set; }
        public String Name { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>(); //It will create empty list  = new List<Car>(
    }
    class Car
    {
        public Car(string name)
        {
            Name = name;

        }

        public int Id { get; set; }
        public String Name { get; set; }


        public List<Owner> owners { get; set; } = new List<Owner>(); //It will create empty list = new List<Owner>()
    }
    class VehicleContext : DbContext
    {
        public DbSet<Owner> owners { get; set; }
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = oneToOneEF_Practice; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
}

