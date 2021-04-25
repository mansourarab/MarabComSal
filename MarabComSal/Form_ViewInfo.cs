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

         
        private void Form_ViewInfo_Load(object sender, EventArgs e)
        {

                Class_Info view = new Class_Info();
                DataTable data = view.ViewInfo(Class_Login.AccountId);
                if (data.Rows.Count != 0)
                {
                    dataGridView1.DataSource = data;
                
                }


            
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Homepage backto = new Homepage();
            backto.Show();
            this.Close();
        }

        

    }
}
