namespace sinemaCokluSecim
{
    partial class SatinAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMusteriUcret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(309, 37);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(75, 23);
            this.btnSatinAl.TabIndex = 24;
            this.btnSatinAl.Text = "Satin Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(20, 14);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(19, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 142);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ToplamUcret:";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(139, 198);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(10, 13);
            this.lblUcret.TabIndex = 26;
            this.lblUcret.Text = "-";
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Location = new System.Drawing.Point(309, 15);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukNo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ODENECEK:";
            // 
            // lblMusteriUcret
            // 
            this.lblMusteriUcret.AutoSize = true;
            this.lblMusteriUcret.Location = new System.Drawing.Point(113, 224);
            this.lblMusteriUcret.Name = "lblMusteriUcret";
            this.lblMusteriUcret.Size = new System.Drawing.Size(10, 13);
            this.lblMusteriUcret.TabIndex = 29;
            this.lblMusteriUcret.Text = "-";
            // 
            // SatinAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 261);
            this.Controls.Add(this.lblMusteriUcret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKoltukNo);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.panel1);
            this.Name = "SatinAL";
            this.Text = "SatinAL";
            this.Load += new System.EventHandler(this.SatinAL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMusteriUcret;
    }
}