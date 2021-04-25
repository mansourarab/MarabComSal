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
    public partial class Form_ModifyAccount : Form
    {
        public Form_ModifyAccount()
        {
            InitializeComponent();
        }



        private void Form_ModifyAccount_Load(object sender, EventArgs e)
        {
            Class_Info adt = new Class_Info();
            DataTable Accountdata = adt.ViewAccountTable();
            if (Accountdata.Rows.Count != 0)
            {
                Dgv_Acc.DataSource = Accountdata;
            }

            Class_Info edt = new Class_Info();
            DataTable Empdata = edt.ViewEmployeeTable();
            if (Empdata.Rows.Count != 0)
            {
                Dgv_Emp.DataSource = Empdata;
            }

            Class_Info cdt = new Class_Info();
            DataTable Cusdata = cdt.ViewCustomerTable();
            if (Cusdata.Rows.Count != 0)
            {
                Dgv_Cus.DataSource = Cusdata;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Class_NewAccount modify = new Class_NewAccount();
            Tb_Username = null;
            Tb_Delete = null;

            if (Tb_Username != null && Tb_Delete != null)
            {
                int modified = modify.ModifyDeleteAccount(Tb_Username.Text, Tb_fullname.Text, Tb_Address.Text, Tb_Phone.Text, Tb_Gender.Text, Tb_Department.Text, Tb_CompanyEmail.Text, Tb_Delete.Text, Tb_Adminusername.Text, Tb_AdminPassword.Text);

                if (modified == 1)
                {
                    Lbl_status.ForeColor = System.Drawing.Color.Green;
                    Lbl_status.Text = "Changes were carried successfully!";
                }

                if (modified == 0)
                {
                    Lbl_status.ForeColor = System.Drawing.Color.Red;
                    Lbl_status.Text = "Something went wrong, please re-do the work!";

                }
            }

            if (Tb_Username == null && Tb_Delete != null)
            {
                int modified = modify.DeleteAccount(Tb_Delete.Text, Tb_Adminusername.Text, Tb_AdminPassword.Text);

                if (modified == 1)
                {
                    Lbl_status.ForeColor = System.Drawing.Color.Green;
                    Lbl_status.Text = "Changes were carried successfully!";
                }

                if (modified == 0)
                {
                    Lbl_status.ForeColor = System.Drawing.Color.Red;
                    Lbl_status.Text = "Something went wrong, please re-do the work!";

                }
            }

            if (Tb_Username != null && Tb_Delete == null)
            {
                int modified = modify.ModifyAccount(Tb_Username.Text, Tb_fullname.Text, Tb_Address.Text, Tb_Phone.Text, Tb_Gender.Text, Tb_Department.Text, Tb_CompanyEmail.Text, Tb_Adminusername.Text, Tb_AdminPassword.Text);

                if (modified == 1)
                {
                    Lbl_status.ForeColor = System.Drawing.Color.Green;
                    Lbl_status.Text = "Changes were carried successfully!";
                }

                if (modified == 0)
                {
                    Lbl_status.ForeColor = System.Drawing.Color.Red;
                    Lbl_status.Text = "Something went wrong, please re-do the work!";

                }
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
