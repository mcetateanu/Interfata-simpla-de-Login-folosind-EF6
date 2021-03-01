namespace WindowsFormsLogin_Magazin
{
    partial class FormLogin_Magazin
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
            this.txtUserNameLogin = new System.Windows.Forms.TextBox();
            this.txtPassword_Login = new System.Windows.Forms.TextBox();
            this.lblUser_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.gbxLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameLogin.Location = new System.Drawing.Point(146, 81);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(226, 29);
            this.txtUserNameLogin.TabIndex = 0;
            this.txtUserNameLogin.TextChanged += new System.EventHandler(this.txtUserNameLogin_TextChanged);
            // 
            // txtPassword_Login
            // 
            this.txtPassword_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_Login.Location = new System.Drawing.Point(146, 132);
            this.txtPassword_Login.Name = "txtPassword_Login";
            this.txtPassword_Login.Size = new System.Drawing.Size(223, 29);
            this.txtPassword_Login.TabIndex = 1;
            this.txtPassword_Login.TextChanged += new System.EventHandler(this.txtPassword_Login_TextChanged);
            // 
            // lblUser_ID
            // 
            this.lblUser_ID.AutoSize = true;
            this.lblUser_ID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser_ID.Location = new System.Drawing.Point(82, 88);
            this.lblUser_ID.Name = "lblUser_ID";
            this.lblUser_ID.Size = new System.Drawing.Size(58, 22);
            this.lblUser_ID.TabIndex = 2;
            this.lblUser_ID.Text = "User :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password :";
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Controls.Add(this.label1);
            this.gbxLogin.Controls.Add(this.lblUser_ID);
            this.gbxLogin.Controls.Add(this.txtPassword_Login);
            this.gbxLogin.Controls.Add(this.txtUserNameLogin);
            this.gbxLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbxLogin.Location = new System.Drawing.Point(191, 69);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(445, 227);
            this.gbxLogin.TabIndex = 4;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "  Please Login   ";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(350, 186);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Location = new System.Drawing.Point(146, 28);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(151, 31);
            this.btnNewUser.TabIndex = 5;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewUser);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(192, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Create  ";
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitLogin.Location = new System.Drawing.Point(811, 438);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(99, 37);
            this.btnExitLogin.TabIndex = 7;
            this.btnExitLogin.Text = "Exit";
            this.btnExitLogin.UseVisualStyleBackColor = true;
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // FormLogin_Magazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 530);
            this.Controls.Add(this.btnExitLogin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin_Magazin";
            this.Text = "Login_Magazin";
            this.Load += new System.EventHandler(this.FormLogin_Magazin_Load);
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserNameLogin;
        private System.Windows.Forms.TextBox txtPassword_Login;
        private System.Windows.Forms.Label lblUser_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExitLogin;
    }
}

