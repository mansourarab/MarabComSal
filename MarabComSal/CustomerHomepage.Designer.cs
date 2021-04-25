
namespace MarabComSal
{
    partial class CustomerHomepage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePasswordEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyOrCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_Welcome = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Welcomeuser = new System.Windows.Forms.Label();
            this.Lbl_user = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.updateToolStripMenuItem1,
            this.logOutToolStripMenuItem1});
            this.myProfileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.viewToolStripMenuItem1.Text = "View";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatePasswordEmailToolStripMenuItem,
            this.contactInfoToolStripMenuItem});
            this.updateToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // updatePasswordEmailToolStripMenuItem
            // 
            this.updatePasswordEmailToolStripMenuItem.Name = "updatePasswordEmailToolStripMenuItem";
            this.updatePasswordEmailToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.updatePasswordEmailToolStripMenuItem.Text = "Password";
            this.updatePasswordEmailToolStripMenuItem.Click += new System.EventHandler(this.updatePasswordEmailToolStripMenuItem_Click_1);
            // 
            // contactInfoToolStripMenuItem
            // 
            this.contactInfoToolStripMenuItem.Name = "contactInfoToolStripMenuItem";
            this.contactInfoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.contactInfoToolStripMenuItem.Text = "Contact Info";
            this.contactInfoToolStripMenuItem.Click += new System.EventHandler(this.contactInfoToolStripMenuItem_Click_1);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click_1);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.modifyOrCancelToolStripMenuItem});
            this.ordersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.ordersToolStripMenuItem.Text = "Orders (In Progress)";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // modifyOrCancelToolStripMenuItem
            // 
            this.modifyOrCancelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modifyOrCancelToolStripMenuItem.Name = "modifyOrCancelToolStripMenuItem";
            this.modifyOrCancelToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.modifyOrCancelToolStripMenuItem.Text = "Modify or Cancel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_user);
            this.groupBox1.Controls.Add(this.Lbl_Welcomeuser);
            this.groupBox1.Controls.Add(this.Lbl_Welcome);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(490, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Lbl_Welcome
            // 
            this.Lbl_Welcome.AutoSize = true;
            this.Lbl_Welcome.Location = new System.Drawing.Point(5, 16);
            this.Lbl_Welcome.Name = "Lbl_Welcome";
            this.Lbl_Welcome.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Welcome.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Calligraphy", 8F);
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Lbl_Welcomeuser
            // 
            this.Lbl_Welcomeuser.AutoSize = true;
            this.Lbl_Welcomeuser.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Lbl_Welcomeuser.Location = new System.Drawing.Point(3, 8);
            this.Lbl_Welcomeuser.Name = "Lbl_Welcomeuser";
            this.Lbl_Welcomeuser.Size = new System.Drawing.Size(100, 26);
            this.Lbl_Welcomeuser.TabIndex = 3;
            this.Lbl_Welcomeuser.Text = "Welcome !";
            // 
            // Lbl_user
            // 
            this.Lbl_user.AutoSize = true;
            this.Lbl_user.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_user.Location = new System.Drawing.Point(124, 8);
            this.Lbl_user.Name = "Lbl_user";
            this.Lbl_user.Size = new System.Drawing.Size(0, 22);
            this.Lbl_user.TabIndex = 4;
            // 
            // CustomerHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CustomerHomepage";
            this.Text = "CustomerHomepage";
            this.Load += new System.EventHandler(this.CustomerHomepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updatePasswordEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyOrCancelToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_Welcome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Lbl_user;
        private System.Windows.Forms.Label Lbl_Welcomeuser;
    }
}