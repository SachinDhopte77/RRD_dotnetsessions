using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace MySQL_SamplePOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string cs = @"server=DESKTOP-7MAM3KF;userid=sachin;password=Pa$$w0rd;database=rrd_db";

            using var con = new MySqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM todolist_db";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0} | {1} | {2} | {3}", rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3));
            }
        }
    }
}
