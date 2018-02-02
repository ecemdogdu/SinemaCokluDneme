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
        string KoltukNo;
        int ucret = 0;
        TextBox a = new TextBox();
        ComboBox b = new ComboBox();
        CheckBox c = new CheckBox();
        CheckBox d = new CheckBox();
        int ToplamUcret = 0;
        public SatinAL(Form1 frm,string koltukNo,int kisiSayisi)
        {
            AnaForm = frm;
            InitializeComponent();
            txt1.Text = kisiSayisi.ToString();
            txtKoltukNo.Text = koltukNo;
            txtKoltukNo.Enabled = false;
            txtKoltukNo.Enabled = false;
        }

        private void SatinAL_Load(object sender, EventArgs e)
        {

        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (b.Text == "ogrenci")
            {
                ucret += 15;
                if (d.Checked || c.Checked)
                {
                    ucret += 15;
                }
                else if (d.Checked)
                {
                    ucret += 5;
                }
                else if (c.Checked)
                {
                    ucret += 10;
                }

            }
            else if (b.Text == "tam")
            {
                ucret = 20;
                if (d.Checked || c.Checked)
                {
                    ucret += 15;
                }
                else if (d.Checked)
                {
                    ucret += 5;
                }
                else if (c.Checked)
                {
                    ucret += 10;
                }
            }

            ToplamUcret += ucret;
            lblUcret.Text = ToplamUcret.ToString();
            lblMusteriUcret.Text = ucret.ToString();
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
                    TextBox a = new TextBox();
                    ComboBox b = new ComboBox();
                    CheckBox c = new CheckBox(); //menü
                    CheckBox d = new CheckBox(); //gözlük
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
                    c.Location = new Point(pointX, pointY+60);
                    panel1.Controls.Add(c);
                    d.Location = new Point(pointX, pointY+60);
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
