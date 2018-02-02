using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemaCokluSecim
{
    public partial class Form1 : Form
    {
        int koltukSayisi=0;
        string koltukNo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (chbKoltukA1.Checked == true)
            {
                koltukSayisi++;
                koltukNo = "A1";
                if (chbKoltukA1.Checked||chbKoltukA2.Checked)
                {
                    koltukSayisi++;
                    koltukNo += "A2";

                }
            }
            else if (chbKoltukA2.Checked == true)
            {
                koltukSayisi++;
                koltukNo = "A2";
            }
            else if (chbKoltukA3.Checked == true)
            {
                koltukSayisi++;
                koltukNo = "A3";
            }
            else if (chbKoltukA4.Checked == true)
            {
                koltukSayisi++;
                koltukNo = "A4";
            }
            else if (chbKoltukA5.Checked == true)
            {
                koltukSayisi++;
                koltukNo = "A5";
            }
           SatinAL bs = new SatinAL(this, koltukNo, koltukSayisi);
            bs.ShowDialog();
        }
    }
}
