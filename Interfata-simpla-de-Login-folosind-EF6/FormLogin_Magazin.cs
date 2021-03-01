﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsLogin_Magazin
{
    public partial class FormLogin_Magazin : Form
    {
        

        public FormLogin_Magazin()
        {
            InitializeComponent();
        }

        private void FormLogin_Magazin_Load(object sender, EventArgs e)
        {

        }

        private void txtUserNameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int LoginSwitch = 0;

            Login_MagazinEntities Log_Mag_Ent = new Login_MagazinEntities();

            LoginSwitch = LoginMethod(LoginSwitch, Log_Mag_Ent);

            if (LoginSwitch == 2) MessageBox.Show("Admin is logged.");
            if (LoginSwitch == 1) MessageBox.Show("User is logged.");
            if (LoginSwitch == 0) MessageBox.Show("User is NOT logged.");
        }

        private int LoginMethod(int LoginSwitch, Login_MagazinEntities Log_Mag_Ent)
        {
            foreach (var Login in Log_Mag_Ent.Users_1)
            {

                if ((Login.User_Name == txtUserNameLogin.Text) & 
                    (Login.Password_ == txtPassword_Login.Text))
                {
                    LoginSwitch = Login.Type;
                    break;
                }
            }
            return LoginSwitch;
        }



        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Form frm = new WindowsFormsApp1.FormCreateNewUser();
            frm.Show();
        }

       

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    

  





}
