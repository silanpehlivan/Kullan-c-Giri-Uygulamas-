using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıGirişUygulaması.Sınıflar
{
    public class Calısanlar
    {
        public static string Kullanıcı_Adi { get; set; } //Globalde tanımladım
        public static string Kullanici_sifre { get; set; }



        public bool KullaniciKontrol() //Metot üzerinden tanımladım.
        {
            if (string.IsNullOrEmpty(Kullanıcı_Adi) || Kullanıcı_Adi.Length < 5)
            {
                MessageBox.Show("Kullanıcı adı 5 karakterden az olamaz.");
                return false;
            }
            if (Kullanici_sifre.Length < 5)
            {
                MessageBox.Show("Kullanıcı şifresi 5 karakterden az olamaz.");
                return false;
            }
            return true;
        }


    }
}






