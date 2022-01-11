using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentManagement.Screens.Templets;
using JIDBFramwork;
using StudentManagement.Utilities;
using StudentManagement.Models.Users;
using JIDBFramwork.Windows;

namespace StudentManagement.Screens
{
    public partial class LoginForm : TempletForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( IsFromValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());

                bool isLoginDetailsCorrect = Convert.ToBoolean (db.GetScalarValue("usp_UserCheckLoginDetails" ,GetParameters()));
                if (isLoginDetailsCorrect)
                {
                    GetLoggedInUserSetting();

                    this.Hide();

                    DashboardForm df = new DashboardForm();
                    df.Show();
                }
                else
                {
                    JIMessageBox.ShowErrorMessage("UserName / Password is Not correct.");
                    //MessageBox.Show("UserName / Password is Not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetLoggedInUserSetting()
        {
            LoggedInUser.UserName = UserNameTextBox.Text.Trim();
        }

        private DbParameter[] GetParameters()
        {
            List<DbParameter> parameters = new List<DbParameter>();
            DbParameter dbparam1 = new DbParameter();
            dbparam1.Parameter = "@UserName";
            dbparam1.value = UserNameTextBox.Text;
            parameters.Add(dbparam1);

            DbParameter dbparam2 = new DbParameter();
            dbparam2.Parameter = "@Password";
            dbparam2.value = PasswordTextBox.Text;
            parameters.Add(dbparam2);

            return parameters.ToArray();
        }

        private bool IsFromValid()
        {
         
            if (UserNameTextBox.Text.Trim() == String.Empty)
            {
                JIMessageBox.ShowErrorMessage("User Name is Required.");
                //MessageBox.Show("User Name is Required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Clear();
                UserNameTextBox.Focus();
               return false;
            }

              if (PasswordTextBox.Text.Trim() == String.Empty)
              {
                  JIMessageBox.ShowErrorMessage("Password is Required.");
                  //MessageBox.Show("Password is Required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  PasswordTextBox.Clear();
                  PasswordTextBox.Focus();
                  return false;
              }
            return true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }


    }
}
