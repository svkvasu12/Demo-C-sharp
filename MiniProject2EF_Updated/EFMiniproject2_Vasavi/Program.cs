using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace try_again2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Store!");

            List<Product> products = new List<Product>();
            List<Company> companies = new List<Company>();
            ProductContext db = new ProductContext();

            Console.WriteLine("List from database");
            Console.WriteLine("Id".PadRight(4) + "name".PadRight(20) + "Category".PadRight(20) + "productname".PadRight(20) + "price" + "".PadRight(20) + "date".PadRight(20));
            db.Products.ToList().ForEach(Product => Console.WriteLine(Product.Id.ToString().PadRight(4) + Product.GetType().Name.PadRight(20) + Product.Category.PadRight(20) + Product.Productname.PadRight(20) + Product.Price + "".PadRight(20) + Product.Date));

            Console.WriteLine("Number of Products:" + db.Products.Count());
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Please enter an Store location .\n" +
                "a. Type UK 'or' United Kingdom \n" +
                "b. Type IN 'or' India .\n" +
                "c. Type SE 'or' Sweden \n");
               
            Console.ResetColor();
            Console.Write("Office location : ");
            String location = Console.ReadLine();
            string Unit = "";
            String place = "";

            var Date = new DateTime();
            String Category = "";
            String Productname = "";


            while (true)
            {

                Console.WriteLine("Enter type, (M)obile or (C)omputer: ");
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.WriteLine();

                Console.Write("Enter Category: ");
                Category = Console.ReadLine();
               
                if (Category == string.Empty) //if category is empty
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("category should not be empty");
                    Console.ResetColor();
                    continue;
                }
                else if (Category.Any(char.IsDigit)) //if category is int
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("cetegory should not be a number");
                    Console.ResetColor();
                    continue;
                }
                else if (Category.ToLower().Trim() == "q")//if category is "q" go to next 
                {
                    Console.ReadLine();
                    break;
                }

                Console.Write("Enter productname: ");
                Productname = Console.ReadLine();
                if (Productname == string.Empty)//productname should not be empty
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("productName should not be empty");
                    Console.ResetColor();
                    continue;
                }
                else if (Productname.Any(char.IsDigit))//productname should be a string
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("productname should not be a number");
                    Console.ResetColor();
                    continue;
                }
               
               
                double Price;
                
                    
                    Console.Write("What is the price for asset?  ");


                    Price = Convert.ToDouble(Console.ReadLine());



                    if (location.Trim().ToLower() == "uk" || location.Trim().ToLower() == "united kingdom")
                    {
                        Price = 0.87 * Price;
                        Unit = "Pound";
                        place = "United Kingdom";
                        Console.WriteLine("Money in GBP : {0}",Price);
                    }
                    else if (location.Trim().ToLower() == "in" || location.Trim().ToLower() == "india")
                    {
                        Price = 74.18 * Price;
                        Unit = "INR";
                        place = "India";
                        Console.WriteLine("Money in rupee : {0}", Price);
                    }
                    else if (location.Trim().ToLower() == "se" || location.Trim().ToLower() == "sweden")
                    {
                        Price = 8.94 * Price;
                        Unit = "SEK";
                        place = "Sweden";
                        Console.WriteLine("Money in sweden : {0}", Price);
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, we do not have an office at this location");
                        Console.ResetColor();

                        break;
                    }

                Date = new DateTime(2022, 01, 11);
                Console.Write("enter purchase date in format(yyyy,mm,dd):   ");

                Date = DateTime.Parse(Console.ReadLine());
                //TimeSpan diff = DateTime.Now - Date;
                //Console.WriteLine("{0}".PadRight(20), diff);
                if (Date >= DateTime.Today)//purchase date cannot have future date
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Purchase date cannot have future date");
                    Console.ResetColor();
                    break;
                }
                

                    Console.WriteLine("Enter Id to delete form DB 'PRESS 0 IF YOU DONT WANT TO DELTE ANY' : ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Product productDelete = db.Products.Where(products => products.Id == id).FirstOrDefault();
                    if (productDelete != null)
                    {
                        db.Products.Remove(productDelete);
                        db.SaveChanges();
                        Console.WriteLine($"The product with id:{id} has been deleted");
                    }
                    else
                    {
                        Console.WriteLine("The Selected product doesn't exist");

                    }
                Console.WriteLine(Category + " " + Productname + " " + "{0:C}", Price + " " + Date);

                //TO UPDATE TO UPDATE TO UPDATE TO UPDATE TO UPDATE TO UPDATE TO UPDATE
                //**************************************************************************************************************************************

                
                Console.WriteLine("provide id which you want to update");
                id = Convert.ToInt32(Console.ReadLine());

                Product Update = db.Products.Where(pro => pro.Id == id).FirstOrDefault();
                Console.WriteLine("Enter Categoty ");
                Update.Category = Console.ReadLine();
                Console.WriteLine("Input the name of the product");
                Update.Productname = Console.ReadLine();
                Console.WriteLine("Input the name of the product");
               
                Console.WriteLine("Input the price");
                Update.Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the date");
                Update.Date=Convert.ToDateTime(Console.ReadLine());

                db.Products.Update(Update);
                db.SaveChanges();

                Console.WriteLine("The product  has been Updated");

                // *************************************************************************************************************************

                Console.WriteLine("provide id which you want to Read");
                id = Convert.ToInt32(Console.ReadLine());
                List<Product> CarsRead = db.Products.ToList();


                if (choice.Key == ConsoleKey.M )
                {
                    
                    db.Mobiles.Add(new Mobile(Category, Productname, Date, Price));
                    db.Companies.Add(new Company(location, Unit, place));
                    db.SaveChanges();

                    
                }
                else if (choice.Key == ConsoleKey.C )
                {
                    db.Laptops.Add(new Laptop(Category, Productname, Date, Price));
                    db.Companies.Add(new Company(location, Unit, place));
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("wrong choice try again!");

                }

                Console.WriteLine("");
                Console.WriteLine("sorted list");
               
                List<Product> sortedProducts = (from Product in db.Products orderby Product.Discriminator  select Product).ToList();
                id = 0;
                // Product PT = db.Products.Where(PT => PT.Id == id).FirstOrDefault();

               
                    //TimeSpan diff = DateTime.Now - Date;
                                  

                 
                
                foreach (Product Product in sortedProducts) // loop through the array
                {
                    TimeSpan diff = DateTime.Now - Product.Date;
                    //Console.WriteLine("{0}".PadRight(20), diff);

                    if (Product is Laptop)
                    {

                        if (diff.TotalDays >= 1004)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine(Product.Id.ToString().PadRight(4) + Product.GetType().Name.PadRight(20) + Product.Category.PadRight(20) + Product.Productname.PadRight(20) + Product.Price + "".PadRight(20) + Product.Date);
                            Console.ResetColor();
                        }
                        else if (diff.TotalDays >= 913)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.WriteLine(Product.Id.ToString().PadRight(4) + Product.GetType().Name.PadRight(20) + Product.Category.PadRight(20) + Product.Productname.PadRight(20) + Product.Price + "".PadRight(20) + Product.Date);
                            Console.ResetColor();
                        }
                         else
                        {
                            Console.WriteLine(Product.Id.ToString().PadRight(4) + Product.GetType().Name.PadRight(20) + Product.Category.PadRight(20) + Product.Productname.PadRight(20) + Product.Price + "".PadRight(20) + Product.Date);
                        }

                    }
                    if (Product is Mobile)
                    {
                        if (diff.TotalDays >= 1004)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine(Product.Id.ToString().PadRight(4) + Product.GetType().Name.PadRight(20) + Product.Category.PadRight(20) + Product.Productname.PadRight(20) + Product.Price + "".PadRight(20) + Product.Date);
                            Console.ResetColor();
                        }
                        else if (diff.TotalDays >= 913)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.WriteLine(Product.Id.ToString().PadRight(4) + Product.GetType().Name.PadRight(20) + Product.Category.PadRight(20) + Product.Productname.PadRight(20) + Product.Price + "".PadRight(20) + Product.Date);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine(Product.Id.ToString().PadRight(4) + Product.GetType().Name.PadRight(20) + Product.Category.PadRight(20) + Product.Productname.PadRight(20) + Product.Price + "".PadRight(20) + Product.Date);
                        }

                    }
                    



                }
                








            }             
                
                  

        }

        
    }

    class Product
    {
        public Product(string category, string productname, DateTime date, double price)
        {
            this.Category = category;
            this.Productname = productname;
            
            this.Price = price;

            this.Date = date;

        }
        public int Id { get; set; }

        public string Category { get; set; }
       
        public string Discriminator { get; set; }
        public DateTime date = new DateTime();
        

        public DateTime Date { get; set; }
        public string Productname { get; set; }
        public double Price { get; set; }

       

        public virtual string GetTypeOfProduct()
        {
            return "";
        }

    }
    class Laptop : Product
    {

        public Laptop(string category, string productname, DateTime date, double price) : base(category, productname, date, price)
        {
        }

        public override string GetTypeOfProduct()
        {
            return "Laptop";
        }
        public virtual string Type => "Laptop";
        public virtual string TypeOfProduct => "";

    }
    class Mobile : Product
    {
        public Mobile(string category, string productname, DateTime date, double price) : base(category, productname, date, price)
        {
        }



        public override string GetTypeOfProduct()
        {
            return "Mobile";
        }
        public virtual string Type => "Mobiles";
        public virtual string TypeOfProduct => "";


    }

    class Company
    {
        public Company(string location,string unit,string place)
        {
            Location = location;
            Unit = unit;
            Place = place;
           
        }

        public int Id { get; set; }
        //[Key]
        public string Location { get; set; }
        public string Unit { get; set; }
        public string Place { get; set; }
        
        
       
    }
    class ProductContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Miniproject2_EF21;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }

        public DbSet<Company> Companies { get; set; }

    }


}



