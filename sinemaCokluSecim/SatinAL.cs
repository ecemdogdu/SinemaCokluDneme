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
    public partial class SatinAL : Form
    {
        Form1 AnaForm;
       
        int kisiSay ;
        int ucret = 0;
        TextBox a = new TextBox();
        ComboBox b = new ComboBox();
        CheckBox c = new CheckBox(); //menü 
        CheckBox d = new CheckBox(); //gözlük
        bool isaretliMi = false;
        int ToplamUcret = 0;
        public SatinAL(Form1 frm,string koltukNo,int kisiSayisi)
        {
            AnaForm = frm;
            InitializeComponent();
            txt1.Text = kisiSayisi.ToString();
            kisiSay = kisiSayisi;
            txtKoltukNo.Text = koltukNo;
            txtKoltukNo.Enabled = false;
            txtKoltukNo.Enabled = false;
        }

        private void SatinAL_Load(object sender, EventArgs e)
        {

        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            
            isaretliMi = d.Checked ;
            if (b.Text == "ogrenci")
            {
                ucret += 15*kisiSay;
                if (isaretliMi || c.Checked)
                {
                    ucret += 10+(5*kisiSay);
                }
                else if (isaretliMi)
                {
                    ucret += 5*kisiSay;
                }
                else if (c.Checked)
                {
                    ucret += 10;
                }

            }
            else if (b.Text == "tam")
            {
                ucret = 20*kisiSay;
                if (isaretliMi || c.Checked)
                {
                    ucret += 10 + (5 * kisiSay);
                }
                else if (isaretliMi)
                {
                    ucret += 5*kisiSay;
                }
                else if (c.Checked)
                {
                    ucret += 10;
                }
            }
            
            ToplamUcret += ucret;
            lblUcret.Text = ToplamUcret.ToString();
            lblMusteriUcret.Text = ucret.ToString();
            DoluKoltukBul(txtKoltukNo.Text);
            MessageBox.Show("ucret" +ucret);
            this.Close();
        }
        public void DoluKoltukBul(string koltukNo)
        {
            switch (txtKoltukNo.Text)
            {
                case "A1":
                    AnaForm.A1BackGround();
                    break;
                case "A2":
                    AnaForm.A2BackGround();
                    break;
                case "A3":
                    AnaForm.A3BackGround();
                    break;
                case "A4":
                    AnaForm.A4BackGround();
                    break;
                case "A5":
                    AnaForm.A5BackGround();
                    break;
                case "A1A2":
                    AnaForm.A1BackGround();
                    AnaForm.A2BackGround();
                    break;
                case "A1A3":
                    AnaForm.A1BackGround();
                    AnaForm.A3BackGround();
                    break;
                case "A1A4":
                    AnaForm.A1BackGround();
                    AnaForm.A4BackGround();
                    break;
                case "A1A5":
                    AnaForm.A1BackGround();
                    AnaForm.A5BackGround();
                    break;
                case "A2A3":AnaForm.A2BackGround();
                    AnaForm.A3BackGround();
                    break;
                case "A2A4":AnaForm.A2BackGround();
                    AnaForm.A4BackGround();
                    break;
                case "A2A5": AnaForm.A2BackGround();
                    AnaForm.A5BackGround();
                 break;
                case "A3A1": AnaForm.A1BackGround();
                    AnaForm.A3BackGround();
                    break;
                case "A3A2":AnaForm.A2BackGround();
                    AnaForm.A3BackGround();
                    break;
                case "A3A4":AnaForm.A3BackGround();
                    AnaForm.A4BackGround();
                    break;
                case "A3A5": AnaForm.A3BackGround();
                    AnaForm.A5BackGround();
                    break;
                case "A4A1": AnaForm.A4BackGround();
                    AnaForm.A1BackGround();
                    break;
                case "A4A2": AnaForm.A4BackGround();
                    AnaForm.A2BackGround();
                    break;
                case "A4A3": AnaForm.A4BackGround();
                    AnaForm.A3BackGround();
                    break;
                case "A4A5": AnaForm.A4BackGround();
                    AnaForm.A5BackGround();
                    break;
                case "A1A2A3":
                    AnaForm.A1BackGround();
                    AnaForm.A2BackGround();
                    AnaForm.A3BackGround();
                    break;
                case "A1A2A4":
                    AnaForm.A1BackGround();
                    AnaForm.A2BackGround();
                    AnaForm.A4BackGround();
                    break;
                case "A1A2A5":
                    AnaForm.A1BackGround();
                    AnaForm.A2BackGround();
                    AnaForm.A5BackGround();
                    break;
                
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int txtno = int.Parse(txt1.Text);
                int pointX = 30;
                int pointY = 40;
                panel1.Controls.Clear();
                for (int i = 0; i < txtno; i++)
                {
                    b.Items.Add("ogrenci");
                    b.Items.Add("tam");
                    
                    a.Text = (i + 1).ToString();
                    b.Text= (i + 1).ToString();
                    c.Text = (i + 1).ToString();
                    d.Text = (i + 1).ToString();
                    a.Location = new Point(pointX, pointY);
                    panel1.Controls.Add(a);
                    b.Location = new Point(pointX, pointY+20);
                    panel1.Controls.Add(b);
                    c.Location = new Point(pointX, pointY+50);
                    panel1.Controls.Add(c);
                    d.Location = new Point(pointX, pointY+100);
                    panel1.Controls.Add(d);
                    a.Text +=" "+ txtKoltukNo.Text;
                    c.Text = "menü";
                    d.Text = "gozluk";   
                    panel1.Show();
                    pointY += 20;
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
