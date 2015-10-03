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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == textBox2.Text)
            {
                try
                {

                    SqlConnection conna = new SqlConnection(@"data source= localhost;initial catalog=ME;user=sa;password=ss");
                    conna.Open();
                    SqlCommand commc = new SqlCommand("Insert into Pass1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + label2.Text.Trim() + "','" + label1.Text.Trim() + "')", conna);
                    commc.ExecuteNonQuery();
                    conna.Close();

                }
                catch (Exception ox)
                {
                    throw ox;
                }
                MessageBox.Show("Done");
            }
            else
            {

                MessageBox.Show("Please Enter Valid User Name/Password Combination");
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString().ToString();
            label2.Text = DateTime.Now.ToLongDateString().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
