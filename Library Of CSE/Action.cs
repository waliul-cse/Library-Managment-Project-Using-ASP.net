using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Of_CSE
{
    public partial class Action : Form
    {
        public Action()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (radioButton1.Checked == true)
            {
                
                new Search_Book().ShowDialog();
                
            }
            if (radioButton2.Checked == true)
            {
                new Manage_Categories().Show();
            }
            if (radioButton3.Checked == true)
            {
                new Add_or_Remove_Book().Show();
            }
            if (radioButton4.Checked == true)
            {
                new Report().Show();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Action_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString().ToString();
            lblDate.Text = DateTime.Now.ToLongDateString().ToString();
        }
       
        
     }
 }

            
            
            
 
            
            

        
    

