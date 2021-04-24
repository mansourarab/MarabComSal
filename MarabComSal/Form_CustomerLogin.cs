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
    public partial class Form_CustomerLogin : Form
    {
        public Form_CustomerLogin()
        {
            InitializeComponent();
        }

        private void Form_CustomerLogin_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            CustomerLoginClass clogin = new CustomerLoginClass();
            int? AccountId;
            int result = clogin.CheckUser(Tb_Username.Text, Tb_Password.Text, out AccountId);
            if (result == 1)
            {
                lbl_status.ForeColor = System.Drawing.Color.Green;
                lbl_status.Text = "Loggied in Successfully!";

                CustomerLoginClass.AccountId = AccountId;

                Homepage Hform = new Homepage();
                Hform.Show();

            }
            else
            {
                lbl_status.ForeColor = System.Drawing.Color.Red;
                lbl_status.Text = "Invalid Info";
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form_UserTypeInfo getback = new Form_UserTypeInfo();
            getback.Show();
        }

        private void Linlbl_Newaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_CustomerNewAccount newaccount = new Form_CustomerNewAccount();
            newaccount.Show();

        }
    }
}
