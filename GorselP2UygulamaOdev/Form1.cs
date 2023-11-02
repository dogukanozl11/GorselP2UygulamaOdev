using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselP2UygulamaOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
             * Ebata göre = en*boy*yukseklik*mesafe*0.00001+9
             * Ağırlığa göre ücret = ağırlık*mesafe*0.03+10
             * Bunlardan hangisi yüksekse ücret olacak
             * Anlaşmalı firmalara %20 indirim yapılacak.
             */
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double en = Convert.ToDouble(textBoxEN.Text);
            double boy = Convert.ToDouble(textBoxBOY.Text);
            double yukseklik = Convert.ToDouble(textBoxYuksek.Text);
            double agırlık = Convert.ToDouble(textBoxAgırlık.Text);
            double mesafe = Convert.ToDouble(textBoxMesafe.Text);
            double ebatucret = en * boy * yukseklik * mesafe * 0.00001 + 9;
            double agırlıkucret = agırlık * mesafe * 0.03 + 10;

            if (checkBox1.Checked == true)
            {
                ebatucret -= (ebatucret * 0.2);
                agırlıkucret -= (agırlıkucret * 0.2);
                if (ebatucret > agırlıkucret)
                {
                    //double indirimli = ebatucret - (ebatucret * 0.2);
                    //int ind = Convert.ToInt32(indirimli);
                    lblfiyat.Text = ebatucret.ToString() + " TL";
                }
                else
                {
                    //double indirimli2 = agırlıkucret - (agırlıkucret * 0.2);
                    //int ind2 = Convert.ToInt32(indirimli2);
                    lblfiyat.Text = agırlıkucret.ToString() + " TL";
                }
            }
            else
            {
                if (ebatucret > agırlıkucret)
                {
                    //int ebt=Convert.ToInt32(ebatucret);
                    lblfiyat.Text = ebatucret.ToString() + " TL";
                }
                else
                {
                    //int agr = Convert.ToInt32(agırlıkucret);
                    lblfiyat.Text = agırlıkucret.ToString() + " TL";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
