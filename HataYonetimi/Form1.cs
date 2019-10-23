using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int telefonNumarasi = Convert.ToInt32(textBox1.Text);

            MessageBox.Show("Tebrikler, Telefon numarasını sisteme girebildin");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);

                MessageBox.Show("Tebrikler, Telefon numarasını sisteme girebildin");
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal olarak giriniz");
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);

                MessageBox.Show("Tebrikler, Telefon numarasını sisteme girebildin");
            }
            
            catch (Exception hata) // Bütün hatalar burada yakalanır.
            {

                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal olarak giriniz\n Hata : " + hata.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);

                MessageBox.Show("Tebrikler, Telefon numarasını sisteme girebildin");
            }

            catch (DivideByZeroException hata) // Sıfıra bölünme hatası
            {

                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal olarak giriniz\n Hata : " + hata.Message);
            }
            catch (IndexOutOfRangeException hata) // Dizin sınırları dışında hatası
            {

                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal olarak giriniz\n Hata : " + hata.Message);
            }
            catch (FormatException hata) // Format hatası (tür hatası)
            {

                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal olarak giriniz\n Hata : " + hata.Message);
            }
            catch (Exception hata) // Üstteki hatalar dışında kalan bütün hatalar burada yakalanır.
            {

                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal olarak giriniz\n Hata : " + hata.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);

                MessageBox.Show("Tebrikler, Telefon numarasını sisteme girebildin");
            }


            catch (Exception hata) // Bütün hatalar burada yakalanır.
            {

                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal olarak giriniz\n Hata : " + hata.Message);
            }
            finally
            {
                MessageBox.Show("Bu alanda yer alan kod blokları her zaman çalışacaktır !");
            }
        }
    }
}
