using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormKronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int salise, saniye, dakika, saat;
        int turSalise, turSaniye, turDakika, turSaat;
        int n = 1;

        private void btnTur_Click(object sender, EventArgs e)
        {
            label3.Text = n + ". Tur: ";
            lstTur.Items.Add(n + ". " + "Tur zamanı: " + turSaat.ToString() + ":" + turDakika.ToString() + ":" + turSaniye.ToString() + "," + turSalise.ToString());
            n++;
            turSalise = 0;
            turSaniye = 0;
            turDakika = 0;
            turSaat = 0;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {            
            if (kontrol == 0)
            {                
                label1.Text = "00:00,00";
                label2.Text = "00:00,00";
                turSalise = 0;
                turSaniye = 0;
                turDakika = 0;
                turSaat = 0;
                salise = 0;
                saniye = 0;
                dakika = 0;
                saat = 0;
                n = 1;
                label3.Text = n + ". Tur: ";
                lstTur.Items.Clear();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSifirla.Visible = false;
            label1.Text = "00:00,00";
            label2.Text = "00:00,00";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString() + "," + salise.ToString();            
            salise++;
            if (salise == 100)
            {
                salise = 0;
                saniye++;
                if (saniye == 60)
                {
                    saniye = 0;
                    dakika++;
                    if (dakika == 60)
                    {
                        dakika = 0;
                        saat++;
                    }
                }
            }
            label2.Text= turSaat.ToString() + ":" + turDakika.ToString() + ":" + turSaniye.ToString() + "," + turSalise.ToString();
            turSalise++;
            if (turSalise == 100)
            {
                turSalise = 0;
                turSaniye++;
                if (turSaniye == 60)
                {
                    turSaniye = 0;
                    turDakika++;
                    if (turDakika == 60)
                    {
                        turDakika = 0;
                        turSaat++;
                    }
                }
            }
        }
        int kontrol = 0;
        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            if (kontrol == 0)
            {
                timer.Enabled = true;
                timer.Interval = 10;
                btnBaşlat.Text = "Durdur";
                kontrol = 1;
                btnSifirla.Visible = false;
            }
            else if (kontrol == 1)
            {
                timer.Enabled = false;
                btnBaşlat.Text = "Başlat";
                kontrol = 0;
                btnSifirla.Visible = true;
            }

        }
    }
}
