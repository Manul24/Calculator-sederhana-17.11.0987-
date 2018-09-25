using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textA.Text);
            int b = int.Parse(textB.Text);
            int hitung;
            string hasil;

            if (cbOperasi.SelectedIndex == 0)
            {
                hitung = a + b;
                hasil = hitung.ToString();
                textHasil.Text = hasil;
            }

            if (cbOperasi.SelectedIndex == 1)
            {
                hitung = a - b;
                hasil = hitung.ToString();
                textHasil.Text = hasil;
            }

            if (cbOperasi.SelectedIndex == 2)
            {
                hitung = a / b;
                hasil = hitung.ToString();
                textHasil.Text = hasil;
            }

            if (cbOperasi.SelectedIndex == 3)
            {
                hitung = a * b;
                hasil = hitung.ToString();
                textHasil.Text = hasil;
            }

        }

    }
}
