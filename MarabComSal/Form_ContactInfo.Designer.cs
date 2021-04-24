
namespace MarabComSal
{
    partial class Form_ContactInfo
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
            this.Gb_Contactinfo = new System.Windows.Forms.GroupBox();
            this.Lbl_Phone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_PhoneData = new System.Windows.Forms.TextBox();
            this.Tb_AddressData = new System.Windows.Forms.TextBox();
            this.Btn_Savechanges = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.Gb_Contactinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_Contactinfo
            // 
            this.Gb_Contactinfo.Controls.Add(this.Lbl_Status);
            this.Gb_Contactinfo.Controls.Add(this.Btn_Back);
            this.Gb_Contactinfo.Controls.Add(this.Btn_Savechanges);
            this.Gb_Contactinfo.Controls.Add(this.Tb_AddressData);
            this.Gb_Contactinfo.Controls.Add(this.Tb_PhoneData);
            this.Gb_Contactinfo.Controls.Add(this.label1);
            this.Gb_Contactinfo.Controls.Add(this.Lbl_Phone);
            this.Gb_Contactinfo.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Gb_Contactinfo.Location = new System.Drawing.Point(116, 58);
            this.Gb_Contactinfo.Name = "Gb_Contactinfo";
            this.Gb_Contactinfo.Size = new System.Drawing.Size(325, 189);
            this.Gb_Contactinfo.TabIndex = 0;
            this.Gb_Contactinfo.TabStop = false;
            this.Gb_Contactinfo.Text = "Update Contact Info";
            // 
            // Lbl_Phone
            // 
            this.Lbl_Phone.AutoSize = true;
            this.Lbl_Phone.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_Phone.Location = new System.Drawing.Point(30, 43);
            this.Lbl_Phone.Name = "Lbl_Phone";
            this.Lbl_Phone.Size = new System.Drawing.Size(57, 17);
            this.Lbl_Phone.TabIndex = 0;
            this.Lbl_Phone.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address:";
            // 
            // Tb_PhoneData
            // 
            this.Tb_PhoneData.Location = new System.Drawing.Point(111, 43);
            this.Tb_PhoneData.Name = "Tb_PhoneData";
            this.Tb_PhoneData.Size = new System.Drawing.Size(100, 27);
            this.Tb_PhoneData.TabIndex = 2;
            // 
            // Tb_AddressData
            // 
            this.Tb_AddressData.Location = new System.Drawing.Point(111, 87);
            this.Tb_AddressData.Name = "Tb_AddressData";
            this.Tb_AddressData.Size = new System.Drawing.Size(100, 27);
            this.Tb_AddressData.TabIndex = 3;
            // 
            // Btn_Savechanges
            // 
            this.Btn_Savechanges.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Savechanges.Location = new System.Drawing.Point(211, 151);
            this.Btn_Savechanges.Name = "Btn_Savechanges";
            this.Btn_Savechanges.Size = new System.Drawing.Size(97, 23);
            this.Btn_Savechanges.TabIndex = 4;
            this.Btn_Savechanges.Text = "Save Changes";
            this.Btn_Savechanges.UseVisualStyleBackColor = true;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Btn_Back.Location = new System.Drawing.Point(33, 151);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(97, 23);
            this.Btn_Back.TabIndex = 5;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Lbl_Status.Location = new System.Drawing.Point(150, 121);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(0, 17);
            this.Lbl_Status.TabIndex = 6;
            // 
            // Form_ContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 303);
            this.Controls.Add(this.Gb_Contactinfo);
            this.Name = "Form_ContactInfo";
            this.Text = "Form_ContactInfo";
            this.Gb_Contactinfo.ResumeLayout(false);
            this.Gb_Contactinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Contactinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Phone;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Savechanges;
        private System.Windows.Forms.TextBox Tb_AddressData;
        private System.Windows.Forms.TextBox Tb_PhoneData;
    }
}