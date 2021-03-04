namespace WindowsFormsApp1
{
    partial class FormCreateNewUser
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
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.lblUserNameConditions = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnSubmitNewUser = new System.Windows.Forms.Button();
            this.gbxNewUser = new System.Windows.Forms.GroupBox();
            this.btnCancelCreateNewUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxNewUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewUser
            // 
            this.txtNewUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUser.Location = new System.Drawing.Point(233, 42);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(223, 29);
            this.txtNewUser.TabIndex = 0;
            this.txtNewUser.TextChanged += new System.EventHandler(this.txtNewUser_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(235, 108);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(220, 29);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUserName.Location = new System.Drawing.Point(11, 49);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(214, 22);
            this.lblNewUserName.TabIndex = 2;
            this.lblNewUserName.Text = "Enter New User Name* :";
            // 
            // lblUserNameConditions
            // 
            this.lblUserNameConditions.AutoSize = true;
            this.lblUserNameConditions.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameConditions.Location = new System.Drawing.Point(144, 435);
            this.lblUserNameConditions.Name = "lblUserNameConditions";
            this.lblUserNameConditions.Size = new System.Drawing.Size(361, 19);
            this.lblUserNameConditions.TabIndex = 3;
            this.lblUserNameConditions.Text = "* numeric and alfanumeric characters without space";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(11, 115);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(203, 22);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "Enter New Password* :";
            // 
            // btnSubmitNewUser
            // 
            this.btnSubmitNewUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNewUser.Location = new System.Drawing.Point(472, 320);
            this.btnSubmitNewUser.Name = "btnSubmitNewUser";
            this.btnSubmitNewUser.Size = new System.Drawing.Size(162, 45);
            this.btnSubmitNewUser.TabIndex = 5;
            this.btnSubmitNewUser.Text = "Submit";
            this.btnSubmitNewUser.UseVisualStyleBackColor = true;
            this.btnSubmitNewUser.Click += new System.EventHandler(this.btnSubmitNewUser_Click);
            // 
            // gbxNewUser
            // 
            this.gbxNewUser.Controls.Add(this.lblNewPassword);
            this.gbxNewUser.Controls.Add(this.lblNewUserName);
            this.gbxNewUser.Controls.Add(this.txtNewPassword);
            this.gbxNewUser.Controls.Add(this.txtNewUser);
            this.gbxNewUser.Location = new System.Drawing.Point(148, 104);
            this.gbxNewUser.Margin = new System.Windows.Forms.Padding(7);
            this.gbxNewUser.Name = "gbxNewUser";
            this.gbxNewUser.Size = new System.Drawing.Size(486, 170);
            this.gbxNewUser.TabIndex = 6;
            this.gbxNewUser.TabStop = false;
            this.gbxNewUser.Text = "  Please fill out the full data form:";
            // 
            // btnCancelCreateNewUser
            // 
            this.btnCancelCreateNewUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCreateNewUser.Location = new System.Drawing.Point(148, 320);
            this.btnCancelCreateNewUser.Name = "btnCancelCreateNewUser";
            this.btnCancelCreateNewUser.Size = new System.Drawing.Size(162, 45);
            this.btnCancelCreateNewUser.TabIndex = 7;
            this.btnCancelCreateNewUser.Text = "Cancel";
            this.btnCancelCreateNewUser.UseVisualStyleBackColor = true;
            this.btnCancelCreateNewUser.Click += new System.EventHandler(this.btnCancelCreateNewUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Ra6d0909857b337cd882be4d9405d6d88;
            this.pictureBox1.Location = new System.Drawing.Point(676, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormCreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelCreateNewUser);
            this.Controls.Add(this.gbxNewUser);
            this.Controls.Add(this.btnSubmitNewUser);
            this.Controls.Add(this.lblUserNameConditions);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCreateNewUser";
            this.Text = "Create New User";
            this.Load += new System.EventHandler(this.FormCreateNewUser_Load);
            this.gbxNewUser.ResumeLayout(false);
            this.gbxNewUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.Label lblUserNameConditions;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnSubmitNewUser;
        private System.Windows.Forms.GroupBox gbxNewUser;
        private System.Windows.Forms.Button btnCancelCreateNewUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}