using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimlikDogrulama.Dogrulama;
using  MetroFramework;

namespace KimlikDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        
        public void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            long tckn = long.Parse(textBox1.Text);
            int dogumTarihi;
            ad = tbxName.Text;
            soyad = tbxSurname.Text;
            dogumTarihi = date.Value.Year;
            Dogrulama.KPSPublicSoapClient dogrulama = new KPSPublicSoapClient();
            bool sonuc = dogrulama.TCKimlikNoDogrula(tckn, ad, soyad, dogumTarihi);

            if (sonuc == true)
            {
                MessageBox.Show("Bilgiler Doğru", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }

            if (sonuc==false)
            {
                
                MessageBox.Show("Bilgiler Yanlış", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

               
            }
        }

       
    }
}
