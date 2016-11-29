using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoSellGoodsMachine
{
    public partial class QRCodeTestForm : Form
    {
        public QRCodeTestForm()
        {
            InitializeComponent();
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        public void setTextBox(string sign, string txt) {
            this.txt_Sign.Text = sign;
            this.txt_QRCode.Text = txt;
        }

        public void setImageBox(System.Drawing.Bitmap image)
        {
            img_QRCode.Image = image;
        }
    }
}
