namespace MastermindGameGUI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.tbPasswordAgain = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbPasswordAgain = new System.Windows.Forms.Label();
            this.pbLogoSmall = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbBackToLogin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(119, 123);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(167, 20);
            this.tbPassword.TabIndex = 0;
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(119, 70);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(167, 20);
            this.tbAccount.TabIndex = 1;
            // 
            // tbPasswordAgain
            // 
            this.tbPasswordAgain.Location = new System.Drawing.Point(119, 176);
            this.tbPasswordAgain.Name = "tbPasswordAgain";
            this.tbPasswordAgain.Size = new System.Drawing.Size(167, 20);
            this.tbPasswordAgain.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Roboto Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(112, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(180, 26);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Register new account";
            this.lbTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAccount.Location = new System.Drawing.Point(116, 50);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(92, 20);
            this.lbAccount.TabIndex = 4;
            this.lbAccount.Text = "Account name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.Location = new System.Drawing.Point(116, 103);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 20);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // lbPasswordAgain
            // 
            this.lbPasswordAgain.AutoSize = true;
            this.lbPasswordAgain.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPasswordAgain.Location = new System.Drawing.Point(116, 156);
            this.lbPasswordAgain.Name = "lbPasswordAgain";
            this.lbPasswordAgain.Size = new System.Drawing.Size(101, 20);
            this.lbPasswordAgain.TabIndex = 6;
            this.lbPasswordAgain.Text = "Password again";
            // 
            // pbLogoSmall
            // 
            this.pbLogoSmall.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoSmall.Image")));
            this.pbLogoSmall.Location = new System.Drawing.Point(12, 12);
            this.pbLogoSmall.Name = "pbLogoSmall";
            this.pbLogoSmall.Size = new System.Drawing.Size(96, 87);
            this.pbLogoSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoSmall.TabIndex = 7;
            this.pbLogoSmall.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.Location = new System.Drawing.Point(120, 211);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(166, 37);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbBackToLogin
            // 
            this.lbBackToLogin.AutoSize = true;
            this.lbBackToLogin.Location = new System.Drawing.Point(12, 266);
            this.lbBackToLogin.Name = "lbBackToLogin";
            this.lbBackToLogin.Size = new System.Drawing.Size(73, 13);
            this.lbBackToLogin.TabIndex = 9;
            this.lbBackToLogin.TabStop = true;
            this.lbBackToLogin.Text = "Back to Login";
            this.lbBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 288);
            this.Controls.Add(this.lbBackToLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pbLogoSmall);
            this.Controls.Add(this.lbPasswordAgain);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbPasswordAgain);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.tbPassword);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.TextBox tbPasswordAgain;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbPasswordAgain;
        private System.Windows.Forms.PictureBox pbLogoSmall;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lbBackToLogin;
    }
}