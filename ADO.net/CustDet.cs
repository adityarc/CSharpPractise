using System;

using System.Data;




using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace AdoBeginner
{
    public partial class CustDet : Form
    {
        public CustDet()
        {
            InitializeComponent();
        }
       // int btnflag = 0;
        private void CustDet_Load(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=CGI-JDN-01\\CGI;Initial Catalog=CGI;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("Select * from CustomerDetails where CustomerID=@CustomerID", con);
            cmd.Parameters.AddWithValue("@CustomerID", txtCID.Text);
            
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
           

            if(rdr.HasRows)
            {
                rdr.Read();

                //txtCID.Text = rdr["CustomerID"].ToString();
                txtCname.Text = rdr["CustomerName"].ToString();
                txtCCity.Text = rdr["City"].ToString();
                txtCPno.Text = rdr["MobileNo"].ToString();
                

            }
            else
            {
                MessageBox.Show("Record Doesn't Exist!");
                
            }
            rdr.Close();
            con.Close();
        }
    }
}
