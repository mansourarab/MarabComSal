
namespace MarabComSal
{
    partial class Form_ViewInfo
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
            this.Gb_Userinfo = new System.Windows.Forms.GroupBox();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Gb_Userinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_Userinfo
            // 
            this.Gb_Userinfo.Controls.Add(this.dataGridView1);
            this.Gb_Userinfo.Controls.Add(this.Btn_Back);
            this.Gb_Userinfo.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Gb_Userinfo.Location = new System.Drawing.Point(93, 65);
            this.Gb_Userinfo.Name = "Gb_Userinfo";
            this.Gb_Userinfo.Size = new System.Drawing.Size(511, 503);
            this.Gb_Userinfo.TabIndex = 0;
            this.Gb_Userinfo.TabStop = false;
            this.Gb_Userinfo.Text = "User Info";
            // 
            // Btn_Back
            // 
            this.Btn_Back.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Btn_Back.Location = new System.Drawing.Point(207, 457);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(85, 28);
            this.Btn_Back.TabIndex = 8;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 402);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form_ViewInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 633);
            this.Controls.Add(this.Gb_Userinfo);
            this.Name = "Form_ViewInfo";
            this.Text = "Form_ViewInfo";
            this.Gb_Userinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Userinfo;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}