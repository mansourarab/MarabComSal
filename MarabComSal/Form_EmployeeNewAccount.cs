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
    public partial class Form_EmployeeNewAccount : Form
    {
        public Form_EmployeeNewAccount()
        {
            InitializeComponent();
        }

        public static int? status;
        private void Btn_Checkavailability_Click(object sender, EventArgs e)
        {
            Class_CheckAvailability check = new Class_CheckAvailability();
            int? checkresult = check.CheckUsernameandEmailAvalability(Tb_Username.Text, Tb_Password.Text);

            if (checkresult == 1)
            {
                lbl_status.ForeColor = System.Drawing.Color.Red;
                lbl_status.Text = "Username or Email already exists, please type another one!";

            }



            if (checkresult == 0)
            {

                lbl_status.ForeColor = System.Drawing.Color.Green;
                lbl_status.Text = "Account is available, go ahead and create it!";
                Form_EmployeeNewAccount.status = checkresult;
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
                Class_NewAccount newaccount = new Class_NewAccount();
                int EmployeeNewAccount = newaccount.EmployeeNewAccount(Tb_Fullname.Text, Rbtn_Male.Checked, Tb_Phone.Text, Tb_Address.Text, Tb_Username.Text, Tb_Password.Text, Tb_Email.Text, Tb_Department.Text);

                if (EmployeeNewAccount != 0)
                {
                    MessageBox.Show("Your account was Created successfully!");
                    Form_Login forwardtologin = new Form_Login();
                    this.Close();
                    forwardtologin.Show();
                }
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            EmployeeHomepage backto = new EmployeeHomepage();
            this.Close();
            backto.Show();
        }

        private void Form_EmployeeNewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
