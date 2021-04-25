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
    public partial class CustomerHomepage : Form
    {
        public CustomerHomepage()
        {
            InitializeComponent();
        }

        private void CustomerHomepage_Load(object sender, EventArgs e)
        {
            Lbl_user.Text = Class_Login.uname;
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_ViewInfo showme = new Form_ViewInfo();
            showme.Show();
            this.Close();

        }

        

        

        

        private void logOutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatePasswordEmailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_UpdatePassword change = new Form_UpdatePassword();
            change.Show();
            this.Close();
        }

        private void contactInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_UpdateContactInfo update = new Form_UpdateContactInfo();
            update.Show();
            this.Close();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
