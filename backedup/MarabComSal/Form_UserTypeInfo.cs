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
    public partial class Form_UserTypeInfo : Form
    {
        public Form_UserTypeInfo()
        {
            InitializeComponent();
        }

        private void Form_UserTypeInfo_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Employee_Click(object sender, EventArgs e)
        {
            Form_EmployeeLogin newlogin = new Form_EmployeeLogin();
            newlogin.Show();
            
        }

        private void Btn_Customer_Click(object sender, EventArgs e)
        {
            Form_CustomerLogin newlogin = new Form_CustomerLogin();
            newlogin.Show();

        }

        private void Btn_Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
