﻿using System;
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
    public partial class Homepage : Form
    {
        public Homepage()
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
            Form_ContactInfo update = new Form_ContactInfo();
            update.Show();
            this.Close();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
