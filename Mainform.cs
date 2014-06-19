using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGR424Project2App
{
    public partial class Mainform : Form
    {
        private SerialPort sp;


        public Mainform()
        {
            InitializeComponent();
            DisplayAvailableComPorts();
            sp = new SerialPort();
        }

        private void DisplayAvailableComPorts()
        {
            cmboComPorts.Items.Clear();

            string[] comports = null;
            try
            {
                comports = SerialPort.GetPortNames();
            }
            catch (Exception)
            {
            }

            for (int i = comports.Length - 1; i > -1; i--)
            {
                cmboComPorts.Items.Add(comports[i]);
            }
        }

        private void btnComOpen_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
            try
            {
                sp = new SerialPort(cmboComPorts.Text, 115200, Parity.None, 8, StopBits.One);
                sp.Open();
            }
            catch (Exception inner)
            {
                string errMsg = "MainForm.btnComOpen_Click : Error connecting to com port.";
                Exception ex = new Exception(errMsg, inner);
                DisplayError(errMsg, ex);
            }
        }

        private void btnRefreshComPorts_Click(object sender, EventArgs e)
        {
            DisplayAvailableComPorts();
        }

        private void DisplayError(string errMsg, Exception ex)
        {
            MessageBox.Show(errMsg + Environment.NewLine + "Detailed Error: " + Environment.NewLine + ex.ToString(), "Error");
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Close();
        }

        private void btnSendChar_Click(object sender, EventArgs e)
        {
            string c = txtCharToSend.Text;
            if (c.Length > 0)
            {
                char[] charToSend = new char[1];
                charToSend[0] = c[0];
                try
                {
                    sp.Write(charToSend, 0, 1);
                }
                catch (Exception inner)
                {
                    string errMsg = "Mainform.btnSendChar_Click : Error occured writing char to device.";
                    Exception ex = new Exception(errMsg, inner);
                    DisplayError(errMsg, ex);
                }
                
            }
            
        }
    }
}
