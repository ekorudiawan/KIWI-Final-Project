using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO.Ports;
//using Seagull.BarTender.Print;
using Modbus.Device;
using System.Diagnostics;
using System.Threading;
using System.Data.OleDb;

namespace KIWI_2
{
    public partial class FormAutomatic : Form
    {
        bool[] coilM22; // M0-M~
        bool[] lastCoilM22;
        bool printing = false;

        int totalQty = 0, totalPass = 0, totalFail = 0;

        /*// BARTENDER PRINTER
        private const string appName = "Label Print";
        private const string dataSourced = "Data Sourced";
        private Engine engine = null;
        private LabelFormatDocument format = null;

        Printers printers;*/

        // MODBUS TCP modbusMasterTCP
        string ipAddress;
        int tcpPort = 502;
        TcpClient tcpClient = new TcpClient();
        ModbusIpMaster modbusMasterTCP;

        // 
        Thread thread;
        bool threadRun = false;
        bool serialOpen = false;
        string dataSerial;
        string dataHeadAssy;

        ModbusSerialMaster modbusMasterRTU;
        TextBox[] textBoxMW;
        TextBox[] textBoxChar;

        OleDbConnection connection, excelConnection;
        //int userPrivileges = 0; // 1 => operator, 2 => teknisi, 3 ==> engineer

        string stringTotalQtyNow = "null";
        int totalQtyNow;

        public string setTextRef
        {
            get{ return this.textBoxReference.Text;}
            set{ this.textBoxReference.Text = value;}       
            
        }
            
        public FormAutomatic(int userLevel) // 1 = operator, 2 = teknisi, 3 = engineer
        {
            InitializeComponent();
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=C:\KIWI2\DB\New_StarWin.mdb;
                                            User Id=admin;
                                            Password=;";
            excelConnection = new OleDbConnection();
            excelConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
                                            Data Source=C:\KIWI2\DB\New_StarWin.xls;
                                            Extended Properties=Excel 8.0;";

            if (userLevel == 1)
            {
                buttonReferenceData.Enabled = false;
                textBoxSoNo.Enabled = false;
                textBoxReference.Enabled = false;
                textBoxCoil.Enabled = false;
                textBoxHeadAssy.Enabled = false;
                textBoxHeadAssyLabel.Enabled = false;

                textBoxScannerData.Enabled = false;
                textBoxScannerHeadAssy.Enabled = false;
                textBoxTotalQty.Enabled = false;
                textBoxPass.Enabled = false;
                textBoxFail.Enabled = false;

                textBoxA.Enabled = false;
                textBoxB.Enabled = false;
                textBoxC.Enabled = false;
                textBoxD.Enabled = false;
                textBoxE.Enabled = false;
                textBoxF.Enabled = false;

                textBoxG.Enabled = false;
                textBoxH.Enabled = false;
                textBoxJ.Enabled = false;
                textBoxK.Enabled = false;
                textBoxL.Enabled = false;
                textBoxM.Enabled = false;

                textBoxN.Enabled = false;
                textBoxO.Enabled = false;
                textBoxP.Enabled = false;
                textBoxQ.Enabled = false;
                textBoxR.Enabled = false;

                textBoxS.Enabled = false;
                textBoxT.Enabled = false;
                textBoxU.Enabled = false;
                textBoxX.Enabled = false;
                textBoxY.Enabled = false;
                textBoxZ.Enabled = false;

                textBoxVU.Enabled = false;
                textBoxAA1.Enabled = false;
                textBoxAA2.Enabled = false;

                textBoxDataMatrix.Enabled = false;
            }

            serialPortRFID.PortName = "COM2"; //COM2
            serialPortRFID.Open();
            modbusMasterRTU = ModbusSerialMaster.CreateRtu(serialPortRFID);
            
            textBoxMW = new TextBox[32];
            textBoxChar = new TextBox[32];
        }

        private void FormAutomatic_Load(object sender, EventArgs e)
        {
            coilM22 = new bool[1];
            lastCoilM22 = new bool[1];

            coilM22[0] = false;
            lastCoilM22[0] = false;


            // Create Modbus modbusMasterTCP
            ipAddress = "192.168.1.2"; // textBoxIPAddress.Text;
            //ipAddress = "127.0.0.1"; // textBoxIPAddress.Text;
            tcpClient.BeginConnect(ipAddress, tcpPort, null, null);
            modbusMasterTCP = ModbusIpMaster.CreateIp(tcpClient);

            timerReadModbus.Enabled = true; // aktifkan mode baca data dari plc


            // Serial Port Scanner
            serialPortScanner.PortName = "COM1"; //COM1
            
            try
            {
                serialPortScanner.Open();
                serialOpen = true;
            }
            catch (Exception err)
            {                
                serialOpen = false;
                MessageBox.Show(err.ToString());
            }

            if (serialOpen)
            {
                thread = new Thread(bacaDataSerial);
                thread.Start();
                threadRun = true;
            }            

            // Update Current Settings
            loadCurrentSetting();
            // Trigger M8 Kalau 4P
            int a = textBoxReference.Text.IndexOf('T', 4);
            if (a == 4)
            {
                modbusMasterTCP.WriteSingleCoil(1, 8, true);       
            }
            else
            {
                modbusMasterTCP.WriteSingleCoil(1, 8, false);  
            }
            totalPass = Int32.Parse(textBoxPass.Text);
            totalFail = Int32.Parse(textBoxFail.Text);
            totalQty = Int32.Parse(textBoxTotalQty.Text);
           


            // Update ke PLC
            /*
            try
            {
                modbusMasterTCP.WriteSingleRegister(0, (ushort)totalPass); // MW0 == Pass
                modbusMasterTCP.WriteSingleRegister(1, (ushort)totalFail); // MW1 == Fail                
            }
            catch (Exception err)
            {
                // By Pass
            }
             * */
            //
        }

        private void loadCurrentSetting()
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
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "select * from CURR_SETTINGS";
                OleDbDataReader readCurrSettings = command1.ExecuteReader();
                while (readCurrSettings.Read())
                {
                    dataFound = true;

                    textBoxReference.Text = readCurrSettings["REF"].ToString();
                    textBoxSoNo.Text = readCurrSettings["SONO"].ToString();
                    textBoxTotalQty.Text = readCurrSettings["TOTAL"].ToString();
                    textBoxPass.Text = readCurrSettings["PASS"].ToString();
                    textBoxFail.Text = readCurrSettings["FAIL"].ToString();
                }

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                command2.CommandText = "select * from SETTINGS where FGCODE='" + textBoxReference.Text + "'";
                OleDbDataReader readPrintData = command2.ExecuteReader();
                while (readPrintData.Read())
                {
                    dataFound = true;
                    textBoxCoil.Text = readPrintData["COIL"].ToString();
                    textBoxHeadAssy.Text = readPrintData["H_PART_NO"].ToString().Trim();
                    textBoxHeadAssyLabel.Text = readPrintData["H_PART_H_READ"].ToString();

                    textBoxA.Text = readPrintData["A"].ToString();
                    textBoxB.Text = readPrintData["B"].ToString();
                    textBoxC.Text = readPrintData["C"].ToString();
                    textBoxD.Text = readPrintData["D"].ToString();
                    textBoxE.Text = readPrintData["E"].ToString();
                    textBoxF.Text = readPrintData["F"].ToString();

                    textBoxG.Text = readPrintData["G"].ToString();
                    textBoxH.Text = readPrintData["H"].ToString();
                    textBoxJ.Text = readPrintData["J"].ToString();
                    textBoxK.Text = readPrintData["K"].ToString();
                    textBoxL.Text = readPrintData["L"].ToString();
                    textBoxM.Text = readPrintData["M"].ToString();

                    textBoxN.Text = readPrintData["N"].ToString();
                    textBoxO.Text = readPrintData["O"].ToString();
                    textBoxP.Text = readPrintData["P"].ToString();
                    textBoxQ.Text = readPrintData["Q"].ToString();
                    textBoxR.Text = readPrintData["R"].ToString();

                    textBoxS.Text = readPrintData["S"].ToString();
                    textBoxT.Text = readPrintData["T"].ToString();
                    textBoxU.Text = readPrintData["U"].ToString();
                    textBoxX.Text = readPrintData["X"].ToString();
                    textBoxY.Text = readPrintData["Y"].ToString();
                    textBoxZ.Text = readPrintData["Z"].ToString();

                    textBoxVU.Text = readPrintData["VU"].ToString();
                    textBoxAA1.Text = readPrintData["AA1"].ToString();
                    textBoxAA2.Text = readPrintData["AA2"].ToString();
                }

                if (!dataFound)
                {
                    MessageBox.Show("Reference Not Found", "Warning");
                }
            }
            connection.Close();
        }

        private void updateCurrentSetting()
        {
            bool error = false;
            bool dataFound = false;
            string currReference = "null";
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
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "select * from CURR_SETTINGS";
                OleDbDataReader readCurrSettings = command1.ExecuteReader();
                while (readCurrSettings.Read())
                {
                    dataFound = true;
                    currReference = readCurrSettings["REF"].ToString();                    
                }

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                command2.CommandText = "update CURR_SETTINGS set SONO = '"+textBoxSoNo.Text+"', REF = '"+textBoxReference.Text+"', TOTAL = '"+textBoxTotalQty.Text+"', PASS = '"+textBoxPass.Text+"', FAIL = '"+textBoxFail.Text+"' WHERE REF = '"+currReference+"'";
                command2.ExecuteNonQuery();               
                
                if (!dataFound)
                {
                    MessageBox.Show("Reference Not Found", "Warning");
                }

            }
            connection.Close();
        }


        private void bacaDataSerial()
        {
            while (serialOpen)
            {
                if (serialPortScanner.BytesToRead > 0)
                {
                    
                    char data = (char)serialPortScanner.ReadChar();
                    if(data !='\r' || data != '\n') {
                        dataSerial += data; 
                    }

                    if (data == '\n')
                    {
                        Invoke(new Action(() => textBoxScannerData.Text = dataSerial));
                        // Check Length
                        if (dataSerial.Length == 32)
                        {
                            // Check Head Assy
                            for (int i = 6; i < 22; i++)
                            {
                                dataHeadAssy += dataSerial[i];
                            }

                            
                            // Update TextBox Head Assy
                            Invoke(new Action(() => textBoxScannerHeadAssy.Text = dataHeadAssy));
                            //Invoke(new Action(() => textBoxTotalQty.Text = totalQty.ToString()));

                            // Compare Pass Fail
                            int retCompare = string.Compare(textBoxScannerHeadAssy.Text, textBoxHeadAssy.Text);
                            //retCompare = 0; // saya baypass dlu
                            // Pass Product
                            if (retCompare == 0)
                            {
                                totalPass++;
                                // Update Textbox
                                Invoke(new Action(() => textBoxPass.Text = totalPass.ToString()));
                                setTotalQty(getTotalQty() + 1); // update product count

                                // Update Textbox Data Matrix
                                DateTime date = DateTime.Now;
                                string stringDate = date.ToString("ddMMyyhhmmss");
                                string stringDataMatrix = textBoxReference.Text + stringDate + " "+getTotalQty().ToString("D"+5);
                                Invoke(new Action(() => textBoxDataMatrix.Text = stringDataMatrix));                   

                                // Update Excell Data
                                updateExcelData();
                                // Send Pass Signal
                                try
                                {
                                    modbusMasterTCP.WriteSingleCoil(1, 11, true); // M11 => false                                    
                                }
                                catch (Exception err)
                                {
                                    MessageBox.Show(err.ToString());
                                }
                          
                            }
                            else
                            {
                                totalFail++;
                                Invoke(new Action(() => textBoxFail.Text = totalFail.ToString()));
                                Invoke(new Action(() => textBoxDataMatrix.Text = ""));
                                try
                                {
                                    modbusMasterTCP.WriteSingleCoil(1, 11, false); // M11 => false                                    
                                }
                                catch (Exception err)
                                {
                                    MessageBox.Show(err.ToString());
                                }
                            }                            
                            
                            // Message to operator
                            // If Fail Show Textbox
                            if (retCompare != 0)
                            {
                                MessageBox.Show("Product Fail, Please Remove Product !!");                               //MessageBox.Show("dfas","Asda","
                                    

                                
                            }
                            // If Pass Printing
                            else
                            {
                                //MessageBox.Show("masuk");

                                int a = textBoxReference.Text.IndexOf('T', 4);
                                if (a == 4)
                                {
                                    printLabel(3);
                                    //MessageBox.Show("4P");
                                }
                                else
                                {
                                    if (textBoxAA1.Text == "")
                                    {
                                        printLabel(2); // 3 pole no kc
                                        //MessageBox.Show("3pkc");
                                    }
                                    else
                                    {
                                        printLabel(1); // 3 pole
                                        //MessageBox.Show("3P");
                                    }
                                }
                                
                            }


                            if (totalPass == totalQty)
                            {
                                MessageBox.Show("Production Completed !" + "Total Pass = " + totalPass.ToString()+"Total Qty = "+totalQty.ToString());
                            }

                            Invoke(new Action(() => timerClearScannerData.Enabled = true)); // aktifkan timer clear

                            dataSerial = ""; 
                            dataHeadAssy = "";
                        }
                        else
                        {
                            try
                            {
                                modbusMasterTCP.WriteSingleCoil(1, 11, false); // M11 => false                                    
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.ToString());
                            }
                            //MessageBox.Show("Scanner NO READ, Please Rescan !!");
                            //timerClearScannerData.Enabled = true;
                            Invoke(new Action(() => timerClearScannerData.Enabled = true));
                            dataSerial = "";
                            dataHeadAssy = "";
                        }
                    }
                }
            }
        }

        private void printLabel(int labelOption)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";           
            
            if (labelOption == 1)
            {
                //format = engine.Documents.Open(@"C:\KIWI2\Data Print\DinRail3Pole.btw");
                startInfo.Arguments = "/c bartend.exe /f=DinRail3Pole.btw /p /x";
            }
            else if (labelOption == 2)
            {
                //format = engine.Documents.Open(@"C:\KIWI2\Data Print\DinRail3PoleNoKCC.btw");
                startInfo.Arguments = "/c bartend.exe /f=DinRail3PoleNoKCC.btw /p /x";
            }
            else if (labelOption == 3)
            {
                //format = engine.Documents.Open(@"C:\KIWI2\Data Print\DinRail4Pole.btw");
                startInfo.Arguments = "/c bartend.exe /f=DinRail4Pole.btw /p /x";
            }
            process.StartInfo = startInfo;
            process.Start();
            
        }

        private void buttonAutoOrder_Click(object sender, EventArgs e)
        {
            timerReadRFID.Enabled = true;            
        }

        private void timerReadRFID_Tick(object sender, EventArgs e)
        {
            getRfidData();
        }

        private void getRfidData()
        {
            bool success = false;
            string[] dataString = new string[32];
            string reference = null, order_qty = null, coil = null, headNo = null, safety = null, connector = null, typeConn = null, salesOrder = null, lineNo = null;
            try
            {
                ushort[] regMW = modbusMasterRTU.ReadHoldingRegisters(1, 0, 32);
                for (int i = 0; i < 32; i++)
                {
                    int upper = regMW[i] >> 8;
                    int lower = regMW[i] & 0x00FF;
                    int karakter = upper & lower;
                    dataString[i] = Convert.ToChar(lower).ToString() + Convert.ToChar(upper).ToString();
                }

                reference = null;

                for (int i = 0; i < 10; i++)
                {
                    reference += dataString[i];
                }

                order_qty = regMW[10].ToString();

                coil = null;
                for (int i = 11; i < 13; i++)
                {
                    coil += dataString[i];
                }

                headNo = null;
                for (int i = 13; i < 21; i++)
                {
                    headNo += dataString[i];
                }

                safety = null;
                safety = regMW[21].ToString();

                connector = null;
                connector = regMW[22].ToString();

                typeConn = null;
                typeConn = regMW[23].ToString();

                salesOrder = null;
                for (int i = 25; i < 32; i++)
                {
                    salesOrder += dataString[i];
                }

                lineNo = null;
                for (int i = 24; i < 32; i++)
                {
                    lineNo += dataString[i];
                }
                success = true;
            }
            catch (Exception err)
            {
                success = false;
            }
            if (success)
            {
                timerReadRFID.Enabled = false;
                MessageBox.Show("Reference\t\t: " + reference + "\r\n" +
                                "Order Qty\t\t: " + order_qty + "\r\n" +
                                "Coil\t\t: " + coil + "\r\n" +
                                "Safety\t\t: " + safety + "\r\n" +
                                "Connector\t: " + connector + "\r\n" +
                                "Type Connector\t: " + typeConn + "\r\n" +
                                "Sales Order\t: " + salesOrder + "\r\n",
                                "Running Product");
                textBoxSoNo.Text = salesOrder;
                textBoxTotalQty.Text = order_qty;
                textBoxPass.Text = "0";
                textBoxFail.Text = "0";
                totalQty = Int32.Parse(order_qty);
                totalPass = 0;
                totalFail = 0;
                /*
                try
                {
                    // Update ke PLC
                    modbusMasterTCP.WriteSingleRegister(0, (ushort)totalPass); // MW0 == Pass
                    modbusMasterTCP.WriteSingleRegister(1, (ushort)totalFail); // MW0 == Pass
                    //
                }
                catch(Exception err) {
                }
                 * */
                updateParameter(reference);

                // Update M8 di PLC
                int a = textBoxReference.Text.IndexOf('T', 4);
                if (a == 4)
                {
                    modbusMasterTCP.WriteSingleCoil(1, 8, true);
                }
                else
                {
                    modbusMasterTCP.WriteSingleCoil(1, 8, false);
                }
            }
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
                command.CommandText = "select * from SETTINGS where FGCODE='"+refProduct+"'";
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


                if (!dataFound)
                {
                    MessageBox.Show("Reference Not Found","Warning");
                }                
            }
            connection.Close();            
        }

        private void updateExcelData()
        {
            string query = "Update [Sheet1$] set A = '" + textBoxA.Text +"A"+ "' , B = '" + textBoxB.Text + "' , C = '" + textBoxC.Text + "' , D = '" + textBoxD.Text + "' , E = '" + textBoxE.Text + "' , F = '" + textBoxF.Text + "' , G = '" + textBoxG.Text + "' , H = '" + textBoxH.Text + "HP"+"' , J = '" + textBoxJ.Text + "HP"+"' , K = '" + textBoxK.Text + "HP"+"' , L = '" + textBoxL.Text + "HP"+ "' , M = '" + textBoxM.Text + "HP"+"' , N = '" + textBoxN.Text + "A"+"' , O = '" + textBoxO.Text + "' , P = '" + textBoxP.Text + "' , Q = '" + textBoxQ.Text + "HP"+"' , R = '" + textBoxR.Text + "' , S = '" + textBoxS.Text + "' , T = '" + textBoxT.Text + "' , U = '" + textBoxU.Text + "' , X = '" + textBoxX.Text + "' , Y = '" + textBoxY.Text + "' , Z = '" + textBoxZ.Text + "' , VU = '" + textBoxVU.Text + "' , AA1 = '" + textBoxAA1.Text + "' , AA2 = '" + textBoxAA2.Text + "' , MATRIX = '" + textBoxDataMatrix.Text + "'";
            bool error = false;
            try
            {
                excelConnection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = excelConnection;
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                error = true;
                MessageBox.Show(err.ToString());
            }
             
            excelConnection.Close();
            
        }

        private int getTotalQty()
        {
            bool error = false;
            bool dataFound = false;
            DateTime date = DateTime.Now;
            string stringDate = date.ToString("MM/dd/yyyy");
            int qty = 0;
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
                try
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "select * from SERIEL_COUNT where DTE=@dateNow";
                    command.Parameters.Add("@dateNow", OleDbType.Date).Value = stringDate;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dataFound = true;
                        qty = Int32.Parse(reader["TOTAL"].ToString());
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                // kalau ada record hari ini
                if (!dataFound)
                {
                    //qty = Int32.Parse(stringTotalQtyNow);
                    qty = 0;
                }
            }
            connection.Close();
            return qty;
        }

        private void setTotalQty(int qty)
        {
            bool error = false;
            bool dataFound = false;
            DateTime date = DateTime.Now;
            string stringDate = date.ToString("MM/dd/yyyy");
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
                command.CommandText = "select * from SERIEL_COUNT where DTE = #"+stringDate+"#";

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataFound = true;                         
                }
                // kalau ada record hari ini
                if (dataFound)
                {
                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connection;
                    command1.CommandText = "update SERIEL_COUNT set TOTAL = "+qty.ToString()+" WHERE DTE = #"+stringDate+"#";
                    command1.ExecuteNonQuery();
                }
                else
                {
                    OleDbCommand command2 = new OleDbCommand();
                    command2.Connection = connection;
                    command2.CommandText = "insert into SERIEL_COUNT (DTE, TOTAL) VALUES (#"+stringDate+"#, "+ qty.ToString() +")";
                    int a = 2;
                    command2.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        private void FormAutomatic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadRun)
            {
                thread.Abort();
            }
            if (serialPortRFID.IsOpen)
            {
                serialPortRFID.Close();
            }
            if (serialPortScanner.IsOpen)
            {
                serialPortScanner.Close();
            }
            updateCurrentSetting();
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (threadRun)
            {
                thread.Abort();
            }
            if(serialPortRFID.IsOpen) {
                serialPortRFID.Close();
            }
            if (serialPortScanner.IsOpen)
            {
                serialPortScanner.Close();
            }
            updateCurrentSetting();
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (threadRun)
            {
                thread.Abort();
            }
            if (serialPortRFID.IsOpen)
            {
                serialPortRFID.Close();
            }
            if (serialPortScanner.IsOpen)
            {
                serialPortScanner.Close();
            }
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }      

        private void buttonReferenceData_Click(object sender, EventArgs e)
        {
            FormNewReference formNewReference = new FormNewReference();
            formNewReference.Show();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getTotalQty().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setTotalQty(100);
        }
        */
        private void timerClearScannerData_Tick(object sender, EventArgs e)
        {
            //textBoxScannerData.Text = "";
            Invoke(new Action(() => textBoxScannerData.Text = ""));
            Invoke(new Action(() => textBoxScannerHeadAssy.Text = ""));
        }

        private void timerReadModbus_Tick(object sender, EventArgs e)
        {
            try
            {
                coilM22 = modbusMasterTCP.ReadCoils(22, 1);
            }
            catch (Exception err)
            {
                //timerReadModbus.Enabled = false;
                //MessageBox.Show("Failed Connect To Modbus, Check Serial Port Or Ethernet Connection !!!\r\n\r\n" + err.ToString());
            }

            // Check Rising Of M55 // Print From HMI

            if (lastCoilM22[0] == false && coilM22[0] == true)
            {
                updateExcelData();
                int a = textBoxReference.Text.IndexOf('T', 4);
                if (a == 4)
                {
                    printLabel(3);
                    //MessageBox.Show("4P");
                }
                else
                {
                    if (textBoxAA1.Text == "")
                    {
                        printLabel(2); // 3 pole no kc
                        //MessageBox.Show("3pkc");
                    }
                    else
                    {
                        printLabel(1); // 3 pole
                        //MessageBox.Show("3P");
                    }
                }
                //printing = true;
                MessageBox.Show("Manual Printing Successful !");
            }

            lastCoilM22[0] = coilM22[0];
            
        }
    }
}
