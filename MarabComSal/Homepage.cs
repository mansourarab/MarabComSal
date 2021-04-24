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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        int roro = 0;
        private void admintool(int roro)
        {
            if (roro == 0)
            {
                adminstratorAuthoritiesToolStripMenuItem.Visible = false;

            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
           
        }


    }
}
