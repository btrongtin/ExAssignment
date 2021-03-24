namespace ExAssignment
{
    partial class fLogin
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
            this.pnlMainLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.pnlMainLogin.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainLogin
            // 
            this.pnlMainLogin.Controls.Add(this.btnRetry);
            this.pnlMainLogin.Controls.Add(this.btnLogin);
            this.pnlMainLogin.Controls.Add(this.btnExit);
            this.pnlMainLogin.Controls.Add(this.pnlPassword);
            this.pnlMainLogin.Controls.Add(this.pnlUserName);
            this.pnlMainLogin.Location = new System.Drawing.Point(4, 12);
            this.pnlMainLogin.Name = "pnlMainLogin";
            this.pnlMainLogin.Size = new System.Drawing.Size(425, 145);
            this.pnlMainLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(211, 101);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 32);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(307, 101);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.txtPass);
            this.pnlPassword.Controls.Add(this.lblPassword);
            this.pnlPassword.Location = new System.Drawing.Point(0, 47);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(425, 48);
            this.pnlPassword.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(166, 21);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(231, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "1";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(47, 21);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 16);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // pnlUserName
            // 
            this.pnlUserName.Controls.Add(this.txtName);
            this.pnlUserName.Controls.Add(this.lblUserName);
            this.pnlUserName.Location = new System.Drawing.Point(0, 0);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(425, 48);
            this.pnlUserName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "buitrongtin";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(47, 21);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên đăng nhập";
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(115, 101);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(90, 32);
            this.btnRetry.TabIndex = 5;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 172);
            this.Controls.Add(this.pnlMainLogin);
            this.Name = "fLogin";
            this.Text = "Login";
            this.pnlMainLogin.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUserName.ResumeLayout(false);
            this.pnlUserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnRetry;
    }
}