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

        public static int? status;
        private void Btn_Checkavailability_Click(object sender, EventArgs e)
        {
            Class_CheckAvailability check = new Class_CheckAvailability();
            int? checkresult = check.CheckUsernameandEmailAvalability(Tb_Username.Text, Tb_Email.Text);
            
            if (checkresult == 1)
            {
                lbl_status.ForeColor = System.Drawing.Color.Red;
                lbl_status.Text = "Username or Email already exists, please type another one!";

            }

          

            if (checkresult == 0)
            {

                lbl_status.ForeColor = System.Drawing.Color.Green;
                lbl_status.Text = "Account is available, go ahead and create it!";
                Form_CustomerNewAccount.status = checkresult;
            }
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (status is null)
            {
                
                MessageBox.Show("Please check availability...");
            }

            else
            {
                Class_NewAccount newacc = new Class_NewAccount();
                int CustomerNewAccount = newacc.CustomerNewAccount(tb_fullname.Text, Rbtn_Male.Checked, tb_phone.Text, tb_address.Text, Tb_Username.Text, tb_password.Text, Tb_Email.Text);

                if (CustomerNewAccount != 0)
                {
                    MessageBox.Show("Your account was Created successfully!");
                    Form_CustomerLogin forwardtologin = new Form_CustomerLogin();
                    this.Close();
                    forwardtologin.Show();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_CustomerLogin backtologin = new Form_CustomerLogin();
            this.Close();
            backtologin.Show();

        }

        
    }
}
