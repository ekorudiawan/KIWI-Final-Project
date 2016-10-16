using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KIWI_2
{
    public partial class FormMain : Form
    {
        OleDbConnection connection;
        int userPrivileges = 0; // 1 => operator, 2 => teknisi, 3 ==> engineer

        public FormMain()
        {
            InitializeComponent();
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=C:\KIWI2\DB\KIWI2.mdb;
                                            User Id=admin;
                                            Password=;";
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool error = false;
            bool loginSuccess = false;
            try
            {
                connection.Open();
            }
            catch (Exception err)
            {
                error = true;
                MessageBox.Show(err.ToString());
            }
            if (!error)
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from account where username='" + textBoxUserName.Text + "' and password='" + textBoxPassword.Text + "'";
                OleDbDataReader reader =  command.ExecuteReader();
                int count = 0;
                while(reader.Read()) {
                    count++;
                }

                if (count == 1)
                {
                    MessageBox.Show("Login Success !!!");
                    loginSuccess = true;
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username & Password !!!");
                }
                else
                {
                    MessageBox.Show("Username & Password Not Correct !!!");
                }
            }
            connection.Close();
            if (loginSuccess)
            {
                if (textBoxUserName.Text == "operator")
                {
                    userPrivileges = 1;
                }
                else if (textBoxUserName.Text == "teknisi")
                {
                    userPrivileges = 2;
                }
                else
                {
                    userPrivileges = 3;
                }
                this.Hide();
                FormAutomatic formAutomatic = new FormAutomatic(userPrivileges);
                formAutomatic.Show();
            }
            
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangePassword formChangePassword = new FormChangePassword();
            formChangePassword.Show();
        }
    }
}
