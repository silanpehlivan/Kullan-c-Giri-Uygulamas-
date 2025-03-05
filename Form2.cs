using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıGirişUygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcı_Adı = textBox1.Text;
            string kullanici_sifre = textBox2.Text;


            if (kullanıcı_Adı == Form1.Kullanici_Adi && kullanici_sifre == Form1.Kullanici_Sifre)
            {
               
                Form3 form3 = new Form3(kullanıcı_Adı); //form3'te ctor default olmadığı için bu nesnede içerisine bir şey eklemez isek hata alırız.
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgilerini kontrol ediniz.");
            }
        }
    }
}
