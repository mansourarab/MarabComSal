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
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
        }

        private void Form_UserTypeInfo_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Employee_Click(object sender, EventArgs e)
        {
            Form_Login newlogin = new Form_Login();
            newlogin.Show();
            
        }

        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            Form_Login newlogin = new Form_Login();
            newlogin.Show();

        }

        private void Btn_Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
