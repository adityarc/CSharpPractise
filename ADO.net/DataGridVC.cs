using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace AdoBeginner
{
    public partial class DataGridVC : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CGICon"].ConnectionString);
        public DataGridVC()
        {
            InitializeComponent();
        }

        private void DataGridVC_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Select distinct city from CustomerDetails", con);
            
            if(con.State == ConnectionState.Closed)
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.HasRows)
            {
                cbCity.Text = "--Select--";
                while(rdr.Read())
                {
                    cbCity.Items.Add(rdr["City"].ToString());
                }
            }
            rdr.Close();
            //DataTable dt = new DataTable();
            //dt.Load(rdr);
            //cbCity.DataSource = dt;
            //cbCity.DisplayMember = "City";

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CGICon"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("Select distinct city from CustomerDetails", con);

            //if (con.State == ConnectionState.Closed)
            //    con.Open();
            //SqlDataReader rdr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(rdr);
            //dgvCustomer.DataSource = dt;

        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("Select * from CustomerDetails where City=@City", con);
            cmd.Parameters.AddWithValue("@City", cbCity.SelectedItem.ToString());
            SqlDataReader rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rdr);
            dgvCustomer.DataSource = dt;
            con.Close();
        }
    }
}
