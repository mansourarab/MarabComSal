using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarabComSal
{
    public partial class EmployeeHomepage : Form
    {
        public EmployeeHomepage()
        {
            InitializeComponent();
        }
        

        private void Homepage_Load(object sender, EventArgs e)
        {
           
        }


        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_ViewInfo window = new Form_ViewInfo();
            window.Show();
            this.Close();

             
        }

        
        private void updatePasswordEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UpdatePassword change = new Form_UpdatePassword();
            change.Show();
            this.Close();
        }

        private void contactInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UpdateContactInfo update = new Form_UpdateContactInfo();
            update.Show();
            this.Close();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
      

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Class_Login.UserType == "Adminstrator")
            {
                Form_EmployeeNewAccount newaccount = new Form_EmployeeNewAccount();
                newaccount.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("You're not authorised for this task");

            }
        }

        private void modifyAndDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Class_Login.UserType == "Adminstrator")
            {
                Form_ModifyAccount memo = new Form_ModifyAccount();
                memo.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("You're not authorised for this task");

            }
        }

       
       
    }
}
