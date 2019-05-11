using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorQR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw codigoQR = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = codigoQR.Draw(textBox1.Text, 50);
        }
    }
}
