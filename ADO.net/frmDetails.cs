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
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        private void frmDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //private void frmDetails_Load(object sender, EventArgs e)
        //{

        //}
    }
}
