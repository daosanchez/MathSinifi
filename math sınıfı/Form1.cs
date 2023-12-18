using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToSingle(txtSayi.Text); // sayısal olarak texti çevirdik


            // işlemler

            double sayiMutlak = Math.Abs(sayi);
            double sayiUs = Math.Pow(sayi, 2 );
            double sayiYukariYuvarla = Math.Ceiling(sayi);
            double sayiKareKok = Math.Sqrt(sayi);
            double sayiAssagiYuvarlama = Math.Floor(sayi);
            double sayiYuvarlama = Math.Round(sayi);




            // sonuçlar yazdır

            lblMutlak.Text ="Sayının Mutlak Değeri: " +  sayiMutlak.ToString();
            lblUs.Text = "Sayının Üs Değeri: " + sayiUs.ToString();
            lblYukariYuvarla.Text = "Sayını Yukarı Yuvarla: " + sayiYukariYuvarla.ToString();
            lblKok.Text ="Sayının Kare Kökü: " + sayiKareKok.ToString();
            lblAssagiYuvarla.Text ="Sayını Aşşağı Yuvarla: " + sayiAssagiYuvarlama.ToString();
            lblYuvarla.Text = "Sayını Yuvarla: " + sayiYuvarlama.ToString();
                
        }
    }
}
