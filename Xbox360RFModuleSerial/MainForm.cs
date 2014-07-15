using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xbox360RFModuleSerial
{
    public partial class MainForm : Form
    {
        private SerialPort _port;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portCombo.Items.AddRange(SerialPort.GetPortNames());
            if (portCombo.Items.Count > 0)
                portCombo.SelectedIndex = 0;

            powerCombo.SelectedIndex = 0;
            orientationCombo.SelectedIndex = 0;

            greenLed1Combo.SelectedIndex = 1;
            greenLed2Combo.SelectedIndex = 1;
            greenLed3Combo.SelectedIndex = 1;
            greenLed4Combo.SelectedIndex = 1;

            redLed1Combo.SelectedIndex = 1;
            redLed2Combo.SelectedIndex = 1;
            redLed3Combo.SelectedIndex = 1;
            redLed4Combo.SelectedIndex = 1;
        }

        private void openPort(object sender, EventArgs e)
        {
            if (portCombo.SelectedIndex == -1)
                MessageBox.Show("Select a COM port first!");
            else
            {
                if (_port != null && _port.IsOpen)
                {
                    _port.Close();
                    _port.Dispose();
                }

                try
                {
                    _port = new SerialPort((string)portCombo.Items[portCombo.SelectedIndex]);
                    _port.BaudRate = 11500;
                    _port.Open();

                    openButton.Enabled = false;
                    closeButton.Enabled = true;
                    commandBox.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An exception ocurred while opening port:\n" + ex.Message);
                }
            }
        }

        private void closePort(object sender, EventArgs e)
        {
            if (_port != null && _port.IsOpen)
            {
                _port.Close();
                _port.Dispose();

                openButton.Enabled = true;
                closeButton.Enabled = false;
                commandBox.Enabled = false;
            }
        }

        private void WriteData(bool value)
        {
            if (invertDataCb.Checked)
                _port.RtsEnable = !value;
            else
                _port.RtsEnable = value;
        }

        private bool ReadClock()
        {
            if (clockInvertCb.Checked)
                return !_port.CtsHolding;

            return _port.CtsHolding;
        }

        private void SendCommand(bool[] cmd)
        {
            WriteData(false); //Start sending data

            DateTime sendStart = DateTime.Now;

            bool prev = true;
            for (int x = 0; x < 10; x++)
            {
                while (prev == ReadClock()) 
                {
                    if (DateTime.Now.Subtract(sendStart).TotalSeconds > 2)
                    {
                        MessageBox.Show("The operation has timed out!\nNot receiving clock signal!");
                        return;
                    }
                } //Detects change in clock
                sendStart = DateTime.Now;
                prev = ReadClock();

                WriteData(cmd[x]);

                while (prev == ReadClock())
                {
                    if (DateTime.Now.Subtract(sendStart).TotalSeconds > 2)
                    {
                        MessageBox.Show("The operation has timed out!\nNot receiving clock signal!");
                        return;
                    }
                } //Detects change in clock
                sendStart = DateTime.Now;
                prev = ReadClock();
            }

            WriteData(true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closePort(null, null);
        }

        private void syncButton_Click(object sender, EventArgs e) //00 0000 0100
        {
            SendCommand(new bool[] { false, false, false, false, false, false, false, true, false, false, });
        }

        private void controllerOff_Click(object sender, EventArgs e) //00 0000 1001
        {
            SendCommand(new bool[] { false, false, false, false, false, false, true, false, false, true, });
        }

        private void configButton_Click(object sender, EventArgs e) //00 0000 01RP (R bit is RF on/off, P bit is 0 for standing orientation)
        {
            bool r = (powerCombo.SelectedIndex == 0);
            bool p = (orientationCombo.SelectedIndex == 0);

            SendCommand(new bool[] { false, false, false, false, false, false, false, true, r, p, }); //It seems it's not doing anything :/
        }

        private void ledOffButton_Click(object sender, EventArgs e) //00 1000 0000
        {
            SendCommand(new bool[] { false, false, true, false, false, false, false, false, false, false, });
        }

        private void powerLed_Click(object sender, EventArgs e) //00 1000 0100
        {
            SendCommand(new bool[] { false, false, true, false, false, false, false, true, false, false, });
        }

        private void bootAnimButton_Click(object sender, EventArgs e) //00 1000 0101
        {
            SendCommand(new bool[] { false, false, true, false, false, false, false, true, false, true, });
        }

        private void ledInitNoPwr_Click(object sender, EventArgs e) //00 1000 1000
        {
            SendCommand(new bool[] { false, false, true, false, false, false, true, false, false, false, });
        }

        private void bootAnimNoPwrButton_Click(object sender, EventArgs e) //00 1000 1001
        {
            SendCommand(new bool[] { false, false, true, false, false, false, true, false, false, true, });
        }

        private void ledInitBlinkPWRButton_Click(object sender, EventArgs e) //00 1000 1100
        {
            SendCommand(new bool[] { false, false, true, false, false, false, true, true, false, false, });
        }

        private void bootAnimBlinkPWRButton_Click(object sender, EventArgs e) //00 1000 1101
        {
            SendCommand(new bool[] { false, false, true, false, false, false, true, true, false, true, });
        }

        private void sendGreenLedsButton_Click(object sender, EventArgs e) //00 1010 ABCD
        {
            bool a = (greenLed1Combo.SelectedIndex == 0);
            bool b = (greenLed2Combo.SelectedIndex == 0);
            bool c = (greenLed3Combo.SelectedIndex == 0);
            bool d = (greenLed4Combo.SelectedIndex == 0);

            SendCommand(new bool[] { false, false, true, false, true, false, a, b, c, d });
        }

        private void sendRedLedsButton_Click(object sender, EventArgs e) //00 1011 ABCD
        {
            bool a = (redLed1Combo.SelectedIndex == 0);
            bool b = (redLed2Combo.SelectedIndex == 0);
            bool c = (redLed3Combo.SelectedIndex == 0);
            bool d = (redLed4Combo.SelectedIndex == 0);

            SendCommand(new bool[] { false, false, true, false, true, true, a, b, c, d });
        }

        private void clearErrorButton_Click(object sender, EventArgs e) //00 1100 0000
        {
            SendCommand(new bool[] { false, false, true, true, false, false, false, false, false, false, });
        }

        private void redBlink1Button_Click(object sender, EventArgs e) //00 1100 0010
        {
            SendCommand(new bool[] { false, false, true, true, false, false, false, false, true, false, });
        }

        private void redBlink2Button_Click(object sender, EventArgs e) //00 1100 0011
        {
            SendCommand(new bool[] { false, false, true, true, false, false, false, false, true, true, });
        }

        private void redBlink3Button_Click(object sender, EventArgs e) //00 1100 0100
        {
            SendCommand(new bool[] { false, false, true, true, false, false, false, true, false, false, });
        }

        private void redBlink4Button_Click(object sender, EventArgs e) //00 1100 0101
        {
            SendCommand(new bool[] { false, false, true, true, false, false, false, true, false, true, });
        }

        private void redBlinkAllButton_Click(object sender, EventArgs e) //00 1100 0001
        {
            SendCommand(new bool[] { false, false, true, true, false, false, false, false, false, true, });
        }

        private void fRedBlink1Button_Click(object sender, EventArgs e) //00 1101 0010
        {
            SendCommand(new bool[] { false, false, true, true, false, true, false, false, true, false, });
        }

        private void fRedBlink2Button_Click(object sender, EventArgs e) //00 1101 0011
        {
            SendCommand(new bool[] { false, false, true, true, false, true, false, false, true, true, });
        }

        private void fRedBlink3Button_Click(object sender, EventArgs e) //00 1101 0100
        {
            SendCommand(new bool[] { false, false, true, true, false, true, false, true, false, false, });
        }

        private void fRedBlink4Button_Click(object sender, EventArgs e) //00 1101 0101
        {
            SendCommand(new bool[] { false, false, true, true, false, true, false, true, false, true, });
        }

        private void fRedBlinkAllButton_Click(object sender, EventArgs e) //00 1101 0001
        {
            SendCommand(new bool[] { false, false, true, true, false, true, false, false, false, true, });
        }

        private void ledsAmber_Click(object sender, EventArgs e) //00, 1110 1111
        {
            SendCommand(new bool[] { false, false, true, true, true, false, true, true, true, true, });
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://tkkrlab.nl/wiki/XBOX_360_RF_Module");
        }
    }
}
