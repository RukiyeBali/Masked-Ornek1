using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox_Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //decimal corbaFiyat = 50;
            //decimal salataFiyat = 40;
            //decimal anaYemekFiyat = 120;
            //decimal tatliFiyat = 75;

            //decimal toplamtutar = 0;

            //if (tabControl1.SelectedIndex == 2)
            //{
            //    string ad=txtAdSoyad.Text;
            //    string telefon=txtTelefon.Text;
            //    decimal corbaToplam = 0;
            //    decimal salataToplam = 0;
            //    decimal anaYemekToplam = 0;
            //    decimal tatliToplam = 0;

            //    if (numCorba.Value > 0)
            //    {
            //        corbaToplam = numCorba.Value * corbaFiyat;
            //        toplamtutar += corbaToplam;
            //    }
            //    if(numSalata.Value > 0)
            //    {
            //        salataToplam= numSalata.Value * salataFiyat;
            //        toplamtutar += salataToplam;
            //    }
            //    if (numAnaYemek.Value > 0)
            //    {
            //        anaYemekToplam= numAnaYemek.Value * anaYemekFiyat;
            //        toplamtutar+= anaYemekToplam;
            //    }
            //    if (numTatli.Value > 0)
            //    {
            //        tatliToplam= numTatli.Value * tatliFiyat;
            //        toplamtutar += tatliToplam;
            //    }

            //    lblHesap.Text = String.Format("Ad: {0}\nTelefon: {1}\n\n" +
            //        "================================\n" +
            //        "{2} x Çorba = {3}\n" +
            //        "{4} x Salata = {5}\n" +
            //        "{6} x Ana Yemek = {7}\n" +
            //        "{8} x Tatlı = {9}\n" +
            //        "=================================\n" +
            //        "Toplam Fiyat: {10}\n" +
            //        "=================================\n" +
            //        "Afiyet olsun. Teşekkür Ederiz.",
            //        ad,
            //        telefon,
            //        numCorba.Value,
            //        corbaToplam,
            //        numSalata.Value,
            //        salataToplam,
            //        numAnaYemek.Value,
            //        anaYemekToplam,
            //        numTatli.Value,
            //        tatliToplam,
            //        toplamtutar);


            decimal[] fiyatlar = { 50, 40, 120, 75 };
            string[] urunler = { "Çorba", "Salata", "Ana Yemek", "Tatlı" };
            decimal toplamTutar = 0;

            if (tabControl1.SelectedIndex == 2)
            {
                string ad = txtAdSoyad.Text;
                string telefon = txtTelefon.Text;
                StringBuilder siparisDetay = new StringBuilder();

                for (int i = 0; i < urunler.Length; i++)
                {
                    NumericUpDown numUpDown = null;

                    switch (i)
                    {
                        case 0: numUpDown = numCorba; break;
                        case 1: numUpDown = numSalata; break;
                        case 2: numUpDown = numAnaYemek; break;
                        case 3: numUpDown = numTatli; break;
                    }

                    decimal urunAdet = numUpDown.Value;
                    decimal urunTutar = urunAdet * fiyatlar[i];

                    if (urunAdet > 0)
                    {
                        toplamTutar += urunTutar;
                        siparisDetay.AppendLine($"{urunAdet}x {urunler[i]} = {urunTutar}");
                    }
                }

                lblHesap.Text = String.Format("Ad: {0}\nTelefon: {1}\n\n" +
                    "================================\n" +
                    "{2}\n" +
                    "=================================\n" +
                    "Toplam Fiyat: {3}\n" +
                    "=================================\n" +
                    "Afiyet olsun. Teşekkür Ederiz.",
                    ad,
                    telefon,
                    siparisDetay.ToString(),
                    toplamTutar);
            }






        
        }
    }
}
