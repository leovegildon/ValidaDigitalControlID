using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControliD;

namespace ValidaDigital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ret = CIDBio.Init();
            if (ret == RetCode.SUCCESS)
            {
                captureLog.Text += "Init Successful\r\n";
                btnCapturar.Enabled = true;
            }
            else if (ret < RetCode.SUCCESS)
            {
                captureLog.Text += "Init Error: " + CIDBio.GetErrorMessage(ret) + "\r\n";
            }
            else
            {
                captureLog.Text += "Init Warning: " + CIDBio.GetErrorMessage(ret) + "\r\n";
                btnCapturar.Enabled = true;
            }
        }

        string t;
        byte[] imageBuf;
        uint width, height;
        int quality;

        public static Bitmap ImageBufferToBitmap(byte[] imageBuf, uint width, uint height)
        {
            Bitmap img = new Bitmap((int)width, (int)height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    var color = Color.FromArgb(imageBuf[x + img.Width * y], imageBuf[x + img.Width * y], imageBuf[x + img.Width * y]);
                    img.SetPixel(x, y, color);
                }
            }
            return img;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            CIDBio cIDBio = new CIDBio();
            cIDBio.CaptureImageAndTemplate(out t, out imageBuf, out width, out height, out quality);
            //MessageBox.Show(imageBuf.ToString());
            pictureFinger.Image = ImageBufferToBitmap(imageBuf, width, height);

            textBox1.Text = t;
        }
    }
}
