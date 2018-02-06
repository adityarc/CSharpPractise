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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //All method events by default have 2 parameters.
        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin123" && comboBox1.SelectedItem.ToString() == "Admin")
            {
                MessageBox.Show("Welcome, " + txtUsername.Text);
                frmDetails obj = new frmDetails();
                obj.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "employee" && txtPassword.Text == "emp123" && comboBox1.SelectedItem.ToString() == "Employee")
            {
                MessageBox.Show("Welcome, " + txtUsername.Text);
                lblEmployeeWelcome obj = new lblEmployeeWelcome();
                obj.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid user or Password!");
        }
    }
}
