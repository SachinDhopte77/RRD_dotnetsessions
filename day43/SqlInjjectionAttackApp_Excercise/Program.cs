
using System.Data.SqlClient;

namespace SqlInjjectionAttackApp_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();  // Sql injection Attack study
        }

        private static void CaseStudy1()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db;Integrated security=true;TrustServerCertificate=true";
            var con = new SqlConnection(connectionString);

            Console.WriteLine("Enter a User ID :");
            var UserID = Console.ReadLine();

            var cmd = new SqlCommand("select * from AppUser where UserName = @AppUserID", con);//step1 create a parameter
            cmd.Parameters.AddWithValue("@AppUserID", UserID);//step 2;
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Console.WriteLine("AppUser :" +reader["UserName"] + " Password : " + reader["PASSWORD"]);
            }
            con.Close();
        }
    }
}
