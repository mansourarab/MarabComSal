
namespace MarabComSal
{
    partial class Form_ModifyAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gb_Modify = new System.Windows.Forms.GroupBox();
            this.Lbl_Deleteusername = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Tb_Username = new System.Windows.Forms.TextBox();
            this.Tb_fullname = new System.Windows.Forms.TextBox();
            this.Tb_Address = new System.Windows.Forms.TextBox();
            this.Tb_Phone = new System.Windows.Forms.TextBox();
            this.Tb_Gender = new System.Windows.Forms.TextBox();
            this.Tb_Department = new System.Windows.Forms.TextBox();
            this.Tb_CompanyEmail = new System.Windows.Forms.TextBox();
            this.Tb_Delete = new System.Windows.Forms.TextBox();
            this.Tb_Adminusername = new System.Windows.Forms.TextBox();
            this.Tb_AdminPassword = new System.Windows.Forms.TextBox();
            this.Dgv_Acc = new System.Windows.Forms.DataGridView();
            this.Dgv_Cus = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Dgv_Emp = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Gb_Modify.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tb_CompanyEmail);
            this.groupBox1.Controls.Add(this.Tb_Department);
            this.groupBox1.Controls.Add(this.Tb_Gender);
            this.groupBox1.Controls.Add(this.Tb_Phone);
            this.groupBox1.Controls.Add(this.Tb_Address);
            this.groupBox1.Controls.Add(this.Tb_fullname);
            this.groupBox1.Controls.Add(this.Tb_Username);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(138, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify Account";
            // 
            // Gb_Modify
            // 
            this.Gb_Modify.Controls.Add(this.Tb_Delete);
            this.Gb_Modify.Controls.Add(this.Lbl_Deleteusername);
            this.Gb_Modify.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Gb_Modify.Location = new System.Drawing.Point(138, 398);
            this.Gb_Modify.Name = "Gb_Modify";
            this.Gb_Modify.Size = new System.Drawing.Size(482, 87);
            this.Gb_Modify.TabIndex = 1;
            this.Gb_Modify.TabStop = false;
            this.Gb_Modify.Text = "Delete Account";
            // 
            // Lbl_Deleteusername
            // 
            this.Lbl_Deleteusername.AutoSize = true;
            this.Lbl_Deleteusername.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_Deleteusername.Location = new System.Drawing.Point(30, 42);
            this.Lbl_Deleteusername.Name = "Lbl_Deleteusername";
            this.Lbl_Deleteusername.Size = new System.Drawing.Size(129, 17);
            this.Lbl_Deleteusername.TabIndex = 0;
            this.Lbl_Deleteusername.Text = "Delete Username:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tb_AdminPassword);
            this.groupBox2.Controls.Add(this.Tb_Adminusername);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox2.Location = new System.Drawing.Point(138, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adminstrator Authentication";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adminstrator Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adminstrator Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Account Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(31, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fullname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(31, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(31, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(31, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(31, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Department:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(31, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Company Email:";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Location = new System.Drawing.Point(499, 656);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(101, 23);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save Changes!";
            this.Btn_Save.UseVisualStyleBackColor = true;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Back.Location = new System.Drawing.Point(156, 656);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(101, 23);
            this.Btn_Back.TabIndex = 5;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            // 
            // Tb_Username
            // 
            this.Tb_Username.Location = new System.Drawing.Point(195, 58);
            this.Tb_Username.Name = "Tb_Username";
            this.Tb_Username.Size = new System.Drawing.Size(177, 27);
            this.Tb_Username.TabIndex = 8;
            // 
            // Tb_fullname
            // 
            this.Tb_fullname.Location = new System.Drawing.Point(195, 90);
            this.Tb_fullname.Name = "Tb_fullname";
            this.Tb_fullname.Size = new System.Drawing.Size(177, 27);
            this.Tb_fullname.TabIndex = 9;
            // 
            // Tb_Address
            // 
            this.Tb_Address.Location = new System.Drawing.Point(195, 127);
            this.Tb_Address.Name = "Tb_Address";
            this.Tb_Address.Size = new System.Drawing.Size(177, 27);
            this.Tb_Address.TabIndex = 10;
            // 
            // Tb_Phone
            // 
            this.Tb_Phone.Location = new System.Drawing.Point(195, 166);
            this.Tb_Phone.Name = "Tb_Phone";
            this.Tb_Phone.Size = new System.Drawing.Size(177, 27);
            this.Tb_Phone.TabIndex = 11;
            // 
            // Tb_Gender
            // 
            this.Tb_Gender.Location = new System.Drawing.Point(195, 200);
            this.Tb_Gender.Name = "Tb_Gender";
            this.Tb_Gender.Size = new System.Drawing.Size(177, 27);
            this.Tb_Gender.TabIndex = 12;
            // 
            // Tb_Department
            // 
            this.Tb_Department.Location = new System.Drawing.Point(195, 233);
            this.Tb_Department.Name = "Tb_Department";
            this.Tb_Department.Size = new System.Drawing.Size(177, 27);
            this.Tb_Department.TabIndex = 13;
            // 
            // Tb_CompanyEmail
            // 
            this.Tb_CompanyEmail.Location = new System.Drawing.Point(195, 266);
            this.Tb_CompanyEmail.Name = "Tb_CompanyEmail";
            this.Tb_CompanyEmail.Size = new System.Drawing.Size(177, 27);
            this.Tb_CompanyEmail.TabIndex = 14;
            // 
            // Tb_Delete
            // 
            this.Tb_Delete.Location = new System.Drawing.Point(195, 36);
            this.Tb_Delete.Name = "Tb_Delete";
            this.Tb_Delete.Size = new System.Drawing.Size(177, 27);
            this.Tb_Delete.TabIndex = 15;
            // 
            // Tb_Adminusername
            // 
            this.Tb_Adminusername.Location = new System.Drawing.Point(230, 40);
            this.Tb_Adminusername.Name = "Tb_Adminusername";
            this.Tb_Adminusername.Size = new System.Drawing.Size(177, 27);
            this.Tb_Adminusername.TabIndex = 16;
            // 
            // Tb_AdminPassword
            // 
            this.Tb_AdminPassword.Location = new System.Drawing.Point(230, 76);
            this.Tb_AdminPassword.Name = "Tb_AdminPassword";
            this.Tb_AdminPassword.Size = new System.Drawing.Size(177, 27);
            this.Tb_AdminPassword.TabIndex = 17;
            // 
            // Dgv_Acc
            // 
            this.Dgv_Acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Acc.Location = new System.Drawing.Point(652, 36);
            this.Dgv_Acc.Name = "Dgv_Acc";
            this.Dgv_Acc.Size = new System.Drawing.Size(798, 154);
            this.Dgv_Acc.TabIndex = 6;
            // 
            // Dgv_Cus
            // 
            this.Dgv_Cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Cus.Location = new System.Drawing.Point(652, 288);
            this.Dgv_Cus.Name = "Dgv_Cus";
            this.Dgv_Cus.Size = new System.Drawing.Size(798, 153);
            this.Dgv_Cus.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(1009, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Accounts Table";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1009, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Customer Table";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(1009, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Employee Table";
            // 
            // Dgv_Emp
            // 
            this.Dgv_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Emp.Location = new System.Drawing.Point(652, 498);
            this.Dgv_Emp.Name = "Dgv_Emp";
            this.Dgv_Emp.Size = new System.Drawing.Size(798, 153);
            this.Dgv_Emp.TabIndex = 10;
            // 
            // Form_ModifyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 705);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Dgv_Emp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Dgv_Cus);
            this.Controls.Add(this.Dgv_Acc);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Gb_Modify);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_ModifyAccount";
            this.Text = "Form_ModifyAccount";
            this.Load += new System.EventHandler(this.Form_ModifyAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gb_Modify.ResumeLayout(false);
            this.Gb_Modify.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Gb_Modify;
        private System.Windows.Forms.Label Lbl_Deleteusername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.TextBox Tb_CompanyEmail;
        private System.Windows.Forms.TextBox Tb_Department;
        private System.Windows.Forms.TextBox Tb_Gender;
        private System.Windows.Forms.TextBox Tb_Phone;
        private System.Windows.Forms.TextBox Tb_Address;
        private System.Windows.Forms.TextBox Tb_fullname;
        private System.Windows.Forms.TextBox Tb_Username;
        private System.Windows.Forms.TextBox Tb_Delete;
        private System.Windows.Forms.TextBox Tb_AdminPassword;
        private System.Windows.Forms.TextBox Tb_Adminusername;
        private System.Windows.Forms.DataGridView Dgv_Acc;
        private System.Windows.Forms.DataGridView Dgv_Cus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView Dgv_Emp;
    }
}