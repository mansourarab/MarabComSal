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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_CustomerLogin_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Class_Login newlogin = new Class_Login();
            int? AccountId;
            string UserType;
            string Uname;

            int result =newlogin.CheckUser(Tb_Username.Text, Tb_Password.Text, out AccountId, out UserType, out Uname);
            if (result == 1)
            {
                lbl_status.ForeColor = System.Drawing.Color.Green;
                lbl_status.Text = "Loggied in Successfully!";

                Class_Login.AccountId = AccountId;
                Class_Login.UserType = UserType;
                Class_Login.uname = Uname;

                if (UserType == "Employee" || UserType == "Adminstrator")
                {
                    EmployeeHomepage Hform = new EmployeeHomepage();
                    this.Close();
                    Hform.Show();
                }

                if (UserType == "Customer")
                {
                    CustomerHomepage Hform = new CustomerHomepage();
                    this.Close();
                    Hform.Show();
                }

            }
            else
            {
                lbl_status.ForeColor = System.Drawing.Color.Red;
                lbl_status.Text = "Invalid Info";
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            
        }

        private void Linlbl_Newaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_CustomerNewAccount newaccount = new Form_CustomerNewAccount();
            this.Close();
            newaccount.Show();

        }
    }
}
