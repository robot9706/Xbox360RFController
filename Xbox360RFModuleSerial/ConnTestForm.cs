using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xbox360RFModuleSerial
{
    public partial class ConnTestForm : Form
    {
        private MainForm _main;

        private Thread _clockTester;

        private bool _clock;
        private int _avgHz;

        public ConnTestForm(MainForm main)
        {
            _main = main;

            InitializeComponent();
        }

        private void ConnTestForm_Load(object sender, EventArgs e)
        {
            helpLbl.Text = "";
            help2Lbl.Text = "";
        }

        private void UpdateHelp2()
        {
            if (!updateCb.Checked)
            {
                return;
            }

            bool outc = _main.GetOutputSignal();

            if (_main.IsRTSInverted)
                outc = !outc;

            if (outc)
            {
                help2Lbl.Text = "Now the clock should chage (the text is updated 10 times in a second)\n RevH RF boards should give ~340Hz.";
            }
            else
            {
                help2Lbl.Text = "Now the clock should stay";
            }
        }

        private void updateCb_CheckedChanged(object sender, EventArgs e)
        {
            viewUpdateTimer.Enabled = updateCb.Checked;
            if (updateCb.Checked)
            {
                _clockTester = new Thread(new ThreadStart(DoClockTest));
                _clockTester.IsBackground = true;
                _clockTester.Start();

                UpdateHelp2();
            }
            else
            {
                help2Lbl.Text = "";
                inputDataLbl.Text = "N/A";
                _clockTester.Abort();
                _clockTester = null;
            }
        }

        private void outputCb_CheckedChanged(object sender, EventArgs e)
        {
            bool outc = outputCb.Checked;

            _main.WriteData(outc);

            string s = "";

            if (_main.IsRTSInverted)
                outc = !outc;

            if (outc)
            {
                s = "0";
            }
            else
            {
                s = "3.3";
            }

            helpLbl.Text = "Now you should have " + s + "V on the RTS pin.";

            UpdateHelp2();
        }

        private void DoClockTest()
        {
            //Read as fast as we can
            try
            {
                _clock = _main.ReadClock();
                int tick = 0;
                DateTime start = DateTime.Now;

                while (true)
                {
                    bool rc = _main.ReadClock();
                    if (rc != _clock) //Change
                    {
                        _clock = rc;
                        tick++;
                    }

                    TimeSpan elp = DateTime.Now - start;
                    if (elp.TotalSeconds >= 1)
                    {
                        start = DateTime.Now;

                        _avgHz = tick;
                        tick = 0;
                    }

                    Thread.Yield();
                }
            }
            catch (Exception ex)
            {
                Thread.ResetAbort();
                //We aborted it :)
            }
        }

        private void viewUpdateTimer_Tick(object sender, EventArgs e)
        {
            inputDataLbl.Text = (_clock ? "High" : "Low");
            inputHz.Text = "~" + _avgHz.ToString() + "Hz";
        }

        private void ConnTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_clockTester != null)
            {
                _clockTester.Abort();
                _clockTester = null;
            }
        }
    }
}
