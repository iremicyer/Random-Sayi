using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Sayı
{
    public partial class Form1 : Form  // TextBox'ın MultiLine özelliğini aktif edersek, TextBox'ı istediğimiz boyutta ayarlayabiliriz.
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandomOluşturma_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // random sayı oluşturmak için fonksiyon oluşturuldu.

            string newLine = Environment.NewLine; // yeni bir satıra başlamak için bir dize döndürür.
            int sayilar = rnd.Next(0, 100); //oluşacak random sayıların 0 ve 100 arasında bir tam sayı olmasını sağlandı.(0 dahil 100 dahil değildir)
            textBoxSayilar.Text = sayilar.ToString();

            for (int i = 0; i <= 100; i++)
            {
                 sayilar = rnd.Next(0, 100);
                textBoxSayilar.Text = textBoxSayilar.Text + newLine + sayilar.ToString(); // üretilen sayıları TextBox'a yazdırıyoruz.


            }

        }

    

        private void textBoxSayilar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar); // TextBox'a dışarıdan harf girişi engellendi.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // TextBox'a karakter girişi engellendi.
        }
    }
}
