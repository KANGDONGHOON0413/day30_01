
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day30_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "server=\\SQLEXPRESS;database=test;uid=sa;password=alencia";
            Conn.Open();
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM testTable01", Conn);
            SqlDataReader Reader = sqlcmd.ExecuteReader();
            while (Reader.Read())
            {
                Console.WriteLine($"{Reader["Nid"]}\t{Reader[1]}\t{Reader[2]}\t{Reader[3]}");
            }
            Reader.Close();
            Conn.Close();
        }
    }
}
