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
    public partial class Main : Form
    {
      
        public Main()
        {
            InitializeComponent();
        }

        private void btnRegister_MouseClick(object sender, MouseEventArgs e)
        {
            new Register().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TextBox td = new TextBox();
            TextBox tr = new TextBox();

            if (txtuser.Text == "" && txtpwd.Text=="")
            {
                MessageBox.Show("Enter A Valid User Name Password");
            }
            else
            {
            try
            {
                string str = @"data source= localhost;initial catalog=ME;user=sa;password=ss";

                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                string std = "select name,id from pass1 where id='"+txtpwd.Text+"'";
                SqlCommand commed = new SqlCommand(std,connection);
                SqlDataReader readd = commed.ExecuteReader();
                while (readd.Read())
                {
                    td.Text = readd[0].ToString();
                    tr.Text = readd[1].ToString();



                }
                connection.Close();
            }
            catch (Exception or)
            {
                throw or;
            }
            if (txtuser.Text == td.Text && txtpwd.Text == tr.Text)
            {
                this.Hide();
                Action ad = new Action();
                ad.ShowDialog();

            }
            else
            {
                MessageBox.Show(" ");
            
            }
            }
                

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}