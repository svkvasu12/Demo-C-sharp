using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dataannotations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car1 = new Car("Volvo", "245Gt");
        }
    }
    [Table("CarsDA")]
    class Car
    {
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        //[Key]
        public int MySpecialId { get; set; }
       
        public string Brand { get; set; }
        [Column("ModelIda")]
        public string Model { get; set; }
    }
    class Motorcycle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        
        public string Model { get; set; }
    }

    class VehicleContect : DbContext
    {

        public DbSet<Car> Cars { get; set; }
        public DbSet<Motorcycle> MotorCycles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = annotations-data; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        //fluent API
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Car>(entity => entity.HasKey(e => e.MySpecialId));
            modelbuilder.Entity<Car>(entity => entity.ToTable("CarsFluent"));
            modelbuilder.Entity<Car>().Property(p => p.Model).HasColumnName("Product");
        }
    }
}
