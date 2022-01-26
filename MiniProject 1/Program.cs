using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Globalization;

namespace mini_project_vasavi
{
    class Program
    {

        static void Main(string[] args)
        {
            


                List<data> Details = new List<data>();

                Console.WriteLine("enter now");

            
                while (true)
                {

                    //selecting store
                    Console.WriteLine("________________________");
                    toSimplify.store(Details);
                        toSimplify.print(Details);
                    Console.WriteLine("________________________");

                    string exit = "";
                    Console.WriteLine("To end the program press 'y'");
                    if (exit == "y")
                    {
                        exit = Console.ReadLine();
                        break;
                    }
                }
               
            
           
                
            
            
            Console.ReadLine();
            
        }


        class toSimplify
        {
            public static void store(List<data> Details)//select the store location and select the product type in this function
            {
                var choice = 0;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" select the store for tracking :(1)-India store  (2) Sweden Store  (3) US Store {select 1,2&3}");
                Console.ResetColor();
                choice = int.Parse(Console.ReadLine());

                while (true)
                {

                    if (choice == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Welcome to Indian store");
                        Console.ResetColor();
                        Console.WriteLine("select product type: computers/mobiles(PLEASE ENTER FULL NAME 'computers' AND 'mobiles' TO CONTINUE FURTHER)");
                        string productType = "";
                        productType = Console.ReadLine();
                        if (productType == string.Empty )
                        {
                            Console.WriteLine("Enter correct format of product type");
                        }
                        if (productType.ToLower().Trim() == "computers")
                        {

                            toSimplify.IndiaStoreInput(Details, "computers");

                        }
                        if (productType.ToLower().Trim() == "mobiles")
                        {
                            toSimplify.IndiaStoreInput(Details, "mobiles");

                        }
                        Console.WriteLine("do you want to add more products???? y/n");
                        string change = "";
                        change = Console.ReadLine();


                        if (change == "y")
                        {
                            Console.WriteLine("select product type: computers/mobiles(PLEASE ENTER FULL NAME 'computers' AND 'mobiles' TO CONTINUE FURTHER)");
                            productType = "";
                            productType = Console.ReadLine();
                            if (productType == string.Empty )
                            {
                                Console.WriteLine("Enter correct format of product type");
                            }
                            if (productType.ToLower().Trim() == "computers")
                            {

                                toSimplify.IndiaStoreInput(Details, "computers");


                            }
                            if (productType.ToLower().Trim() == "mobiles")
                            {
                                toSimplify.IndiaStoreInput(Details, "mobiles");


                            }

                        }
                        else
                        {
                            break;
                        }

                    }

                    if (choice == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("you choose Sweden store");
                        Console.ResetColor();
                        Console.WriteLine("select product type: computers/mobiles(PLEASE ENTER FULL NAME 'computers' AND 'mobiles' TO CONTINUE FURTHER)");
                        string productType = "";
                        productType = Console.ReadLine();
                        if (productType == string.Empty )
                        {
                            Console.WriteLine("Enter correct format of product type");
                        }
                        if (productType.ToLower().Trim() == "computers")
                        {

                            toSimplify.SwedenStoreInput(Details,"computers");

                        }
                        if (productType.ToLower().Trim() == "mobiles")
                        {
                            toSimplify.SwedenStoreInput(Details,"mobiles");

                        }
                        Console.WriteLine("do you want to add more products???? y/n");
                       string change = "";
                        change = Console.ReadLine();


                        if (change == "y")
                        {
                            Console.WriteLine("select product type: computers/mobiles(PLEASE ENTER FULL NAME 'computers' AND 'mobiles' TO CONTINUE FURTHER)");
                            productType = "";
                            productType = Console.ReadLine();
                            if (productType == string.Empty)
                            {
                                Console.WriteLine("Enter correct format of product type");
                            }
                            if (productType.ToLower().Trim() =="computers")
                            {

                                toSimplify.SwedenStoreInput(Details,"computers");
                                

                            }
                            if (productType.ToLower().Trim() == "mobiles")
                            {
                                toSimplify.SwedenStoreInput(Details,"mobiles");
                              

                            }

                        }
                        else
                        {
                            break;
                        }

                    }



                    if (choice == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("you choose US store");
                        Console.ResetColor();
                        Console.WriteLine("select product type: computers/mobiles(PLEASE ENTER FULL NAME 'computers' AND 'mobiles' TO CONTINUE FURTHER)");
                        string productType = "";
                        productType = Console.ReadLine();
                        if (productType == string.Empty )
                        {
                            Console.WriteLine("Enter correct format of product type");
                        }
                        if (productType.ToLower().Trim() =="computers")
                        {

                            toSimplify.Input(Details,"computers");
                            
                        }
                        if (productType.ToLower().Trim() == "mobiles")
                        {
                            
                            toSimplify.Input(Details,"mobiles");

                        }
                        Console.WriteLine("do you want to add more products???? y/n");
                        string change = "";
                        change = Console.ReadLine();

                        if (change == "y")
                        {
                            Console.WriteLine("select product type: computers/mobiles(PLEASE ENTER FULL NAME 'computers' AND 'mobiles' TO CONTINUE FURTHER)");
                            productType = "";
                            productType = Console.ReadLine();
                            if (productType == string.Empty )
                            {
                                Console.WriteLine("Enter correct format of product type");
                            }

                            if (productType.ToLower().Trim() == "computers")
                            {

                                toSimplify.Input(Details,"computers");
                                

                            }
                            if (productType.ToLower().Trim() == "mobiles")
                            {
                                toSimplify.Input(Details,"mobiles");
                                break;

                            }


                        }
                        else
                        {
                            break;
                        }
                    }


                    
                }
                return;
            }

            public static void Input(List<data> Details,string type)//this is userinput for US store(price in dollars) 
            {


                String category = "";
                String productName = "";
                double price = 0;
                DateTime dt = new DateTime();


                while (true)
                {
                    Console.Write("Enter category :   ");
                    category = Console.ReadLine();
                    if (category == string.Empty) //if category is empty
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("category should not be empty");
                        Console.ResetColor();
                        continue;
                    }
                    if (category.Any(char.IsDigit)) //if category is int
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("cetegory should not be a number");
                        Console.ResetColor();
                        continue;
                    }
                    if (category.ToLower().Trim() == "q")//if category is "q" go to next 
                    {
                        break;
                    }
                    else
                    {
                        try
                        {
                            Console.Write("Enter Name :   ");
                            productName = Console.ReadLine();
                            if (productName == string.Empty)//productname should not be empty
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("productName should not be empty");
                                Console.ResetColor();
                                continue;
                            }
                            if (productName.Any(char.IsDigit))//productname should be a string
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("productname should not be a number");
                                Console.ResetColor();
                                continue;
                            }
                            Console.Write("Enter the price :");
                            price = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Price in Dollars :{0:C}", price);
                            //Console.Write("The price in dollars ".PadRight(20)+ "{ 0:C}", price);


                            Console.WriteLine("");
                            dt = new DateTime(2022, 01, 11);
                            Console.Write("enter purchase date in format(yyyy,mm,dd):   ");


                            dt = DateTime.Parse(Console.ReadLine());

                            TimeSpan diff = DateTime.Now - dt;
                            Console.WriteLine("{0}".PadRight(20), diff);
                            if(dt>=DateTime.Today)//purchase date cannot have future date
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Purchase date cannot have future date");
                                Console.ResetColor();
                                continue;
                            }
                            if (diff.TotalDays >= 1004)//3 months away from 3 years (expired)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("product is expired {0}", dt);


                                Console.ResetColor();
                            }
                            else if (diff.TotalDays >= 913)//6 months away from 3 years(expired)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("product is expired {0}", dt);


                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("not expired");
                            }



                            
                            Console.WriteLine(category + " " + productName + " " + "{0:C}", price + " " + dt);
                            if (type == "computers")
                            {
                                // Details.Add(new data(category, productName, price, dt));
                                Details.Add(new Computer(category, productName, price, dt));

                            }
                            else if (type == "mobiles")
                            {
                                Details.Add(new mobile(category, productName, price, dt));
                            }

                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }


                    }
                }
            }
            public static void print(List<data> Details)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("producttype".PadRight(20) + "category".PadRight(20) + " " + "productName".PadRight(20) + " " + "price " + "".PadRight(20) + "date");
                Console.ResetColor();
                //string productType = "";
                //productType = Console.ReadLine();
                List<data> sortedList = Details.OrderBy(productType => productType.GetType().Name).ThenBy(productType => productType.dateTime).ToList();//sorting from low price to high price

                foreach (data PT in sortedList) //getting sorted list from 
                {
                    if (PT is Computer)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine((PT as Computer).GetTypeOfProduct().PadRight(20) + PT.Category.PadRight(20) + " " + PT.Productname.PadRight(20) + " " + PT.Price + "".PadRight(20) + PT.dateTime);
                        Console.ResetColor();
                    }
                    else if (PT is mobile)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine((PT as mobile).GetTypeOfProduct().PadRight(20) + PT.Category.PadRight(20) + " " + PT.Productname.PadRight(20) + " " + PT.Price + "".PadRight(20) + PT.dateTime);
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                double sumOfPrizes = Details.Sum(userData => userData.Price);//summarizing the prices
                Console.WriteLine("sum of prices:{0:C}".PadRight(20), sumOfPrizes);
                Console.ResetColor();

            }//printing the input 
            public static void IndiaStoreInput(List<data> Details, string type)//contains user input for the store India(price nby default entered in dollars but convered to rupees insdie the function)
            {


                String category = "";
                String productName = "";
                double price = 0;
                DateTime dt = new DateTime();


                while (true)
                {
                    Console.Write("Enter category :   ");
                    category = Console.ReadLine();
                    if (category == string.Empty) //if category is empty
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("category should not be empty");
                        Console.ResetColor();
                        continue;
                    }
                    if (category.Any(char.IsDigit)) //if category is int
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("category should not be a number");
                        Console.ResetColor();
                        continue;
                    }
                    if (category.ToLower().Trim() == "q")//if category is "q" go to next 
                    {
                        break;
                    }
                    else
                    {
                        try
                        {
                            Console.Write("Enter Name :   ");
                            productName = Console.ReadLine();
                            if (productName == string.Empty)//productname should not be empty
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("productName should not be empty");
                                Console.ResetColor();
                                continue;
                            }
                            if (productName.Any(char.IsDigit))//productname should be a string
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("productname should not be a number");
                                Console.ResetColor();
                                continue;
                            }
                           
                            Console.Write("enter the price in dollars : ");
                            price = Convert.ToDouble(Console.ReadLine());

                            double val = 73.95;
                            price = price * val;
                            Console.Write("price in ruppes".PadRight(20)+"{0}", price);



                             Console.WriteLine("");
                            dt = new DateTime(2022, 01, 11);
                            Console.Write("enter purchase date in format(yyyy,mm,dd):   ");


                            dt = DateTime.Parse(Console.ReadLine());

                            TimeSpan diff = DateTime.Now - dt;
                            Console.WriteLine("{0}".PadRight(20), diff);
                            if (dt >= DateTime.Today)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Purchase date cannot have future date");
                                Console.ResetColor();
                                continue;
                            }

                            if (diff.TotalDays >= 1004)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("product is expired {0}".PadRight(20), dt);


                                Console.ResetColor();
                            }
                            else if (diff.TotalDays >= 913)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("product is expired {0}".PadRight(20), dt);


                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("not expired");
                            }



                            Console.WriteLine(category + " " + productName + " " + "{0:C}", price + " " + dt);
                            if (type == "computers")
                            {
                                // Details.Add(new data(category, productName, price, dt));
                                Details.Add(new Computer(category, productName, price, dt));

                            }
                            else if (type == "mobiles")
                            {
                                Details.Add(new mobile(category, productName, price, dt));
                            }

                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                       
                    }
                }
            }
            public static void SwedenStoreInput(List<data> Details,string type)//contains user input for the store Sweden(price nby default entered in dollars but convered to SEK insdie the function)
            {


                String category = "";
                String productName = "";
                double price = 0;
                DateTime dt = new DateTime();


                while (true)
                {
                    Console.Write("Enter category :   ");
                    category = Console.ReadLine();
                    if (category == string.Empty) //if category is empty
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("category should not be empty");
                        Console.ResetColor();
                        continue;
                    }
                    if (category.Any(char.IsDigit)) //if category is int
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("cetegory should not be a number");
                        Console.ResetColor();
                        continue;
                    }
                    if (category.ToLower().Trim() == "q")//if category is "q" go to next 
                    {
                        break;
                    }
                    else
                    {
                        try
                        {
                            Console.Write("Enter Name :   ");
                            productName = Console.ReadLine();
                            if (productName == string.Empty)//productname should not be empty
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("productName should not be empty");
                                Console.ResetColor();
                                continue;
                            }
                            if (productName.Any(char.IsDigit))//productname should be a string
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("productname should not be a number");
                                Console.ResetColor();
                                continue;
                            }
                           

                            

                            Console.Write("enter the price in dollars : ");
                            price = Convert.ToDouble(Console.ReadLine());

                           double val = 8.94;
                            price = price * val;
                          
                            Console.Write("price in SEK".PadRight(20) + "{0}", price);
                           
                            Console.WriteLine("");
                            dt = new DateTime(2022, 01, 11);
                            Console.Write("enter purchase date in format(yyyy,mm,dd):   ");


                            dt = DateTime.Parse(Console.ReadLine());

                            TimeSpan diff = DateTime.Now - dt;
                            Console.WriteLine("{0}".PadRight(20), diff);
                            if (dt >= DateTime.Today)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Purchase date cannot have future date");
                                Console.ResetColor();
                                continue;
                            }
                            if (diff.TotalDays >= 1004)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("product is expired {0}", dt);


                                Console.ResetColor();
                            }
                            else if (diff.TotalDays >= 913)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("product is expired {0}", dt);


                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("not expired");
                            }



                            Console.WriteLine(category + " " + productName + " " + "{0:C}", price + " " + dt);
                            if (type == "computers")
                            {
                               // Details.Add(new data(category, productName, price, dt));
                                Details.Add(new Computer(category, productName, price, dt));
                                
                            }
                            else if(type=="mobiles")
                            {
                                Details.Add(new mobile(category, productName, price, dt));
                            }



                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }


                    }
                }
            }

            public static void Computerlist(List<data> Details)
            {
                string category = "";
                string productName = "";
                double price = 0;
                DateTime dt=DateTime.Parse("");

                data productType = new Computer(category, productName, price, dt);
                Details.Add(productType);
                Console.WriteLine("list of computers ");
                Console.WriteLine("category".PadRight(20) + " " + "productName".PadRight(20) + " " + "price " + "".PadRight(20) + "date");
                Console.WriteLine(productType.Category.PadRight(20) + " " + productType.Productname.PadRight(20) + " " + productType.Price + "".PadRight(20) + productType.dateTime);

            }
           public static void Mobilelist(List<data> Details)
            {
                string category = "";
                string productName = "";
                double price = 0;
                DateTime dt = DateTime.Parse("");

                data productType = new mobile(category, productName, price, dt);

                Details.Add(productType);
                Console.WriteLine("list of computers ");
                Console.WriteLine("category".PadRight(20) + " " + "productName".PadRight(20) + " " + "price " + "".PadRight(20) + "date");
                Console.WriteLine(productType.Category.PadRight(20) + " " + productType.Productname.PadRight(20) + " " + productType.Price + "".PadRight(20) + productType.dateTime);

            }
            

        }

        class data
        {
            public data(string category, string productName, double price, DateTime dt)
            {
                this.Category = category;
                this.Productname = productName;
                this.Price = price;
                this.dateTime = dt;
            }
            public string Category { get; set; }
            public string Productname { get; set; }
            public double Price { get; set; }
            public DateTime dateTime { get; set; }

            public virtual string GetTypeOfProduct()
            {
                return "";
            }

          


        }


        class Computer : data
        {
            public Computer(string category, string productName, double price, DateTime dt) : base(category, productName, price, dt)
            {

            }
            public override string GetTypeOfProduct()
            {
                return "computer";
            }
        }

        class mobile : data
        {
            public mobile(string category, string productName, double price, DateTime dt) : base(category, productName, price, dt)
            {

            }
            public int ProductSize { get; set; }
            public override string GetTypeOfProduct()
            {
                return "mobile";
            }
        }


    }
}