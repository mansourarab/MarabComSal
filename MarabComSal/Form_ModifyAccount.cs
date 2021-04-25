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

       
    }   
}
