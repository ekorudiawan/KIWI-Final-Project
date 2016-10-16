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
    public partial class FormNewReference : Form
    {

        OleDbConnection connection, excelConnection;

        public FormNewReference()
        {
            InitializeComponent();
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=C:\KIWI2\DB\New_StarWin.mdb;
                                            User Id=admin;
                                            Password=;";
            autoCompleteText();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormNewReference_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxReference.Text != "")
            {
                addNewReference();
                autoCompleteText();
                clearAllText();
            }
            else
            {
                MessageBox.Show("Reference Cannot Be Empty !");
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (textBoxReference.Text != "")
            {
                updateReference(textBoxReference.Text);
                autoCompleteText();
                clearAllText();
            }
            else
            {
                MessageBox.Show("Reference Cannot Be Empty !");
            }
        }             

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxReference.Text != "")
            {
                deleteReference(textBoxReference.Text);
                autoCompleteText();
                clearAllText();
            }
        }

        private void textBoxReference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateParameter(textBoxReference.Text);
            }
        }

        private void clearAllText()
        {
            textBoxReference.Text = "";
            textBoxReference.Text = "";
            textBoxCoil.Text = "";
            textBoxHeadAssy.Text = "";
            textBoxHeadAssyLabel.Text = "";

            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            textBoxD.Text = "";
            textBoxE.Text = "";
            textBoxF.Text = "";

            textBoxG.Text = "";
            textBoxH.Text = "";
            textBoxJ.Text = "";
            textBoxK.Text = "";
            textBoxL.Text = "";
            textBoxM.Text = "";

            textBoxN.Text = "";
            textBoxO.Text = "";
            textBoxP.Text = "";
            textBoxQ.Text = "";
            textBoxR.Text = "";

            textBoxS.Text = "";
            textBoxT.Text = "";
            textBoxU.Text = "";
            textBoxX.Text = "";
            textBoxY.Text = "";
            textBoxZ.Text = "";

            textBoxVU.Text = "";
            textBoxAA1.Text = "";
            textBoxAA2.Text = "";
        }

        public void autoCompleteText()
        {
            textBoxReference.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxReference.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            bool error = false;
            bool dataFound = false;
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
                command.CommandText = "select * from SETTINGS";
                OleDbDataReader readSettings = command.ExecuteReader();
                while (readSettings.Read())
                {
                    string par = readSettings["FGCODE"].ToString();
                    coll.Add(par);
                }
            }
            connection.Close();
            textBoxReference.AutoCompleteCustomSource = coll;
        }

        private void updateParameter(string refProduct)
        {
            bool error = false;
            bool dataFound = false;
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
                command.CommandText = "select * from SETTINGS where FGCODE='" + refProduct + "'";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataFound = true;

                    textBoxReference.Text = reader["FGCODE"].ToString();
                    textBoxCoil.Text = reader["COIL"].ToString();
                    textBoxHeadAssy.Text = reader["H_PART_NO"].ToString().Trim();
                    textBoxHeadAssyLabel.Text = reader["H_PART_H_READ"].ToString();

                    textBoxA.Text = reader["A"].ToString();
                    textBoxB.Text = reader["B"].ToString();
                    textBoxC.Text = reader["C"].ToString();
                    textBoxD.Text = reader["D"].ToString();
                    textBoxE.Text = reader["E"].ToString();
                    textBoxF.Text = reader["F"].ToString();

                    textBoxG.Text = reader["G"].ToString();
                    textBoxH.Text = reader["H"].ToString();
                    textBoxJ.Text = reader["J"].ToString();
                    textBoxK.Text = reader["K"].ToString();
                    textBoxL.Text = reader["L"].ToString();
                    textBoxM.Text = reader["M"].ToString();

                    textBoxN.Text = reader["N"].ToString();
                    textBoxO.Text = reader["O"].ToString();
                    textBoxP.Text = reader["P"].ToString();
                    textBoxQ.Text = reader["Q"].ToString();
                    textBoxR.Text = reader["R"].ToString();

                    textBoxS.Text = reader["S"].ToString();
                    textBoxT.Text = reader["T"].ToString();
                    textBoxU.Text = reader["U"].ToString();
                    textBoxX.Text = reader["X"].ToString();
                    textBoxY.Text = reader["Y"].ToString();
                    textBoxZ.Text = reader["Z"].ToString();

                    textBoxVU.Text = reader["VU"].ToString();
                    textBoxAA1.Text = reader["AA1"].ToString();
                    textBoxAA2.Text = reader["AA2"].ToString();
                }
            }
            connection.Close();
        }

        private void addNewReference()
        {
            bool error1 = false, error2 = false;
            try
            {
                connection.Open();
            }
            catch (Exception err)
            {
                error1 = true;
                MessageBox.Show(err.ToString());
            }
            if (!error1)
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into SETTINGS (SLNO, MATRIX, H_PART_NO, H_PART_H_READ, COUNTRYCODE, COIL, A, B, C, D, E, F, G, H, J, K, L, M, N, O, P, Q, R, S, T, U, FGCODE, X, Y, Z, VU, AA1, AA2)" + "VALUES (" +
                                      "' '," +
                                      "' '," +
                                      "'" + textBoxHeadAssy.Text + "'," +
                                      "'" + textBoxHeadAssyLabel.Text + "'," +
                                      "' '," +
                                      "'" + textBoxCoil.Text + "'," +
                                      "'" + textBoxA.Text + "'," +
                                      "'" + textBoxB.Text + "'," +
                                      "'" + textBoxC.Text + "'," +
                                      "'" + textBoxD.Text + "'," +
                                      "'" + textBoxE.Text + "'," +
                                      "'" + textBoxF.Text + "'," +
                                      "'" + textBoxG.Text + "'," +
                                      "'" + textBoxH.Text + "'," +
                                      "'" + textBoxJ.Text + "'," +
                                      "'" + textBoxK.Text + "'," +
                                      "'" + textBoxL.Text + "'," +
                                      "'" + textBoxM.Text + "'," +
                                      "'" + textBoxN.Text + "'," +
                                      "'" + textBoxO.Text + "'," +
                                      "'" + textBoxP.Text + "'," +
                                      "'" + textBoxQ.Text + "'," +
                                      "'" + textBoxR.Text + "'," +
                                      "'" + textBoxS.Text + "'," +
                                      "'" + textBoxT.Text + "'," +
                                      "'" + textBoxU.Text + "'," +
                                      "'" + textBoxReference.Text + "'," +
                                      "'" + textBoxX.Text + "'," +
                                      "'" + textBoxY.Text + "'," +
                                      "'" + textBoxZ.Text + "'," +
                                      "'" + textBoxVU.Text + "'," +
                                      "'" + textBoxAA1.Text + "'," +
                                      "'" + textBoxAA2.Text + "')";
                try
                {
                    command.ExecuteNonQuery();
                    error2 = false;
                }
                catch (Exception err)
                {
                    error2 = true;
                    MessageBox.Show(err.ToString());
                }
                if (!error2)
                {
                    MessageBox.Show("Add New Reference Completed !");
                }
            }
            connection.Close();
        }

        private void updateReference(string reference)
        {
            bool error = false;
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
                //  "update CURR_SETTINGS set SONO = '"+textBoxSoNo.Text+"', REF = '"+textBoxReference.Text+"', TOTAL = '"+textBoxTotalQty.Text+"', PASS = '"+textBoxPass.Text+"', FAIL = '"+textBoxFail.Text+"' WHERE REF = '"+currReference+"'";
                command.CommandText = "update SETTINGS set SLNO = ' ', MATRIX = ' ', H_PART_NO = '"+textBoxHeadAssy.Text+"' , H_PART_H_READ = '"+textBoxHeadAssyLabel.Text+"' , COUNTRYCODE = ' ', COIL = '"+textBoxCoil.Text+"' , A = '"+textBoxA.Text+"' , B = '"+textBoxB.Text+"' , C = '"+textBoxC.Text+"' , D = '"+textBoxD.Text+"' , E = '"+textBoxE.Text+"' , F = '"+textBoxF.Text+"' , G = '"+textBoxG.Text+"' , H = '"+textBoxH.Text+"' , J = '"+textBoxJ.Text+"' , K = '"+textBoxK.Text+"' , L = '"+textBoxL.Text+"' , M = '"+textBoxM.Text+"' , N = '"+textBoxN.Text+"' , O = '"+textBoxO.Text+"' , P = '"+textBoxP.Text+"' , Q = '"+textBoxQ.Text+"' , R = '"+textBoxR.Text+"' , S = '"+textBoxS.Text+"' , T = '"+textBoxT.Text+"' , U = '"+textBoxU.Text+"' , X = '"+textBoxX.Text+"' , Y = '"+textBoxY.Text+"' , Z = '"+textBoxZ.Text+"' , VU = '"+textBoxVU.Text+"' , AA1 = '"+textBoxAA1.Text+"' , AA2 = '"+textBoxAA2.Text+"' WHERE FGCODE = '" + reference+"'";                                     
                command.ExecuteNonQuery();
                MessageBox.Show("Update Reference Successfully !");
            }
            connection.Close();
        }

        private void deleteReference(string reference)
        {
            bool error = false;
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
                //  "update CURR_SETTINGS set SONO = '"+textBoxSoNo.Text+"', REF = '"+textBoxReference.Text+"', TOTAL = '"+textBoxTotalQty.Text+"', PASS = '"+textBoxPass.Text+"', FAIL = '"+textBoxFail.Text+"' WHERE REF = '"+currReference+"'";
                command.CommandText = "delete from SETTINGS where FGCODE = '"+textBoxReference.Text+"'";
                command.ExecuteNonQuery();
                MessageBox.Show("Delete Reference Successfully !");
            }
            connection.Close();
        }

        
    }
}
