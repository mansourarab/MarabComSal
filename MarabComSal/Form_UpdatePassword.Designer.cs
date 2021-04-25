
namespace MarabComSal
{
    partial class Form_UpdatePassword
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
            this.Gb_Updatepassword = new System.Windows.Forms.GroupBox();
            this.Lbl_status = new System.Windows.Forms.Label();
            this.Tb_NewpassData = new System.Windows.Forms.TextBox();
            this.Tb_OldpassData = new System.Windows.Forms.TextBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Savechanges = new System.Windows.Forms.Button();
            this.Lbl_Enternewpass = new System.Windows.Forms.Label();
            this.Lbl_Oldpassword = new System.Windows.Forms.Label();
            this.Gb_Updatepassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_Updatepassword
            // 
            this.Gb_Updatepassword.Controls.Add(this.Lbl_status);
            this.Gb_Updatepassword.Controls.Add(this.Tb_NewpassData);
            this.Gb_Updatepassword.Controls.Add(this.Tb_OldpassData);
            this.Gb_Updatepassword.Controls.Add(this.Btn_Back);
            this.Gb_Updatepassword.Controls.Add(this.Btn_Savechanges);
            this.Gb_Updatepassword.Controls.Add(this.Lbl_Enternewpass);
            this.Gb_Updatepassword.Controls.Add(this.Lbl_Oldpassword);
            this.Gb_Updatepassword.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Gb_Updatepassword.Location = new System.Drawing.Point(24, 22);
            this.Gb_Updatepassword.Name = "Gb_Updatepassword";
            this.Gb_Updatepassword.Size = new System.Drawing.Size(382, 247);
            this.Gb_Updatepassword.TabIndex = 0;
            this.Gb_Updatepassword.TabStop = false;
            this.Gb_Updatepassword.Text = "Update Passwrod";
            // 
            // Lbl_status
            // 
            this.Lbl_status.AutoSize = true;
            this.Lbl_status.Location = new System.Drawing.Point(136, 133);
            this.Lbl_status.Name = "Lbl_status";
            this.Lbl_status.Size = new System.Drawing.Size(0, 19);
            this.Lbl_status.TabIndex = 7;
            // 
            // Tb_NewpassData
            // 
            this.Tb_NewpassData.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Tb_NewpassData.Location = new System.Drawing.Point(189, 83);
            this.Tb_NewpassData.Name = "Tb_NewpassData";
            this.Tb_NewpassData.Size = new System.Drawing.Size(129, 24);
            this.Tb_NewpassData.TabIndex = 6;
            this.Tb_NewpassData.PasswordChar = '*';
            // 
            // Tb_OldpassData
            // 
            this.Tb_OldpassData.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Tb_OldpassData.Location = new System.Drawing.Point(189, 42);
            this.Tb_OldpassData.Name = "Tb_OldpassData";
            this.Tb_OldpassData.Size = new System.Drawing.Size(129, 24);
            this.Tb_OldpassData.TabIndex = 5;
            this.Tb_OldpassData.PasswordChar = '*';
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Back.Location = new System.Drawing.Point(0, 191);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(97, 30);
            this.Btn_Back.TabIndex = 4;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Savechanges
            // 
            this.Btn_Savechanges.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Savechanges.Location = new System.Drawing.Point(243, 191);
            this.Btn_Savechanges.Name = "Btn_Savechanges";
            this.Btn_Savechanges.Size = new System.Drawing.Size(133, 30);
            this.Btn_Savechanges.TabIndex = 3;
            this.Btn_Savechanges.Text = "Save Changes";
            this.Btn_Savechanges.UseVisualStyleBackColor = true;
            this.Btn_Savechanges.Click += new System.EventHandler(this.Btn_Savechanges_Click);
            // 
            // Lbl_Enternewpass
            // 
            this.Lbl_Enternewpass.AutoSize = true;
            this.Lbl_Enternewpass.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Lbl_Enternewpass.Location = new System.Drawing.Point(23, 83);
            this.Lbl_Enternewpass.Name = "Lbl_Enternewpass";
            this.Lbl_Enternewpass.Size = new System.Drawing.Size(157, 17);
            this.Lbl_Enternewpass.TabIndex = 1;
            this.Lbl_Enternewpass.Text = "Enter New Password:";
            // 
            // Lbl_Oldpassword
            // 
            this.Lbl_Oldpassword.AutoSize = true;
            this.Lbl_Oldpassword.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Lbl_Oldpassword.Location = new System.Drawing.Point(23, 42);
            this.Lbl_Oldpassword.Name = "Lbl_Oldpassword";
            this.Lbl_Oldpassword.Size = new System.Drawing.Size(149, 17);
            this.Lbl_Oldpassword.TabIndex = 0;
            this.Lbl_Oldpassword.Text = "Enter Old Password:";
            // 
            // Form_UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 346);
            this.Controls.Add(this.Gb_Updatepassword);
            this.Name = "Form_UpdatePassword";
            this.Text = "Form_UpdatePassword";
            this.Load += new System.EventHandler(this.Form_UpdatePassword_Load);
            this.Gb_Updatepassword.ResumeLayout(false);
            this.Gb_Updatepassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Updatepassword;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Savechanges;
        private System.Windows.Forms.Label Lbl_Enternewpass;
        private System.Windows.Forms.Label Lbl_Oldpassword;
        private System.Windows.Forms.TextBox Tb_NewpassData;
        private System.Windows.Forms.TextBox Tb_OldpassData;
        private System.Windows.Forms.Label Lbl_status;
    }
}