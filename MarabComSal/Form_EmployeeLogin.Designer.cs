
namespace MarabComSal
{
    partial class Form_EmployeeLogin
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
            this.Gb_Employeelogin = new System.Windows.Forms.GroupBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.Tb_Username = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_username = new System.Windows.Forms.Label();
            this.Lbl_Please = new System.Windows.Forms.Label();
            this.Gb_Employeelogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_Employeelogin
            // 
            this.Gb_Employeelogin.Controls.Add(this.Btn_Back);
            this.Gb_Employeelogin.Controls.Add(this.Btn_Login);
            this.Gb_Employeelogin.Controls.Add(this.Lbl_Status);
            this.Gb_Employeelogin.Controls.Add(this.Tb_Password);
            this.Gb_Employeelogin.Controls.Add(this.Tb_Username);
            this.Gb_Employeelogin.Controls.Add(this.Lbl_Password);
            this.Gb_Employeelogin.Controls.Add(this.Lbl_username);
            this.Gb_Employeelogin.Controls.Add(this.Lbl_Please);
            this.Gb_Employeelogin.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Gb_Employeelogin.Location = new System.Drawing.Point(146, 59);
            this.Gb_Employeelogin.Name = "Gb_Employeelogin";
            this.Gb_Employeelogin.Size = new System.Drawing.Size(417, 276);
            this.Gb_Employeelogin.TabIndex = 0;
            this.Gb_Employeelogin.TabStop = false;
            this.Gb_Employeelogin.Text = "Employee Login Info";
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Btn_Back.Location = new System.Drawing.Point(19, 223);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(103, 32);
            this.Btn_Back.TabIndex = 7;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Btn_Login.Location = new System.Drawing.Point(305, 223);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(96, 32);
            this.Btn_Login.TabIndex = 6;
            this.Btn_Login.Text = "Log in!";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Location = new System.Drawing.Point(197, 172);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(0, 23);
            this.Lbl_Status.TabIndex = 5;
            // 
            // Tb_Password
            // 
            this.Tb_Password.Location = new System.Drawing.Point(145, 135);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.Size = new System.Drawing.Size(183, 30);
            this.Tb_Password.TabIndex = 4;
            // 
            // Tb_Username
            // 
            this.Tb_Username.Location = new System.Drawing.Point(145, 94);
            this.Tb_Username.Name = "Tb_Username";
            this.Tb_Username.Size = new System.Drawing.Size(183, 30);
            this.Tb_Username.TabIndex = 3;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Lbl_Password.Location = new System.Drawing.Point(25, 141);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(93, 19);
            this.Lbl_Password.TabIndex = 2;
            this.Lbl_Password.Text = "Password:";
            // 
            // Lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Lbl_username.Location = new System.Drawing.Point(25, 96);
            this.Lbl_username.Name = "Lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(97, 19);
            this.Lbl_username.TabIndex = 1;
            this.Lbl_username.Text = "Username:";
            // 
            // Lbl_Please
            // 
            this.Lbl_Please.AutoSize = true;
            this.Lbl_Please.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Lbl_Please.Location = new System.Drawing.Point(6, 45);
            this.Lbl_Please.Name = "Lbl_Please";
            this.Lbl_Please.Size = new System.Drawing.Size(227, 19);
            this.Lbl_Please.TabIndex = 0;
            this.Lbl_Please.Text = "Please Enter your credentitials:";
            // 
            // Form_EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gb_Employeelogin);
            this.Name = "Form_EmployeeLogin";
            this.Text = "Form_EmployeeLogin";
            this.Load += new System.EventHandler(this.Form_EmployeeLogin_Load);
            this.Gb_Employeelogin.ResumeLayout(false);
            this.Gb_Employeelogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Employeelogin;
        private System.Windows.Forms.Label Lbl_username;
        private System.Windows.Forms.Label Lbl_Please;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.TextBox Tb_Password;
        private System.Windows.Forms.TextBox Tb_Username;
        private System.Windows.Forms.Label Lbl_Password;
    }
}