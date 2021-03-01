using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormCreateNewUser : Form
    {
        public FormCreateNewUser()
        {
            InitializeComponent();
        }

        private void FormCreateNewUser_Load(object sender, EventArgs e)
        {

        }

        private void txtNewUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitNewUser_Click(object sender, EventArgs e)
        {

             bool IsNewUserNameValid()
            {
                if (txtNewUser.Text == "")
                {
                    MessageBox.Show("Please enter a name.");
                    return false;
                }

                else
                {
                    if (txtNewPassword.Text == "")
                    {
                        MessageBox.Show("Please enter a passwd.");
                        return false;
                    }

                    else
                    {
                        return true;
                    }
                }

            }



            if (IsNewUserNameValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(WindowsFormsLogin_Magazin.Properties.Settings.Default.connString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("Login_Magazin.uspNewUser_Name", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add input parameter for the stored procedure and specify what to use as its value.
                        sqlCommand.Parameters.Add(new SqlParameter("@User_Name", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@User_Name"].Value = txtNewUser.Text;
                        sqlCommand.Parameters.Add(new SqlParameter("@Password_", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@Password_"].Value = txtNewPassword.Text;


                        // Add the output parameter.
                        sqlCommand.Parameters.Add(new SqlParameter("@User_ID", SqlDbType.Int));
                        sqlCommand.Parameters["@User_ID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            // Run the stored procedure.
                            sqlCommand.ExecuteNonQuery();
                            int IUser_ID;
                           // User ID is an IDENTITY value from the database.
                            IUser_ID = (int)sqlCommand.Parameters["@User_ID"].Value;
                            MessageBox.Show(text: "User ID =" + IUser_ID);

                        }
                        catch
                        {
                            MessageBox.Show("User ID was not returned. Account could not be created.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnCancelCreateNewUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
