using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YasadigimGunSayisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gun, ay, yil;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtarih.Value;
            gun = tarih.Day;
            ay = tarih.Month;
            yil = tarih.Year;
            DateTime dogumTarihi = new DateTime(yil, ay, gun);
            DateTime simdi = DateTime.Now;

            if(dogumTarihi>simdi)
            {
                lblSonuc.Text = "";
                MessageBox.Show("Lütfen geçerli bir doğum tarihi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TimeSpan gunfarkı = (simdi - dogumTarihi);
                int sonuc = gunfarkı.Days;
                lblSonuc.Text = "Toplam " + sonuc + " gündür yaşıyorsunuz.";

            }

      
        }
    }
}
