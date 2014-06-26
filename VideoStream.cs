using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EGR424Project2App
{
    class VideoStream
    {
        private bool running;

        private Thread thread;
        private int thread_period_ms;

        private string rootLocation;
        private SerialPort sp;

        private Byte[] writeBuffer;

        public VideoStream()
        {
            thread = new Thread(new ThreadStart(process));
            sp = new SerialPort();
        }

        public void Start(string fileLocation, double frame_rate)
        {
            if (running)
            {
                string errMsg = "VideoStream.Start : VideoStream is already running, cannot start over.";
                Exception ex = new Exception(errMsg);
                throw ex;
            }
            if (frame_rate < 1 || frame_rate > 10)
            {
                string errMsg = "VideoStream.Start : Frame rate is out of bounds, must be between 1 and 10.";
                Exception ex = new Exception(errMsg);
                throw ex;
            }
            else
            {
                thread_period_ms = (int)(1000 / frame_rate); 
            }
            if (!Directory.Exists(fileLocation))
            {
                string errMsg = "VideoStream.Start : Directory does not exist.";
                Exception ex = new Exception(errMsg);
                throw ex;
            }
            else
            {
                rootLocation = fileLocation;
                thread = new Thread(new ThreadStart(process));
                try
                {
                    thread.Start();
                }
                catch (Exception inner)
                {
                    string errMsg = "VideoStream.Start : Unable to start process thread.";
                    Exception ex = new Exception(errMsg, inner);
                    throw ex;
                }
                running = true;
            }

        }

        public void Stop()
        {
            running = false;
            thread.Join();
        }

        public void OpenSerialPort(string portname)
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
            try
            {
                sp = new SerialPort(portname, 115200, Parity.None, 8, StopBits.One);
                sp.Open();
            }
            catch (Exception inner)
            {
                string errMsg = "VideoStream.OpenSerialPort : Error connecting to com port.";
                Exception ex = new Exception(errMsg, inner);
                throw ex;
            }
        }

        public void CloseSerialPort()
        {
            sp.Close();
        }

        private void writeToSerialPortProcess()
        {
            try
            {
                writeData(writeBuffer);
            }
            catch (Exception) { }
            isWriteDone = true;
            return;
        }

        private bool isWriteDone = true;

        private void process()
        {
            Stopwatch _threadTimer = new Stopwatch();
            _threadTimer.Start();

            string[] files = Directory.GetFiles(rootLocation, "*.bmp");
            int fileCount = files.Length;
            int index = 0;

            while(running)
            {
                long timeToSleep = thread_period_ms - _threadTimer.ElapsedMilliseconds;
                if (timeToSleep > 0)
                {
                    Thread.Sleep((int)timeToSleep);
                }
                _threadTimer.Restart();

                // do stuff here
                Bitmap imageToDisplay = null;
                try
                {
                    imageToDisplay = loadBitmap(files[index]);
                }
                catch (Exception) { }

                Byte[] dataToWrite = null;
                try
                {
                    dataToWrite = imageToByteArray(imageToDisplay);
                }
                catch (Exception) { }

                while(!isWriteDone)
                {
                    Thread.Sleep(5);
                }

                writeBuffer = dataToWrite;
                Thread writeThread = new Thread(new ThreadStart(writeToSerialPortProcess));
                writeThread.Start();


                // increase index
                index = (index + 1) % fileCount;

            }
            return;
        }

        private void writeData(Byte[] data)
        {
            try
            {
                sp.Write(data, 0, data.Length);
            }
            catch (Exception inner)
            {
                string errMsg = "VideoStream.writeData : Unable to write data to serial port.";
                Exception ex = new Exception(errMsg, inner);
                throw ex;
            }
        }

        private Bitmap loadBitmap(string location)
        {
            Bitmap b = null;
            try
            {
                b = new Bitmap(location);
            }
            catch (Exception inner)
            {
                string errMsg = "VideoStream.loadBitmap : Exception thrown opening bitmap.";
                Exception ex = new Exception(errMsg,inner);
                throw ex;
            }
            return b;
        }

        unsafe private byte[] imageToByteArray(Bitmap b)
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
                    if (secondBit)
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

            return dataToSend;
        }
    }
}
