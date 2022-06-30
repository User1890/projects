
namespace WindowsFormsApp1
{
    partial class Registration
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
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.autoris = new System.Windows.Forms.LinkLabel();
            this.registr = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Avatar
            // 
            this.Avatar.Location = new System.Drawing.Point(51, 85);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(45, 45);
            this.Avatar.TabIndex = 9;
            this.Avatar.TabStop = false;
            // 
            // autoris
            // 
            this.autoris.AutoSize = true;
            this.autoris.Location = new System.Drawing.Point(122, 214);
            this.autoris.Name = "autoris";
            this.autoris.Size = new System.Drawing.Size(61, 13);
            this.autoris.TabIndex = 8;
            this.autoris.TabStop = true;
            this.autoris.Text = "autorisation";
            this.autoris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.autoris_LinkClicked);
            // 
            // registr
            // 
            this.registr.Location = new System.Drawing.Point(114, 151);
            this.registr.Name = "registr";
            this.registr.Size = new System.Drawing.Size(75, 25);
            this.registr.TabIndex = 7;
            this.registr.Text = "button1";
            this.registr.UseVisualStyleBackColor = true;
            this.registr.Click += new System.EventHandler(this.registr_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(102, 111);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 6;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(102, 85);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 5;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 354);
            this.Controls.Add(this.Avatar);
            this.Controls.Add(this.autoris);
            this.Controls.Add(this.registr);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "Registration";
            this.Text = "Registr";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.LinkLabel autoris;
        private System.Windows.Forms.Button registr;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private Autorisation a;
        private Main f;
    }
}