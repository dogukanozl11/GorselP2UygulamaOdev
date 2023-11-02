namespace GorselP2UygulamaOdev
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMesafe = new System.Windows.Forms.TextBox();
            this.textBoxAgırlık = new System.Windows.Forms.TextBox();
            this.textBoxYuksek = new System.Windows.Forms.TextBox();
            this.textBoxBOY = new System.Windows.Forms.TextBox();
            this.textBoxEN = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblfiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxMesafe);
            this.groupBox1.Controls.Add(this.textBoxAgırlık);
            this.groupBox1.Controls.Add(this.textBoxYuksek);
            this.groupBox1.Controls.Add(this.textBoxBOY);
            this.groupBox1.Controls.Add(this.textBoxEN);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UYGULAMA";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfiyat.Location = new System.Drawing.Point(189, 279);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(27, 29);
            this.lblfiyat.TabIndex = 13;
            this.lblfiyat.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(72, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "ÜCRET : ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(25, 210);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(247, 56);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "MESAFE (KM) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "AĞIRLIK (KG) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "YÜKSEKLİK (CM) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "BOY (CM) : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "EN (CM) :";
            // 
            // textBoxMesafe
            // 
            this.textBoxMesafe.Location = new System.Drawing.Point(142, 182);
            this.textBoxMesafe.Name = "textBoxMesafe";
            this.textBoxMesafe.Size = new System.Drawing.Size(130, 22);
            this.textBoxMesafe.TabIndex = 5;
            // 
            // textBoxAgırlık
            // 
            this.textBoxAgırlık.Location = new System.Drawing.Point(142, 154);
            this.textBoxAgırlık.Name = "textBoxAgırlık";
            this.textBoxAgırlık.Size = new System.Drawing.Size(130, 22);
            this.textBoxAgırlık.TabIndex = 4;
            // 
            // textBoxYuksek
            // 
            this.textBoxYuksek.Location = new System.Drawing.Point(142, 126);
            this.textBoxYuksek.Name = "textBoxYuksek";
            this.textBoxYuksek.Size = new System.Drawing.Size(130, 22);
            this.textBoxYuksek.TabIndex = 3;
            // 
            // textBoxBOY
            // 
            this.textBoxBOY.Location = new System.Drawing.Point(142, 98);
            this.textBoxBOY.Name = "textBoxBOY";
            this.textBoxBOY.Size = new System.Drawing.Size(130, 22);
            this.textBoxBOY.TabIndex = 2;
            // 
            // textBoxEN
            // 
            this.textBoxEN.Location = new System.Drawing.Point(142, 70);
            this.textBoxEN.Name = "textBoxEN";
            this.textBoxEN.Size = new System.Drawing.Size(130, 22);
            this.textBoxEN.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Anlaşmalı Firma";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMesafe;
        private System.Windows.Forms.TextBox textBoxAgırlık;
        private System.Windows.Forms.TextBox textBoxYuksek;
        private System.Windows.Forms.TextBox textBoxBOY;
        private System.Windows.Forms.TextBox textBoxEN;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHesapla;
    }
}

