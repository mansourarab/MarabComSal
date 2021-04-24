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
    public partial class Form_ViewInfo : Form
    {
        public Form_ViewInfo()
        {
            InitializeComponent();
        }

        private void Form_ViewInfo_Load(object sender, EventArgs e)
        {
            Class_CustomerLogin newid = new Class_CustomerLogin();
            int? AID;
            int result = acc.CheckUserExists(txtUserName.Text, txtPassword.Text, out SID);
        }
    }
}
