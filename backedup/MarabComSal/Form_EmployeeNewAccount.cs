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

        int? status;
        private void Btn_Checkavailability_Click(object sender, EventArgs e)
        {
            Class_EmployeeCheckAvailability check = new Class_EmployeeCheckAvailability();
            int? checkresult = check.CheckUsernameandEmailAvalability(Tb_Username.Text, Tb_Password.Text, out int? status);

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
                Class_EmployeeNewAccount newaccount = new Class_EmployeeNewAccount();
                int EmployeeNewAccount = newaccount.EmployeeNewAccount(Tb_Fullname.Text, Rbtn_Male.Checked, Tb_Phone.Text, Tb_Address.Text, Tb_Username.Text, Tb_Password.Text, Tb_Email.Text, Tb_Department.Text);

                if (EmployeeNewAccount != 0)
                {
                    MessageBox.Show("Your account was Created successfully!");
                    Form_EmployeeLogin forwardtologin = new Form_EmployeeLogin();
                    this.Close();
                    forwardtologin.Show();
                }
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Form_EmployeeLogin backtologin = new Form_EmployeeLogin();
            this.Close();
            backtologin.Show();
        }

        private void Form_EmployeeNewAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
