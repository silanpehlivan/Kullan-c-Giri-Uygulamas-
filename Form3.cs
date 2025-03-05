using KullanıcıGirişUygulaması;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıGirişUygulaması
{
    public partial class Form3 : Form
    {
        private string kullanıcı_Adı; 
        public Form3(string kullaniciAdi) //default ctor vardı.İçerisine veri girdik.
        {
            InitializeComponent();
            this.kullanıcı_Adı = kullaniciAdi;
            label1.Text = $" SAYIN {kullaniciAdi} SİSTEME HOŞGELDİNİZ...";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //formu kapattım
            Application.Exit(); //uygulamayı kapatırız.
        }
    }
}

