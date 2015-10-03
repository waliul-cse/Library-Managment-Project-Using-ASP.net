using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Of_CSE
{
    public partial class Manage_Categories : Form
    {
        public Manage_Categories()
        {
            InitializeComponent();
        }

        private void Manage_Categories_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString().ToString();
            lblDate.Text = DateTime.Now.ToLongDateString().ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source= localhost;initial catalog=ME;user=sa;password=ss");
            con.Open();
            SqlCommand com = new SqlCommand("insert into catag values('" + txtCatName.Text + "')", con);
            com.ExecuteNonQuery();
            
            con.Close();
            txtCatName.Text = "";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Action act = new Action();
            act.ShowDialog();
        }
    }
}
