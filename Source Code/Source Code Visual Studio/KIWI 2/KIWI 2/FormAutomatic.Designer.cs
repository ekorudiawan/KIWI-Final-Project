﻿namespace KIWI_2
{
    partial class FormAutomatic
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxHeadAssyLabel = new System.Windows.Forms.TextBox();
            this.textBoxHeadAssy = new System.Windows.Forms.TextBox();
            this.textBoxCoil = new System.Windows.Forms.TextBox();
            this.textBoxReference = new System.Windows.Forms.TextBox();
            this.textBoxSoNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDataMatrix = new System.Windows.Forms.TextBox();
            this.textBoxAA2 = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxAA1 = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxVU = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxU = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxO = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxJ = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxScannerData = new System.Windows.Forms.TextBox();
            this.textBoxFail = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxTotalQty = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBoxScannerHeadAssy = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.serialPortScanner = new System.IO.Ports.SerialPort(this.components);
            this.buttonAutoOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.timerReadRFID = new System.Windows.Forms.Timer(this.components);
            this.serialPortRFID = new System.IO.Ports.SerialPort(this.components);
            this.buttonReferenceData = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label34 = new System.Windows.Forms.Label();
            this.timerClearScannerData = new System.Windows.Forms.Timer(this.components);
            this.timerReadModbus = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxHeadAssyLabel);
            this.groupBox1.Controls.Add(this.textBoxHeadAssy);
            this.groupBox1.Controls.Add(this.textBoxCoil);
            this.groupBox1.Controls.Add(this.textBoxReference);
            this.groupBox1.Controls.Add(this.textBoxSoNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Running Product";
            // 
            // textBoxHeadAssyLabel
            // 
            this.textBoxHeadAssyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeadAssyLabel.Location = new System.Drawing.Point(173, 173);
            this.textBoxHeadAssyLabel.Name = "textBoxHeadAssyLabel";
            this.textBoxHeadAssyLabel.Size = new System.Drawing.Size(200, 26);
            this.textBoxHeadAssyLabel.TabIndex = 9;
            // 
            // textBoxHeadAssy
            // 
            this.textBoxHeadAssy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeadAssy.Location = new System.Drawing.Point(173, 137);
            this.textBoxHeadAssy.Name = "textBoxHeadAssy";
            this.textBoxHeadAssy.Size = new System.Drawing.Size(200, 26);
            this.textBoxHeadAssy.TabIndex = 8;
            // 
            // textBoxCoil
            // 
            this.textBoxCoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoil.Location = new System.Drawing.Point(173, 101);
            this.textBoxCoil.Name = "textBoxCoil";
            this.textBoxCoil.Size = new System.Drawing.Size(200, 26);
            this.textBoxCoil.TabIndex = 7;
            // 
            // textBoxReference
            // 
            this.textBoxReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReference.Location = new System.Drawing.Point(173, 65);
            this.textBoxReference.Name = "textBoxReference";
            this.textBoxReference.Size = new System.Drawing.Size(200, 26);
            this.textBoxReference.TabIndex = 6;
            // 
            // textBoxSoNo
            // 
            this.textBoxSoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoNo.Location = new System.Drawing.Point(173, 29);
            this.textBoxSoNo.Name = "textBoxSoNo";
            this.textBoxSoNo.Size = new System.Drawing.Size(200, 26);
            this.textBoxSoNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Head Assy Label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Head Assy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reference";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "S.O. No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDataMatrix);
            this.groupBox2.Controls.Add(this.textBoxAA2);
            this.groupBox2.Controls.Add(this.textBoxZ);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.textBoxAA1);
            this.groupBox2.Controls.Add(this.textBoxY);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.textBoxVU);
            this.groupBox2.Controls.Add(this.textBoxX);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.textBoxU);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.textBoxT);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.textBoxS);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.textBoxR);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.textBoxQ);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.textBoxP);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBoxO);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBoxN);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBoxM);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBoxL);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBoxK);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxJ);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxH);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxG);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxF);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBoxE);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxD);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxC);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 395);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print Data";
            // 
            // textBoxDataMatrix
            // 
            this.textBoxDataMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataMatrix.Location = new System.Drawing.Point(11, 359);
            this.textBoxDataMatrix.Name = "textBoxDataMatrix";
            this.textBoxDataMatrix.Size = new System.Drawing.Size(750, 26);
            this.textBoxDataMatrix.TabIndex = 19;
            this.textBoxDataMatrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAA2
            // 
            this.textBoxAA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAA2.Location = new System.Drawing.Point(515, 297);
            this.textBoxAA2.Name = "textBoxAA2";
            this.textBoxAA2.Size = new System.Drawing.Size(246, 26);
            this.textBoxAA2.TabIndex = 29;
            this.textBoxAA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZ.Location = new System.Drawing.Point(641, 235);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(120, 26);
            this.textBoxZ.TabIndex = 45;
            this.textBoxZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(515, 264);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(246, 30);
            this.label29.TabIndex = 28;
            this.label29.Text = "AA2";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(11, 326);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(750, 30);
            this.label37.TabIndex = 18;
            this.label37.Text = "MATRIX";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(641, 202);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(120, 30);
            this.label26.TabIndex = 44;
            this.label26.Text = "Z";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAA1
            // 
            this.textBoxAA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAA1.Location = new System.Drawing.Point(263, 297);
            this.textBoxAA1.Name = "textBoxAA1";
            this.textBoxAA1.Size = new System.Drawing.Size(246, 26);
            this.textBoxAA1.TabIndex = 27;
            this.textBoxAA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY.Location = new System.Drawing.Point(515, 235);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(120, 26);
            this.textBoxY.TabIndex = 43;
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(263, 264);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(246, 30);
            this.label30.TabIndex = 26;
            this.label30.Text = "AA1";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(515, 202);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 30);
            this.label27.TabIndex = 42;
            this.label27.Text = "Y";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxVU
            // 
            this.textBoxVU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVU.Location = new System.Drawing.Point(11, 297);
            this.textBoxVU.Name = "textBoxVU";
            this.textBoxVU.Size = new System.Drawing.Size(246, 26);
            this.textBoxVU.TabIndex = 25;
            this.textBoxVU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX.Location = new System.Drawing.Point(389, 235);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(120, 26);
            this.textBoxX.TabIndex = 41;
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(11, 264);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(246, 30);
            this.label31.TabIndex = 24;
            this.label31.Text = "VU";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(389, 202);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 30);
            this.label28.TabIndex = 40;
            this.label28.Text = "X";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxU
            // 
            this.textBoxU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxU.Location = new System.Drawing.Point(263, 235);
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.Size = new System.Drawing.Size(120, 26);
            this.textBoxU.TabIndex = 39;
            this.textBoxU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(263, 202);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 30);
            this.label21.TabIndex = 38;
            this.label21.Text = "U";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxT
            // 
            this.textBoxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxT.Location = new System.Drawing.Point(137, 235);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(120, 26);
            this.textBoxT.TabIndex = 37;
            this.textBoxT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(137, 202);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 30);
            this.label22.TabIndex = 36;
            this.label22.Text = "T";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxS
            // 
            this.textBoxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxS.Location = new System.Drawing.Point(11, 235);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(120, 26);
            this.textBoxS.TabIndex = 35;
            this.textBoxS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(11, 202);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 30);
            this.label23.TabIndex = 34;
            this.label23.Text = "S";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxR.Location = new System.Drawing.Point(641, 173);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(120, 26);
            this.textBoxR.TabIndex = 33;
            this.textBoxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(641, 140);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 30);
            this.label24.TabIndex = 32;
            this.label24.Text = "R";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQ.Location = new System.Drawing.Point(515, 173);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(120, 26);
            this.textBoxQ.TabIndex = 31;
            this.textBoxQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(515, 140);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 30);
            this.label25.TabIndex = 30;
            this.label25.Text = "Q";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxP
            // 
            this.textBoxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxP.Location = new System.Drawing.Point(263, 173);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(246, 26);
            this.textBoxP.TabIndex = 29;
            this.textBoxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(263, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(246, 30);
            this.label16.TabIndex = 28;
            this.label16.Text = "P";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxO
            // 
            this.textBoxO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxO.Location = new System.Drawing.Point(137, 173);
            this.textBoxO.Name = "textBoxO";
            this.textBoxO.Size = new System.Drawing.Size(120, 26);
            this.textBoxO.TabIndex = 27;
            this.textBoxO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(137, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 30);
            this.label17.TabIndex = 26;
            this.label17.Text = "O";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxN.Location = new System.Drawing.Point(11, 173);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(120, 26);
            this.textBoxN.TabIndex = 25;
            this.textBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 140);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 30);
            this.label18.TabIndex = 24;
            this.label18.Text = "N";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxM
            // 
            this.textBoxM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxM.Location = new System.Drawing.Point(641, 111);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(120, 26);
            this.textBoxM.TabIndex = 23;
            this.textBoxM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(641, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 30);
            this.label19.TabIndex = 22;
            this.label19.Text = "M";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxL
            // 
            this.textBoxL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxL.Location = new System.Drawing.Point(515, 111);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(120, 26);
            this.textBoxL.TabIndex = 21;
            this.textBoxL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(515, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 30);
            this.label20.TabIndex = 20;
            this.label20.Text = "L";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxK
            // 
            this.textBoxK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxK.Location = new System.Drawing.Point(389, 111);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(120, 26);
            this.textBoxK.TabIndex = 19;
            this.textBoxK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(389, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 30);
            this.label11.TabIndex = 18;
            this.label11.Text = "K";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxJ
            // 
            this.textBoxJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJ.Location = new System.Drawing.Point(263, 111);
            this.textBoxJ.Name = "textBoxJ";
            this.textBoxJ.Size = new System.Drawing.Size(120, 26);
            this.textBoxJ.TabIndex = 17;
            this.textBoxJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(263, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 30);
            this.label12.TabIndex = 16;
            this.label12.Text = "J";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxH
            // 
            this.textBoxH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxH.Location = new System.Drawing.Point(137, 111);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(120, 26);
            this.textBoxH.TabIndex = 15;
            this.textBoxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(137, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 30);
            this.label13.TabIndex = 14;
            this.label13.Text = "H";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxG
            // 
            this.textBoxG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxG.Location = new System.Drawing.Point(11, 111);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(120, 26);
            this.textBoxG.TabIndex = 13;
            this.textBoxG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 30);
            this.label14.TabIndex = 12;
            this.label14.Text = "G";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxF
            // 
            this.textBoxF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxF.Location = new System.Drawing.Point(641, 49);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(120, 26);
            this.textBoxF.TabIndex = 11;
            this.textBoxF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(641, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 30);
            this.label15.TabIndex = 10;
            this.label15.Text = "F";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxE
            // 
            this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxE.Location = new System.Drawing.Point(515, 49);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(120, 26);
            this.textBoxE.TabIndex = 9;
            this.textBoxE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(515, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 30);
            this.label10.TabIndex = 8;
            this.label10.Text = "E";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxD
            // 
            this.textBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxD.Location = new System.Drawing.Point(389, 49);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(120, 26);
            this.textBoxD.TabIndex = 7;
            this.textBoxD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(389, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 30);
            this.label9.TabIndex = 6;
            this.label9.Text = "D";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxC
            // 
            this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC.Location = new System.Drawing.Point(263, 49);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(120, 26);
            this.textBoxC.TabIndex = 5;
            this.textBoxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 30);
            this.label8.TabIndex = 4;
            this.label8.Text = "C";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxB.Location = new System.Drawing.Point(137, 49);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(120, 26);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "B";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA.Location = new System.Drawing.Point(11, 49);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(120, 26);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "A";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxScannerData);
            this.groupBox3.Controls.Add(this.textBoxFail);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.textBoxPass);
            this.groupBox3.Controls.Add(this.textBoxTotalQty);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.textBoxScannerHeadAssy);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Location = new System.Drawing.Point(401, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 211);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Production Data";
            // 
            // textBoxScannerData
            // 
            this.textBoxScannerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScannerData.Location = new System.Drawing.Point(11, 29);
            this.textBoxScannerData.Name = "textBoxScannerData";
            this.textBoxScannerData.Size = new System.Drawing.Size(361, 26);
            this.textBoxScannerData.TabIndex = 18;
            this.textBoxScannerData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFail
            // 
            this.textBoxFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFail.ForeColor = System.Drawing.Color.White;
            this.textBoxFail.Location = new System.Drawing.Point(123, 173);
            this.textBoxFail.Name = "textBoxFail";
            this.textBoxFail.Size = new System.Drawing.Size(249, 26);
            this.textBoxFail.TabIndex = 11;
            this.textBoxFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(6, 172);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(43, 25);
            this.label36.TabIndex = 10;
            this.label36.Text = "Fail";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.White;
            this.textBoxPass.Location = new System.Drawing.Point(123, 137);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(249, 26);
            this.textBoxPass.TabIndex = 17;
            this.textBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTotalQty
            // 
            this.textBoxTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalQty.Location = new System.Drawing.Point(123, 101);
            this.textBoxTotalQty.Name = "textBoxTotalQty";
            this.textBoxTotalQty.Size = new System.Drawing.Size(249, 26);
            this.textBoxTotalQty.TabIndex = 16;
            this.textBoxTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(6, 64);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(108, 25);
            this.label35.TabIndex = 10;
            this.label35.Text = "Head Assy";
            // 
            // textBoxScannerHeadAssy
            // 
            this.textBoxScannerHeadAssy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScannerHeadAssy.Location = new System.Drawing.Point(123, 65);
            this.textBoxScannerHeadAssy.Name = "textBoxScannerHeadAssy";
            this.textBoxScannerHeadAssy.Size = new System.Drawing.Size(249, 26);
            this.textBoxScannerHeadAssy.TabIndex = 15;
            this.textBoxScannerHeadAssy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(6, 100);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(92, 25);
            this.label33.TabIndex = 12;
            this.label33.Text = "Total Qty";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(6, 136);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 25);
            this.label32.TabIndex = 13;
            this.label32.Text = "Pass";
            // 
            // serialPortScanner
            // 
            this.serialPortScanner.BaudRate = 115200;
            // 
            // buttonAutoOrder
            // 
            this.buttonAutoOrder.AutoSize = true;
            this.buttonAutoOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutoOrder.Location = new System.Drawing.Point(23, 686);
            this.buttonAutoOrder.Name = "buttonAutoOrder";
            this.buttonAutoOrder.Size = new System.Drawing.Size(246, 35);
            this.buttonAutoOrder.TabIndex = 21;
            this.buttonAutoOrder.Text = "Auto Order Launch";
            this.buttonAutoOrder.UseVisualStyleBackColor = true;
            this.buttonAutoOrder.Click += new System.EventHandler(this.buttonAutoOrder_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(653, 686);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 35);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(527, 686);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 35);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // timerReadRFID
            // 
            this.timerReadRFID.Tick += new System.EventHandler(this.timerReadRFID_Tick);
            // 
            // serialPortRFID
            // 
            this.serialPortRFID.BaudRate = 19200;
            this.serialPortRFID.Parity = System.IO.Ports.Parity.Even;
            this.serialPortRFID.PortName = "COM2";
            // 
            // buttonReferenceData
            // 
            this.buttonReferenceData.AutoSize = true;
            this.buttonReferenceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReferenceData.Location = new System.Drawing.Point(275, 686);
            this.buttonReferenceData.Name = "buttonReferenceData";
            this.buttonReferenceData.Size = new System.Drawing.Size(246, 35);
            this.buttonReferenceData.TabIndex = 22;
            this.buttonReferenceData.Text = "Reference Data";
            this.buttonReferenceData.UseVisualStyleBackColor = true;
            this.buttonReferenceData.Click += new System.EventHandler(this.buttonReferenceData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KIWI_2.Properties.Resources.Schneider_Electric_Small;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 47);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(179, 12);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(613, 40);
            this.label34.TabIndex = 24;
            this.label34.Text = "KIWI 2 - Auto Labeling And Pasting";
            // 
            // timerClearScannerData
            // 
            this.timerClearScannerData.Interval = 6000;
            this.timerClearScannerData.Tick += new System.EventHandler(this.timerClearScannerData_Tick);
            // 
            // timerReadModbus
            // 
            this.timerReadModbus.Interval = 1000;
            this.timerReadModbus.Tick += new System.EventHandler(this.timerReadModbus_Tick);
            // 
            // FormAutomatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 730);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReferenceData);
            this.Controls.Add(this.buttonAutoOrder);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormAutomatic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KIWI 2 - Automatic Mode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAutomatic_FormClosing);
            this.Load += new System.EventHandler(this.FormAutomatic_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHeadAssyLabel;
        private System.Windows.Forms.TextBox textBoxHeadAssy;
        private System.Windows.Forms.TextBox textBoxCoil;
        private System.Windows.Forms.TextBox textBoxReference;
        private System.Windows.Forms.TextBox textBoxSoNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxJ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxU;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxAA2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxAA1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxVU;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDataMatrix;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBoxFail;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxTotalQty;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBoxScannerHeadAssy;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.IO.Ports.SerialPort serialPortScanner;
        private System.Windows.Forms.Button buttonAutoOrder;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Timer timerReadRFID;
        private System.IO.Ports.SerialPort serialPortRFID;
        private System.Windows.Forms.TextBox textBoxScannerData;
        private System.Windows.Forms.Button buttonReferenceData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Timer timerClearScannerData;
        private System.Windows.Forms.Timer timerReadModbus;
    }
}