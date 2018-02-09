using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoBeginner
{
    public partial class wefform : Form
    {
        public wefform()
        {
            InitializeComponent();
        }

        public void BindGrid()
        {
            CGIEntities obj = new CGIEntities();

            var query = from customer in obj.CustomerDetails
                        select new {
                CustomerID = customer.CustomerID,
                CustomerName = customer.CustomerName,
                CustomerPhone = customer.MobileNo,
                CustomerEmail = customer.EmailID
                
            };
            dataGridView1.DataSource = query.ToList();
        }
        private void wefform_Load(object sender, EventArgs e)
        {

            this.BindGrid();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            CGIEntities obj = new CGIEntities();
            var query = (from customer in obj.CustomerDetails where customer.CustomerID == txtCustID.Text select customer).SingleOrDefault();
            if(query != null)
            {
                txtCustID.Text = query.CustomerID;
                txtCustName.Text = query.CustomerName;
                txtEmail.Text = query.EmailID;
                txtMobileNo.Text = query.MobileNo;
                
            }
            else
            {
                MessageBox.Show("Record Not Found.");

            }
            this.BindGrid();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CGIEntities obj = new CGIEntities();
            CustomerDetail cd = new CustomerDetail();
            cd.CustomerID = txtCustID.Text;
            cd.EmailID = txtEmail.Text;
            cd.CustomerName = txtCustName.Text;
            cd.MobileNo = txtMobileNo.Text;
            obj.CustomerDetails.Add(cd);
            int res = obj.SaveChanges();
            if(res > 0)
            {
                MessageBox.Show("Success.");
                this.BindGrid();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CGIEntities obj = new CGIEntities();
            CustomerDetail cd = new CustomerDetail();
            cd = obj.CustomerDetails.Find(txtCustID.Text);
            cd.EmailID = txtEmail.Text;
            cd.MobileNo = txtMobileNo.Text;
            cd.CustomerName = txtCustName.Text;

            int res = obj.SaveChanges(); //update database
            if(res > 0)
            {
                MessageBox.Show("Success.");
                this.BindGrid();
            }
          }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CGIEntities obj = new CGIEntities();
            CustomerDetail cd = new CustomerDetail();
            cd = obj.CustomerDetails.Find(txtCustID.Text);
            obj.CustomerDetails.Remove(cd);
            int res = obj.SaveChanges();
            if(res > 0)
            {
                MessageBox.Show("Record Deleted.");
                this.BindGrid();
            }
        }
    }
}
