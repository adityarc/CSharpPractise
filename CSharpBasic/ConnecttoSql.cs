using System;

using System.Data;
using System.Data.SqlClient;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=CGI-JDN-01\\CGI;Initial Catalog=CGI;Integrated Security=true";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from CustomerDetails";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("Customer ID:\t" + dr[0].ToString());
                Console.WriteLine("Customer Name:\t" + dr["CustomerName"].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
