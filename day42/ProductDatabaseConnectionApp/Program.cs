
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace ProductDatabaseConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CRUD Operatiom

            //CaseStudy2ReadDB(); //Read DB value
            // CaseStudy3InsertIntoDB(); //Insert in to DB
            //CaseStudy3UpdateDB(); //Update into DB
            CaseStudy4DeleteFromDB();
        }

        private static void CaseStudy4DeleteFromDB()
        {
           
            var connectionString = "server=.\\sqlexpress;database=rrd_db;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("delete product where id=4", con);
            con.Open();
            var reader = cmd.ExecuteNonQuery();
            Console.WriteLine("Database Records Deleted ");
            con.Close();
        }

        private static void CaseStudy3UpdateDB()
        {
            int newQuantity=15;
            var connectionString = "server=.\\sqlexpress;database=rrd_db;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("update product"+" set quantity = "+newQuantity+" where id =4", con);
            con.Open();
            var reader = cmd.ExecuteNonQuery();
            Console.WriteLine("Database updated ");
            con.Close();
        }

        private static void CaseStudy3InsertIntoDB()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd= new SqlCommand("insert into "+"Product"+"(name, quantity, price)"+" values('Mobile', 25, 1000)", con);
            con.Open();
            var reader = cmd.ExecuteNonQuery();
            Console.WriteLine("Database updated with insertion");
            con.Close();

        }

        //private static void CaseStudy1()
        //{
        //    var connectionString = "server=.\\sqlexpress;database=rrd_db;Integrated security=true;TrustServerCertificate=true";
        //    var con = new SqlConnection(connectionString);
        //    con.Open();
        //    Console.WriteLine("Connection is open to :");
        //    Console.WriteLine(con.Database);
        //    Console.WriteLine("Connection State is : ");
        //    Console.WriteLine(con.State);
        //    con.Close();
        //    Console.WriteLine("Connection Closed");

        //}
        private static void CaseStudy2ReadDB()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("select * from" +
                " product", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["name"]);
                Console.WriteLine(reader["quantity"]);
                Console.WriteLine(reader["price"]);

            }
            con.Close();
        }

    }
}
