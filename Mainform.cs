using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        private void btnSendDemoImage_Click(object sender, EventArgs e)
        {

            byte[] demoImage = null;
            byte width, height;
            byte value;
            try
            {
                width = Convert.ToByte(txtDemoImageWidth.Text);
                height = Convert.ToByte(txtDemoImageHeight.Text);
                value = Convert.ToByte(txtDemoImageValue.Text);
                demoImage = new byte[width * height / 2 + 3];
                demoImage[0] = 0xFF;
                demoImage[1] = width;
                demoImage[2] = height;
                for (int i = 3; i < demoImage.Length; i++)
                {
                    demoImage[i] = value;
                }
            }
            catch (Exception)
            {

            }

            try
            {
                sp.Write(demoImage, 0, demoImage.Length);
            }
            catch (Exception inner)
            {
                string errMsg = "Mainform.btnSendDemoImage : Error sending demo image to board.";
                Exception ex = new Exception(errMsg, inner);
                DisplayError(errMsg, inner);
            }
        }

        private void btnImageBrowseAndSend_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap (*bmp)|*bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap(ofd.FileName);
                ImageToByteArray(b);
            }
        }

        unsafe private byte[] ImageToByteArray(Bitmap b)
        {
            // scale image
            Bitmap scaledImage = new Bitmap(128, 96);
            
            // apply gain to the image
            float displayGain = 1.0f;
            float[][] matrix = {
                    new float[] {displayGain, 0, 0, 0, 0},
                    new float[] {0, displayGain, 0, 0, 0},
                    new float[] {0, 0, displayGain, 0, 0},
                    new float[] {0, 0, 0, displayGain, 0},
                    new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(matrix);

            ImageAttributes imageAttr = new ImageAttributes();
            imageAttr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // make the scaled bitmap
            Graphics g = null;
            try
            {
                g = Graphics.FromImage(scaledImage);
            }
            catch (Exception inner)
            {
            }
            // grab the nearest pixel for color
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            try
            {
                g.DrawImage(b, new Rectangle(0, 0, scaledImage.Width, scaledImage.Height),
                    0, 0, b.Width, b.Height, GraphicsUnit.Pixel, imageAttr);
            }
            catch (Exception inner)
            {
            }
            // dispose graphics ~ avoids memory leak
            g.Dispose();


            BitmapData B_data = scaledImage.LockBits(new Rectangle(0, 0, scaledImage.Width, scaledImage.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);


            byte[] dataToSend = new byte[scaledImage.Width * scaledImage.Height / 2 + 10];
            dataToSend[0] = 0xFF;
            dataToSend[1] = (byte)scaledImage.Width;
            dataToSend[2] = (byte)scaledImage.Height;

            int insertPosition = 3;
            bool secondBit = false;

            for (int y = 0; y < scaledImage.Height; y++)
            {
                byte* row = (byte*)B_data.Scan0 + (y * B_data.Stride);
                for (int x = 0; x < scaledImage.Width; x++)
                {
                    byte blue = row[x * 3];
                    byte green = row[x * 3 + 1];
                    byte red = row[x * 3 + 2];
                    byte intensity = Convert.ToByte(0.21 * red + 0.72 * green + 0.07 * blue);
                    if(secondBit)
                    {
                        intensity = (byte)((byte)(intensity / 16));
                        dataToSend[insertPosition] |= intensity;
                        secondBit = false;
                        insertPosition++;
                    }
                    else
                    {
                        intensity = (byte)((byte)(intensity / 16) << 4);
                        dataToSend[insertPosition] |= intensity;
                        secondBit = true;
                    }
                }
            }

            scaledImage.UnlockBits(B_data);

            try
            {
                sp.Write(dataToSend, 0, dataToSend.Length);
            }
            catch (Exception inner)
            {
                string errMsg = "Mainform.btnSendDemoImage : Error sending demo image to board.";
                Exception ex = new Exception(errMsg, inner);
                DisplayError(errMsg, inner);
            }


            return null;
        }
    }
}
