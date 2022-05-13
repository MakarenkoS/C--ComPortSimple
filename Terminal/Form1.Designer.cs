namespace Terminal
{
    partial class FormCom
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMConstrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenComMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseComMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCBDataFormat = new System.Windows.Forms.ToolStripComboBox();
            this.addCRC16 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataOut = new System.Windows.Forms.ToolStripMenuItem();
            this.receiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CbDataRxFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCBRxDataFormat = new System.Windows.Forms.ToolStripComboBox();
            this.clearData = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.pbComStatus = new System.Windows.Forms.ProgressBar();
            this.lbComPortStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDTR = new System.Windows.Forms.CheckBox();
            this.cbRTS = new System.Windows.Forms.CheckBox();
            this.cbParityBits = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.lbSendData = new System.Windows.Forms.Label();
            this.tbDataOut = new System.Windows.Forms.TextBox();
            this.cbEcho = new System.Windows.Forms.CheckBox();
            this.lbDataOutLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDataIn = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cOMConstrolToolStripMenuItem,
            this.transmitterToolStripMenuItem,
            this.receiverToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1088, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cOMConstrolToolStripMenuItem
            // 
            this.cOMConstrolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenComMenuItem,
            this.CloseComMenuItem});
            this.cOMConstrolToolStripMenuItem.Name = "cOMConstrolToolStripMenuItem";
            this.cOMConstrolToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.cOMConstrolToolStripMenuItem.Text = "COM Constrol";
            // 
            // OpenComMenuItem
            // 
            this.OpenComMenuItem.Name = "OpenComMenuItem";
            this.OpenComMenuItem.Size = new System.Drawing.Size(126, 26);
            this.OpenComMenuItem.Text = "OPEN";
            this.OpenComMenuItem.Click += new System.EventHandler(this.OpenComMenuItem_Click);
            // 
            // CloseComMenuItem
            // 
            this.CloseComMenuItem.Name = "CloseComMenuItem";
            this.CloseComMenuItem.Size = new System.Drawing.Size(126, 26);
            this.CloseComMenuItem.Text = "CLOSE";
            this.CloseComMenuItem.Click += new System.EventHandler(this.CloseComMenuItem_Click);
            // 
            // transmitterToolStripMenuItem
            // 
            this.transmitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataFormatToolStripMenuItem,
            this.addCRC16,
            this.clearDataOut});
            this.transmitterToolStripMenuItem.Name = "transmitterToolStripMenuItem";
            this.transmitterToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.transmitterToolStripMenuItem.Text = "Transmitter";
            // 
            // dataFormatToolStripMenuItem
            // 
            this.dataFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCBDataFormat});
            this.dataFormatToolStripMenuItem.Name = "dataFormatToolStripMenuItem";
            this.dataFormatToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.dataFormatToolStripMenuItem.Text = "Data Format";
            // 
            // toolStripCBDataFormat
            // 
            this.toolStripCBDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripCBDataFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripCBDataFormat.Items.AddRange(new object[] {
            "HEX",
            "DEC",
            "BINARY",
            "CHAR"});
            this.toolStripCBDataFormat.Name = "toolStripCBDataFormat";
            this.toolStripCBDataFormat.Size = new System.Drawing.Size(121, 28);
            // 
            // addCRC16
            // 
            this.addCRC16.CheckOnClick = true;
            this.addCRC16.Name = "addCRC16";
            this.addCRC16.Size = new System.Drawing.Size(181, 26);
            this.addCRC16.Text = "Add CRC 16";
            // 
            // clearDataOut
            // 
            this.clearDataOut.CheckOnClick = true;
            this.clearDataOut.Name = "clearDataOut";
            this.clearDataOut.Size = new System.Drawing.Size(181, 26);
            this.clearDataOut.Text = "Clear Data";
            this.clearDataOut.Click += new System.EventHandler(this.clearDataOut_Click);
            // 
            // receiverToolStripMenuItem
            // 
            this.receiverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CbDataRxFormat,
            this.clearData});
            this.receiverToolStripMenuItem.Name = "receiverToolStripMenuItem";
            this.receiverToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.receiverToolStripMenuItem.Text = "Receiver";
            // 
            // CbDataRxFormat
            // 
            this.CbDataRxFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCBRxDataFormat});
            this.CbDataRxFormat.Name = "CbDataRxFormat";
            this.CbDataRxFormat.Size = new System.Drawing.Size(181, 26);
            this.CbDataRxFormat.Text = "Data Format";
            // 
            // toolStripCBRxDataFormat
            // 
            this.toolStripCBRxDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripCBRxDataFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripCBRxDataFormat.Items.AddRange(new object[] {
            "HEX",
            "DEC",
            "BINARY",
            "CHAR"});
            this.toolStripCBRxDataFormat.Name = "toolStripCBRxDataFormat";
            this.toolStripCBRxDataFormat.Size = new System.Drawing.Size(121, 28);
            // 
            // clearData
            // 
            this.clearData.Name = "clearData";
            this.clearData.Size = new System.Drawing.Size(181, 26);
            this.clearData.Text = "Clear Data";
            // 
            // panelSettings
            // 
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.pbComStatus);
            this.panelSettings.Controls.Add(this.lbComPortStatus);
            this.panelSettings.Controls.Add(this.label7);
            this.panelSettings.Controls.Add(this.cbDTR);
            this.panelSettings.Controls.Add(this.cbRTS);
            this.panelSettings.Controls.Add(this.cbParityBits);
            this.panelSettings.Controls.Add(this.cbStopBits);
            this.panelSettings.Controls.Add(this.label6);
            this.panelSettings.Controls.Add(this.label5);
            this.panelSettings.Controls.Add(this.cbDataBits);
            this.panelSettings.Controls.Add(this.label4);
            this.panelSettings.Controls.Add(this.cbBaudRate);
            this.panelSettings.Controls.Add(this.label3);
            this.panelSettings.Controls.Add(this.cbPort);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Location = new System.Drawing.Point(12, 40);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Padding = new System.Windows.Forms.Padding(5);
            this.panelSettings.Size = new System.Drawing.Size(279, 474);
            this.panelSettings.TabIndex = 1;
            // 
            // pbComStatus
            // 
            this.pbComStatus.Location = new System.Drawing.Point(18, 412);
            this.pbComStatus.Name = "pbComStatus";
            this.pbComStatus.Size = new System.Drawing.Size(243, 23);
            this.pbComStatus.TabIndex = 14;
            // 
            // lbComPortStatus
            // 
            this.lbComPortStatus.AutoSize = true;
            this.lbComPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComPortStatus.Location = new System.Drawing.Point(190, 373);
            this.lbComPortStatus.Name = "lbComPortStatus";
            this.lbComPortStatus.Size = new System.Drawing.Size(49, 24);
            this.lbComPortStatus.TabIndex = 13;
            this.lbComPortStatus.Text = "OFF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "COM Port status:";
            // 
            // cbDTR
            // 
            this.cbDTR.AutoSize = true;
            this.cbDTR.Location = new System.Drawing.Point(154, 226);
            this.cbDTR.Name = "cbDTR";
            this.cbDTR.Size = new System.Drawing.Size(107, 21);
            this.cbDTR.TabIndex = 12;
            this.cbDTR.Text = "DTR Enable";
            this.cbDTR.UseVisualStyleBackColor = true;
            // 
            // cbRTS
            // 
            this.cbRTS.AutoSize = true;
            this.cbRTS.Location = new System.Drawing.Point(17, 226);
            this.cbRTS.Name = "cbRTS";
            this.cbRTS.Size = new System.Drawing.Size(107, 21);
            this.cbRTS.TabIndex = 11;
            this.cbRTS.Text = "DTR Enable";
            this.cbRTS.UseVisualStyleBackColor = true;
            // 
            // cbParityBits
            // 
            this.cbParityBits.FormattingEnabled = true;
            this.cbParityBits.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cbParityBits.Location = new System.Drawing.Point(117, 183);
            this.cbParityBits.Name = "cbParityBits";
            this.cbParityBits.Size = new System.Drawing.Size(143, 24);
            this.cbParityBits.TabIndex = 10;
            this.cbParityBits.Text = "None";
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbStopBits.Location = new System.Drawing.Point(118, 150);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(143, 24);
            this.cbStopBits.TabIndex = 9;
            this.cbStopBits.Text = "One";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "PARITY BITS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "STOP BITS";
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(118, 117);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(143, 24);
            this.cbDataBits.TabIndex = 6;
            this.cbDataBits.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "DATA BITS";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(118, 83);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(143, 24);
            this.cbBaudRate.TabIndex = 4;
            this.cbBaudRate.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "BAUD RATE";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(118, 50);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(143, 24);
            this.cbPort.TabIndex = 2;
            this.cbPort.DropDown += new System.EventHandler(this.cbPort_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "COM PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port Settings:";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.lbSendData);
            this.panelData.Controls.Add(this.tbDataOut);
            this.panelData.Controls.Add(this.cbEcho);
            this.panelData.Controls.Add(this.lbDataOutLength);
            this.panelData.Controls.Add(this.label8);
            this.panelData.Controls.Add(this.tbDataIn);
            this.panelData.Controls.Add(this.btnSend);
            this.panelData.Controls.Add(this.textBoxSend);
            this.panelData.Location = new System.Drawing.Point(309, 31);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(767, 483);
            this.panelData.TabIndex = 2;
            // 
            // lbSendData
            // 
            this.lbSendData.AutoSize = true;
            this.lbSendData.Location = new System.Drawing.Point(24, 246);
            this.lbSendData.Name = "lbSendData";
            this.lbSendData.Size = new System.Drawing.Size(73, 17);
            this.lbSendData.TabIndex = 4;
            this.lbSendData.Text = "Send data";
            this.lbSendData.Visible = false;
            // 
            // tbDataOut
            // 
            this.tbDataOut.Location = new System.Drawing.Point(19, 266);
            this.tbDataOut.Multiline = true;
            this.tbDataOut.Name = "tbDataOut";
            this.tbDataOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDataOut.Size = new System.Drawing.Size(735, 133);
            this.tbDataOut.TabIndex = 3;
            this.tbDataOut.Visible = false;
            // 
            // cbEcho
            // 
            this.cbEcho.AutoSize = true;
            this.cbEcho.Location = new System.Drawing.Point(685, 461);
            this.cbEcho.Name = "cbEcho";
            this.cbEcho.Size = new System.Drawing.Size(69, 21);
            this.cbEcho.TabIndex = 5;
            this.cbEcho.Text = "ECHO";
            this.cbEcho.UseVisualStyleBackColor = true;
            this.cbEcho.CheckedChanged += new System.EventHandler(this.cbEcho_CheckedChanged);
            // 
            // lbDataOutLength
            // 
            this.lbDataOutLength.AutoSize = true;
            this.lbDataOutLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDataOutLength.Location = new System.Drawing.Point(200, 456);
            this.lbDataOutLength.Name = "lbDataOutLength";
            this.lbDataOutLength.Size = new System.Drawing.Size(34, 25);
            this.lbDataOutLength.TabIndex = 4;
            this.lbDataOutLength.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(19, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Data OUT Length:";
            // 
            // tbDataIn
            // 
            this.tbDataIn.Location = new System.Drawing.Point(19, 20);
            this.tbDataIn.Multiline = true;
            this.tbDataIn.Name = "tbDataIn";
            this.tbDataIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDataIn.Size = new System.Drawing.Size(735, 379);
            this.tbDataIn.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(633, 419);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 36);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSend.Location = new System.Drawing.Point(22, 420);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(605, 30);
            this.textBoxSend.TabIndex = 0;
            this.textBoxSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSend_KeyPress);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Received data";
            // 
            // FormCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 526);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximumSize = new System.Drawing.Size(1106, 573);
            this.MinimumSize = new System.Drawing.Size(1106, 573);
            this.Name = "FormCom";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termianl 1.0";
            this.Load += new System.EventHandler(this.FormCom_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbParityBits;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.Label lbComPortStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbDTR;
        private System.Windows.Forms.CheckBox cbRTS;
        private System.Windows.Forms.ProgressBar pbComStatus;
        private System.Windows.Forms.ToolStripMenuItem cOMConstrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenComMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseComMenuItem;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox tbDataIn;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.ToolStripMenuItem transmitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripCBDataFormat;
        private System.Windows.Forms.ToolStripMenuItem addCRC16;
        private System.Windows.Forms.Label lbDataOutLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbEcho;
        private System.Windows.Forms.TextBox tbDataOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSendData;
        private System.Windows.Forms.ToolStripMenuItem clearDataOut;
        private System.Windows.Forms.ToolStripMenuItem receiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CbDataRxFormat;
        private System.Windows.Forms.ToolStripComboBox toolStripCBRxDataFormat;
        private System.Windows.Forms.ToolStripMenuItem clearData;
    }
}

