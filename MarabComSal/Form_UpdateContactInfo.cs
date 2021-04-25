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
    public partial class Form_UpdateContactInfo : Form
    {
        public Form_UpdateContactInfo()
        {
            InitializeComponent();
        }



        private void Form_ContactInfo_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Savechanges_Click(object sender, EventArgs e)
        {
            Class_Info updateinfo = new Class_Info();
            int returned = updateinfo.UpdateContactinfo(Tb_PhoneData.Text, Tb_AddressData.Text, Class_Login.AccountId);
            
            if (returned != null)
            {
                Lbl_Status.ForeColor = System.Drawing.Color.Green;
                Lbl_Status.Text = "Changes were Saved Successfully!";
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
