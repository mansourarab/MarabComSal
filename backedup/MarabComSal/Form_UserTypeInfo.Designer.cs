
namespace MarabComSal
{
    partial class Form_UserTypeInfo
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
            this.Gb_Pleasechoose = new System.Windows.Forms.GroupBox();
            this.Btn_Out = new System.Windows.Forms.Button();
            this.Btn_Customer = new System.Windows.Forms.Button();
            this.Btn_Employee = new System.Windows.Forms.Button();
            this.Lbl_Welcome = new System.Windows.Forms.Label();
            this.Gb_Pleasechoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_Pleasechoose
            // 
            this.Gb_Pleasechoose.Controls.Add(this.Btn_Out);
            this.Gb_Pleasechoose.Controls.Add(this.Btn_Customer);
            this.Gb_Pleasechoose.Controls.Add(this.Btn_Employee);
            this.Gb_Pleasechoose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Gb_Pleasechoose.Location = new System.Drawing.Point(211, 182);
            this.Gb_Pleasechoose.Name = "Gb_Pleasechoose";
            this.Gb_Pleasechoose.Size = new System.Drawing.Size(289, 167);
            this.Gb_Pleasechoose.TabIndex = 5;
            this.Gb_Pleasechoose.TabStop = false;
            this.Gb_Pleasechoose.Text = "Please choose your user type for login:";
            // 
            // Btn_Out
            // 
            this.Btn_Out.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Out.Location = new System.Drawing.Point(107, 126);
            this.Btn_Out.Name = "Btn_Out";
            this.Btn_Out.Size = new System.Drawing.Size(89, 28);
            this.Btn_Out.TabIndex = 6;
            this.Btn_Out.Text = "Out";
            this.Btn_Out.UseVisualStyleBackColor = true;
            this.Btn_Out.Click += new System.EventHandler(this.Btn_Out_Click);
            // 
            // Btn_Customer
            // 
            this.Btn_Customer.Location = new System.Drawing.Point(107, 85);
            this.Btn_Customer.Name = "Btn_Customer";
            this.Btn_Customer.Size = new System.Drawing.Size(89, 31);
            this.Btn_Customer.TabIndex = 1;
            this.Btn_Customer.Text = "Customer";
            this.Btn_Customer.UseVisualStyleBackColor = true;
            this.Btn_Customer.Click += new System.EventHandler(this.Btn_Customer_Click);
            // 
            // Btn_Employee
            // 
            this.Btn_Employee.Location = new System.Drawing.Point(107, 48);
            this.Btn_Employee.Name = "Btn_Employee";
            this.Btn_Employee.Size = new System.Drawing.Size(89, 31);
            this.Btn_Employee.TabIndex = 0;
            this.Btn_Employee.Text = "Employee";
            this.Btn_Employee.UseVisualStyleBackColor = true;
            this.Btn_Employee.Click += new System.EventHandler(this.Btn_Employee_Click);
            // 
            // Lbl_Welcome
            // 
            this.Lbl_Welcome.AutoSize = true;
            this.Lbl_Welcome.Font = new System.Drawing.Font("Tahoma", 20F);
            this.Lbl_Welcome.Location = new System.Drawing.Point(172, 118);
            this.Lbl_Welcome.Name = "Lbl_Welcome";
            this.Lbl_Welcome.Size = new System.Drawing.Size(456, 33);
            this.Lbl_Welcome.TabIndex = 4;
            this.Lbl_Welcome.Text = "Welcome to Mansour Arab Company!";
            // 
            // Form_UserTypeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gb_Pleasechoose);
            this.Controls.Add(this.Lbl_Welcome);
            this.Name = "Form_UserTypeInfo";
            this.Text = "Form_UserTypeInfo";
            this.Load += new System.EventHandler(this.Form_UserTypeInfo_Load);
            this.Gb_Pleasechoose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Pleasechoose;
        private System.Windows.Forms.Button Btn_Customer;
        private System.Windows.Forms.Button Btn_Employee;
        private System.Windows.Forms.Label Lbl_Welcome;
        private System.Windows.Forms.Button Btn_Out;
    }
}