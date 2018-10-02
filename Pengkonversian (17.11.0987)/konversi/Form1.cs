using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using konversiLibrary1;

namespace konversi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_konfersi_click(object sender, EventArgs e)
        {
            int nominal = int.Parse(inputnominal.Text);
            pengonversian terbilang= new pengonversian();

            konversi.Items.Clear();
            konversi.Items.Add(terbilang.TerbilangIndonesia(nominal));
        }
    }
}
