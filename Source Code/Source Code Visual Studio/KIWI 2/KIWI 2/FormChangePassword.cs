using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace KIWI_2
{
    public partial class FormChangePassword : Form
    {
        OleDbConnection connection;

        public FormChangePassword()
        {
            InitializeComponent();
            InitializeComponent();
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=D:\Database\KIWI2.mdb;
                                            User Id=admin;
                                            Password=;";
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            bool error = false;
            bool changeSuccess = false;
            bool changeAllowed = false;

            String str1 = textBox1.Text;
            String str2 = textBox2.Text;
            Debug.WriteLine("sasasa");
            Debug.WriteLine(textBox1.Text);
            Debug.WriteLine(textBox2.Text);
            bool retCompare = string.Equals("ASA", "ASA");
            MessageBox.Show(retCompare.ToString());
            if (retCompare ==true)
            {
                changeAllowed = true;
                //MessageBox.Show("ok");
            }
            else
            {
                //MessageBox.Show("fail");
                changeAllowed = false;
            }

            try
            {
                connection.Open();
            }
            catch (Exception err)
            {
                error = true;
                MessageBox.Show(err.ToString());
            }
            connection.Close();
        }


    }
}
