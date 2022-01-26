using System;
using System.Data.SqlClient;

namespace ConsoleApp_ADO_Car_CRUD_20220118
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cars CRUD!");
            //CRUD
            //C - Create
            //CreateToDatabase();
            //R - Read
            ReadFromDatabase();
            //U - Update
            UpdateInDatabase();
            //D - Delete
            //DeleteFromDatabase();


            ReadFromDatabase();
            Console.ReadLine();
        }

        private static void DeleteFromDatabase()
        {
            Console.WriteLine("Delete data in Car database");
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Car WHERE Id=@id", connection))
                {
                    command.Parameters.AddWithValue("@id", 2);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void UpdateInDatabase()
        {
            int updatedRows;
            Console.WriteLine("Update data in Car database");
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Car SET Year=@year WHERE Id=@id", connection))
                {
                    command.Parameters.AddWithValue("@id", 2);
                    command.Parameters.AddWithValue("@year", 1977);
                    updatedRows = command.ExecuteNonQuery();
                }
            }
            if (updatedRows == 0)
            {
                Console.WriteLine("Nothing to update!");
            }
            else
            {
                Console.WriteLine("Updated!");
            }
        }

        private static void ReadFromDatabase()
        {
            Console.WriteLine("Read data from Car database");
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Car", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]);
                        int id = reader.GetInt32(0);
                        string brand = reader.GetString(1);
                        string model = reader.GetString(2);
                        int year = reader.GetInt32(3);

                        Console.WriteLine(id + " " + brand + " " + model + " " + year);
                    }
                }

            }
        }

        private static void CreateToDatabase()
        {
            Console.WriteLine("Create data in Car database");
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new
                    SqlCommand("INSERT INTO Car(Brand, Model, Year) VALUES(@brand, @model, @year)",
                    connection))
                {
                    command.Parameters.AddWithValue("@brand", "BMW");
                    command.Parameters.AddWithValue("@model", "2002 ti");
                    command.Parameters.AddWithValue("@year", 1975);
                    command.ExecuteNonQuery();
                }

            }

        }
    }
}
