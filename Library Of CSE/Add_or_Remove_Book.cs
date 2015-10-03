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
    public partial class Add_or_Remove_Book : Form
    {
        public Add_or_Remove_Book()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"data source= localhost;initial catalog=ME;user=sa;password=ss");
                con.Open();
                SqlCommand com = new SqlCommand("insert into Book(Book_Id,Book_Name,Author_Name,Publications_Name,Place_of_publish,Year_of_Publish,Volumes,Edition,Pages,category) values('" + text_Id.Text.Trim() + "','" + txtTitle.Text.Trim() + "','" + txtAuthor.Text.Trim() + "','" + txtPub.Text.Trim() + "','" + txtPubP.Text.Trim() + "','" + txtPubYr.Text.Trim() + "','" + txtVol.Text.Trim() + "','" + txtEdi.Text.Trim() + "','" + txtPage.Text.Trim() + "','"+ text_Category.Text +"')", con);
                com.ExecuteNonQuery();
                //SqlCommand comm = new SqlCommand("insert into cata values('" + text_Id.Text + "','" + text_Category.Text + "') ", con);
                //comm.ExecuteNonQuery();
              
                con.Close();
                text_Id.Text = "";
                txtTitle.Text = "";
                txtAuthor.Text = "";
                txtPub.Text = "";
                txtPubP.Text = "";
                txtPubYr.Text = "";
                txtVol.Text = "";
                txtEdi.Text = "";
                txtPage.Text = "";
                text_Category.Text = "";

            }
            catch(Exception cow)
            {
                throw cow;
            }
        }

        private void lblPubY_Click(object sender, EventArgs e)
        {


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source= localhost;initial catalog=ME;user=sa;password=ss");
            conn.Open();
            SqlCommand comn = new SqlCommand("delete from book where Book_Id='" + texte_Id.Text.Trim() + "'", conn);
            comn.ExecuteNonQuery();
            //SqlCommand comnd = new SqlCommand("delete from cata where Book_Id='" + texte_Id.Text.Trim() + "'", conn);
            //comnd.ExecuteNonQuery();
            SqlCommand comnde = new SqlCommand("delete from catag where catad='" + text_Cata.Text + "'", conn);
            comnde.ExecuteNonQuery();
            conn.Close();
        }
        private void btnReturn_click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();

        }

        private void btnAction_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Action act = new Action();
            act.ShowDialog();
        }

        private void add_or_remove_book_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString().ToString();
            lblDate.Text = DateTime.Now.ToLongDateString().ToString();
        }
        
    }
}
