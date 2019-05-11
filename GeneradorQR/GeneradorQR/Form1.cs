﻿using System;
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
            //pictureBox1.Padding = new Padding(100, 10, 10, 10);

            textBox1.Focus();

        }

        private void TextToQR(string texto)
        {
            Zen.Barcode.CodeQrBarcodeDraw codigoQR = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = codigoQR.Draw(texto, 50, 5);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextToQR(textBox1.Text);
        }
    }
}
