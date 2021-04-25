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
    public partial class Form_ViewInfo : Form
    {
        public Form_ViewInfo()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void Form_ViewInfo_Load(object sender, EventArgs e)
        {
            Class_CustomerLogin newid = new Class_CustomerLogin();
            int? AID;
            int result = acc.CheckUserExists(txtUserName.Text, txtPassword.Text, out SID);
        }
||||||| d164739
=======
        Class_CustomerLogin catsh = new Class_CustomerLogin();
         
        private void Form_ViewInfo_Load(object sender, EventArgs e)
        {

            if (Class_CustomerLogin.AccountId != null)
            {
                Class_Info view = new Class_Info();
                DataTable data = view.ViewInfo(Class_CustomerLogin.AccountId);
                if (data.Rows.Count != 0)
                {
                    dataGridView1.DataSource = data;
                }
            }


            if (Class_EmployeeLogin.AccountId != null)
            {
                Class_Info view = new Class_Info();
                DataTable data = view.ViewInfo(Class_EmployeeLogin.AccountId);
                if (data.Rows.Count != 0)
                {
                    dataGridView1.DataSource = data;
                }
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Homepage backto = new Homepage();
            backto.Show();
            this.Close();
        }

        
>>>>>>> trials
    }
}
