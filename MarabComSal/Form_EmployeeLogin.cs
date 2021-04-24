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
    public partial class Form_EmployeeLogin : Form
    {
        public Form_EmployeeLogin()
        {
            InitializeComponent();
        }

        private void Form_EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            EmployeeLoginClass elogin = new EmployeeLoginClass();
            int? AccountId;
            int result = elogin.CheckUser(Tb_Username.Text, Tb_Password.Text, out AccountId);
            if (result == 1)
            {
                Lbl_Status.ForeColor = System.Drawing.Color.Green;
                Lbl_Status.Text = "Loggied in Successfully!";

                EmployeeLoginClass.AccountId = AccountId;

                Homepage Hform = new Homepage();
                Hform.Show();

            }
            else
            {
                Lbl_Status.ForeColor = System.Drawing.Color.Red;
                Lbl_Status.Text = "Invalid Info";
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form_UserTypeInfo getback = new Form_UserTypeInfo();
            getback.Show();

        }
    }
}
