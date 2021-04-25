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
    public partial class Form_UpdatePassword : Form
    {
        public Form_UpdatePassword()
        {
            InitializeComponent();
        }

        private void Form_UpdatePassword_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Savechanges_Click(object sender, EventArgs e)
        {
            Class_UpdatePassword update = new Class_UpdatePassword();

            int returned = update.UpdatePassword(Tb_OldpassData.Text, Tb_NewpassData.Text, Class_Login.AccountId);
            if (returned == 0)
            {
                Lbl_status.ForeColor = System.Drawing.Color.Red;
                Lbl_status.Text = "Please Enter Your Correct Old Password";
                Tb_OldpassData.Text = null;
                Tb_NewpassData.Text = null;

            }

            else
            {
                Lbl_status.ForeColor = System.Drawing.Color.Green;
                Lbl_status.Text = "Changes were saved!";
                Tb_OldpassData.Text = null;
                Tb_NewpassData.Text = null;
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            EmployeeHomepage backto = new EmployeeHomepage();
            backto.Show();
            this.Close();
        }
    }
}
