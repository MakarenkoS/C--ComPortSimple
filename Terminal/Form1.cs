using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace Terminal
{


    public partial class FormCom : Form
    {
        int dataInLength;
        int[] dataInDec;
        string dataIn;

        #region Tx data
        protected void SendDataString(string data)
        {
            serialPort.Write(data);
            if (cbEcho.Checked)
            {
                tbDataOut.Text += data;
            }
            int dataOUTLength = data.Length;
            lbDataOutLength.Text = string.Format("{0:00}", dataOUTLength);
        }

        protected void SendDataString(byte[] data)
        {
            serialPort.Write(data, 0, data.Length);
            if (cbEcho.Checked)
            {
                if (toolStripCBDataFormat.Text == "HEX")
                {
                    foreach (var item in data)
                    {
                        tbDataOut.Text += Convert.ToString(item, 16).ToUpper() + " ";
                    }
                }
                else if (toolStripCBDataFormat.Text == "DEC")
                {
                    foreach (var item in data)
                    {
                        tbDataOut.Text += Convert.ToString(item, 10) + " ";
                    }
                }
                else if (toolStripCBDataFormat.Text == "BINARY")
                {
                    foreach (var item in data)
                    {
                        tbDataOut.Text += Convert.ToString(item, 2) + " | ";
                    }
                }

            }
            int dataOUTLength = data.Length;
            lbDataOutLength.Text = string.Format("{0:00}", dataOUTLength);
        }
        public static byte[] ModbusCRC16Calc(byte[] Message)
        {
            //выдаваемый массив CRC
            byte[] CRC = new byte[2];
            ushort Register = 0xFFFF; // создаем регистр, в котором будем сохранять высчитанный CRC
            ushort Polynom = 0xA001; //Указываем полином, он может быть как 0xA001(старший бит справа), так и его реверс 0x8005(старший бит слева, здесь не рассматривается), при сдвиге вправо используется 0xA001

            for (int i = 0; i < Message.Length; i++) // для каждого байта в принятом\отправляемом сообщении проводим следующие операции(байты сообщения без принятого CRC)
            {
                Register = (ushort)(Register ^ Message[i]); // Делим через XOR регистр на выбранный байт сообщения(от младшего к старшему)

                for (int j = 0; j < 8; j++) // для каждого бита в выбранном байте делим полученный регистр на полином
                {
                    if ((ushort)(Register & 0x01) == 1) //если старший бит равен 1 то
                    {
                        Register = (ushort)(Register >> 1); //сдвигаем на один бит вправо
                        Register = (ushort)(Register ^ Polynom); //делим регистр на полином по XOR
                    }
                    else //если старший бит равен 0 то
                    {
                        Register = (ushort)(Register >> 1); // сдвигаем регистр вправо
                    }
                }
            }

            CRC[1] = (byte)(Register >> 8); // присваиваем старший байт полученного регистра младшему байту результата CRC (CRClow)
            CRC[0] = (byte)(Register & 0x00FF); // присваиваем младший байт полученного регистра старшему байту результата CRC (CRCHi) это условность Modbus — обмен байтов местами.

            return CRC;
        }
        private byte[] MakeDataString(string[] prepareDataString, int NumberType)
        {
            byte[] tmpArr;
            tmpArr = new byte[prepareDataString.Length];

            for (int a = 0; a < prepareDataString.Length; a++)
            {
                tmpArr[a] = Convert.ToByte(prepareDataString[a], NumberType);
            }
            return tmpArr;
        }
        private void TxDataFormat(string sendString)
        {
            if (toolStripCBDataFormat.Text == "CHAR")
            {
                //Send the data in textbox via serial port
                SendDataString(sendString);

                //Calculate the length of the data sent and then show it

            }
            else
            {
                //Declare Local Variables
                string dataOutBuffer;
                int countSpaces = 0;
                string[] dataPrepareToSend;
                byte[] dataToSend;
                byte[] crc16;

                try
                {
                    //Move the data package in the textbox into a variable
                    dataOutBuffer = sendString + ' ';

                    //Count how much spaces in the data package
                    foreach (char c in dataOutBuffer) { if (c == ' ') { countSpaces++; } }

                    //Create one-dimensional array (string data type) with the length based on the countSpaces
                    dataPrepareToSend = new string[countSpaces];

                    //Parsing the data in dataOutBuffer and save it into an array dataPrepareSend based on
                    // space punctuation
                    countSpaces = 0;

                    foreach (char c in dataOutBuffer)
                    {
                        if (c != ' ')
                        {
                            dataPrepareToSend[countSpaces] += c;
                        }
                        else
                        {
                            countSpaces++;
                            if (countSpaces == dataPrepareToSend.GetLength(0)) { break; }
                        }
                    }


                    dataToSend = new byte[dataPrepareToSend.Length];

                    if (toolStripCBDataFormat.Text == "HEX")
                    {
                        dataToSend = MakeDataString(dataPrepareToSend, 16);
                    }
                    else if (toolStripCBDataFormat.Text == "BINARY")
                    {
                        dataToSend = MakeDataString(dataPrepareToSend, 2);
                    }
                    else if (toolStripCBDataFormat.Text == "DEC")
                    {
                        dataToSend = MakeDataString(dataPrepareToSend, 10);
                    }

                    if (addCRC16.Checked)
                    {
                        crc16 = new byte[2];
                        crc16 = ModbusCRC16Calc(dataToSend);
                        Array.Resize(ref dataToSend, dataToSend.Length + crc16.Length);

                        for (int i = 0; i < crc16.Length; i++)
                        {
                            dataToSend[dataToSend.Length - 2 + i] = crc16[i];
                        }

                        SendDataString(dataToSend);
                    }
                    else
                    {
                        SendDataString(dataToSend);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
        }
        private void TxSendData(string sendString)
        {
            if (serialPort.IsOpen)
            {
                if (clearDataOut.Checked)
                {
                    tbDataOut.Clear();

                }
                TxDataFormat(sendString);

            }
        }

#endregion


        #region Rx data
        private string RxDataFormat(int[] dataInput)
        {
            string strOut = "";

            if (toolStripCBRxDataFormat.Text == "HEX")
            {
                foreach (int item in dataInput)
                {
                    strOut += Convert.ToString(item, 16).ToUpper() + " ";
                }
            }
            else if (toolStripCBRxDataFormat.Text == "DEC")
            {
                foreach (int item in dataInput)
                {
                    strOut += Convert.ToString(item, 10) + " ";
                }
            }
            else if (toolStripCBRxDataFormat.Text == "BINARY")
            {
                foreach (int item in dataInput)
                {
                    strOut += Convert.ToString(item, 2) + " ";
                }
            }
            else if (toolStripCBRxDataFormat.Text == "CHAR")
            {
                foreach (int item in dataInput)
                {
                    strOut += Convert.ToChar(item);
                }
            }

            return strOut;
        }

        #endregion

        public FormCom()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormCom_Load(object sender, EventArgs e)
        {
            toolStripCBDataFormat.Text = "CHAR";
            toolStripCBRxDataFormat.Text = "CHAR";
        }

        private void cbPort_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbPort.Items.Clear();
            cbPort.Items.AddRange(ports);
        }

        private void OpenComMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = cbPort.Text;
                serialPort.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort.DataBits = Convert.ToInt32(cbDataBits.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbParityBits.Text);

                serialPort.DtrEnable = cbDTR.Checked;
                serialPort.RtsEnable = cbRTS.Checked;

                serialPort.Open();
                pbComStatus.Value = 100;
                lbComPortStatus.Text = "ON";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseComMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                    pbComStatus.Value = 0;
                    lbComPortStatus.Text = "OFF";

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            TxSendData(textBoxSend.Text);
        }

        private void textBoxSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (toolStripCBDataFormat.Text == "HEX")
            {
                char uppercaseChar = char.ToUpper(c);
                if (!char.IsDigit(uppercaseChar) && uppercaseChar != 8 && uppercaseChar != 46 && uppercaseChar != ' ' &&
                    !(uppercaseChar >= 65 && uppercaseChar <= 70))
                {
                    // Cancel the KeyPress Event
                    e.Handled = true;
                }
            }
            else if (toolStripCBDataFormat.Text == "DEC")
            {

                if (!char.IsDigit(c) && c != 8 && c != 46 && c != ' ')
                {
                    // Cancel the KeyPress Event
                    e.Handled = true;
                }
            }
            else if (toolStripCBDataFormat.Text == "BINARY")
            {
                if (c != 49 && c != 48 && c != 8 && c != 46 && c != ' ')
                {
                    e.Handled = true;
                }
            }
            else if (toolStripCBDataFormat.Text == "CHAR")
            {

            }
        }

        private void cbEcho_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEcho.Checked) {
               tbDataOut.Visible = true;
               tbDataIn.Height = 180;
               lbSendData.Visible = true;
              
            } else {
                tbDataOut.Visible = false;
                lbSendData.Visible = false;
                tbDataIn.Height = 309;
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            List<int> dataBuffer = new List<int>();

            while (serialPort.BytesToRead > 0)
            {
                try
                {
                    dataBuffer.Add(serialPort.ReadByte());
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                
            }

            dataInLength = dataBuffer.Count();
            dataInDec = new int[dataInLength];
            dataInDec = dataBuffer.ToArray();

            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            dataIn = RxDataFormat(dataInDec);
            tbDataIn.Text += dataIn;
        }

        private void clearData_Click(object sender, EventArgs e)
        {
            tbDataIn.Clear();
        }

        private void clearDataOut_Click(object sender, EventArgs e)
        {
            tbDataOut.Clear();
            textBoxSend.Clear();
        }
    }
}
