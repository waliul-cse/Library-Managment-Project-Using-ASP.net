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
    public partial class Search_Book : Form
    {
        public Search_Book()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                     
            this.Close();
            this.Dispose();
            Application.Exit();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strd = @"data source= localhost;initial catalog=ME;user=sa;password=ss";

            SqlConnection connecti = new SqlConnection(strd);
            connecti.Open();
            string sel = "select Book_Id,Book_Name,Author_Name,Edition from Book WHERE  category='" + comboBox_Category.Text.Trim() + "' and Book_Name='" + text_search.Text + "'";
            SqlDataAdapter addd = new SqlDataAdapter(sel, connecti);
            DataTable tab = new DataTable();
            addd.Fill(tab);
           
            dataGridView2.DataSource =tab ;

            connecti.Close();
        }

        private void Search_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scriptDataSet.Book' table. You can move, or remove it, as needed.
           // this.bookTableAdapter.Fill(this.scriptDataSet.Book);
            string str = @"data source= localhost;initial catalog=ME;user=sa;password=ss";

            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string std = "select * from catag ";
            SqlCommand commed = new SqlCommand(std, connection);
            SqlDataReader readda = commed.ExecuteReader();
            while (readda.Read())
            {

                comboBox_Category.Items.Add(readda[0].ToString());



            }
            readda.Close();
            //connection.Close();

            string sel = "select Book_Id,Book_Name,Author_Name,Edition from Book ";
            SqlDataAdapter addd = new SqlDataAdapter(sel, connection);
            DataTable tab = new DataTable();
            addd.Fill(tab);

            dataGridView2.DataSource = tab;
            connection.Close();

            lblTime.Text = DateTime.Now.ToLongTimeString().ToString();
            lblDate.Text = DateTime.Now.ToLongDateString().ToString();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
           
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Action act = new Action();
            act.ShowDialog();
        }
    }
}
