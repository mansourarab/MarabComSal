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
    public partial class Form_CustomerNewAccount : Form
    {
        public Form_CustomerNewAccount()
        {
            InitializeComponent();
        }

        private void Form_CustomerNewAccount_Load(object sender, EventArgs e)
        {

        }

        int? status;
        private void Btn_Checkavailability_Click(object sender, EventArgs e)
        {
            CustomerCheckAvailabilityClass check = new CustomerCheckAvailabilityClass();
            int? checkresult = check.CheckUsernameandEmailAvalability(tb_username.Text, tb_password.Text, out int? status);

            if (checkresult == 2)
            {
                lbl_status.ForeColor = System.Drawing.Color.Red;
                lbl_status.Text = "Username already exists, please type another one!";

            }

            if (checkresult == 3)
            {
                lbl_status.ForeColor = System.Drawing.Color.Red;
                lbl_status.Text = "Email already exists, please type another one!";

            }

            if (checkresult == 4)
            {

                lbl_status.ForeColor = System.Drawing.Color.Green;
                lbl_status.Text = "Account is available, go ahead and create it!";
                status = checkresult;
            }
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (status is null || status == 2 || status == 3)
            {
                MessageBox.Show("Please check availability...");
            }

            else
            {
                Class_CustomerNewAccount newacc = new Class_CustomerNewAccount();
                int CustomerNewAccount = newacc.CustomerNewAccount(tb_fullname.Text, Rbtn_Male.Checked, tb_phone.Text, tb_address.Text, tb_username.Text, tb_password.Text, tb_email.Text);

                if (CustomerNewAccount != 0)
                {
                    MessageBox.Show("Your account was Created successfully!");
                    Form_CustomerLogin forwardtologin = new Form_CustomerLogin();
                    forwardtologin.Show();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_CustomerLogin backtologin = new Form_CustomerLogin();
            backtologin.Show();
        }

        
    }
}
