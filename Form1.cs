using KullanıcıGirişUygulaması.Sınıflar;

namespace KullanıcıGirişUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Kullanici_Adi { get; set; } //Globalde tanımladım
        public static string Kullanici_Sifre { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcı_Adı = textBox1.Text;
            string kullanici_sifre = textBox2.Text;

            Kullanici_Adi = kullanıcı_Adı;
            Kullanici_Sifre = kullanici_sifre;

            Calısanlar calısan=new Calısanlar();
            calısan.KullaniciKontrol();

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
