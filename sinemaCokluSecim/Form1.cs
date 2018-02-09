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
        
        string koltukNo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            int koltukSayisi = 0;
            if (chbKoltukA1.Checked == true)
            {
                koltukSayisi++;
                koltukNo = "A1";
               
                if (chbKoltukA2.Checked)
                {
                    koltukSayisi++;
                    koltukNo += "A2";
                    if (chbKoltukA3.Checked)
                    {
                        koltukSayisi++;
                        koltukNo += "A3";
                        if (chbKoltukA4.Checked)
                        {
                            koltukSayisi++;
                            koltukNo += "A4";
                            if (chbKoltukA5.Checked)
                            {
                                koltukSayisi++;
                                koltukNo += "A5";
                            }
                        }
                    }
                }
                else if (chbKoltukA3.Checked)
                {
                    koltukSayisi++;
                    koltukNo += "A3";
                    if (chbKoltukA2.Checked)
                    {
                        koltukSayisi++;
                        koltukNo += "A2";
                        if (chbKoltukA4.Checked)
                        {
                            koltukSayisi++;
                            koltukNo += "A4";
                            if (chbKoltukA5.Checked)
                            {
                                koltukSayisi++;
                                koltukNo += "A5";
                                
                            }
                            if (chbKoltukA1.Checked)
                            {
                                koltukSayisi++;
                                koltukNo += "A1";
                            }
                        }
                    }
                    else if (chbKoltukA4.Checked)
                    {
                        koltukSayisi++;
                        koltukNo += "A4";

                        if (chbKoltukA1.Checked)
                        {
                            koltukSayisi++;
                            koltukNo += "A1";
                            if (chbKoltukA2.Checked)
                            {
                                koltukSayisi++;
                                koltukNo += "A2";
                                if (chbKoltukA3.Checked)
                                {
                                    koltukSayisi++;
                                    koltukNo += "A3";
                                }
                                if (chbKoltukA5.Checked)
                                {
                                    koltukSayisi++;
                                    koltukNo += "A5";
                                }
                            }
                        }
                    }
                    else if (chbKoltukA5.Checked)
                    {
                        koltukSayisi++;
                        koltukNo += "A5";
                        if (chbKoltukA1.Checked)
                        {
                            koltukSayisi++;
                            koltukNo += "A1";
                            if (chbKoltukA2.Checked)
                            {
                                koltukSayisi++;
                                koltukNo += "A2";
                            }
                        }
                    }
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
        public void A1BackGround()
        {
            chbKoltukA1.BackColor = Color.Red;
            chbKoltukA1.Enabled = false;
        }
        public void A2BackGround()
        {
            chbKoltukA2.BackColor = Color.Red;
            chbKoltukA2.Enabled = false;
        }
        public void A3BackGround()
        {
            chbKoltukA3.BackColor = Color.Red;
            chbKoltukA3.Enabled = false;
        }
        public void A4BackGround()
        {
            chbKoltukA4.BackColor = Color.Red;
            chbKoltukA4.Enabled = false;
        }
        public void A5BackGround()
        {
            chbKoltukA5.BackColor = Color.Red;
            chbKoltukA5.Enabled = false;
        }
    }
}
