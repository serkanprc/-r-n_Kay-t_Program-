using System.Security.Cryptography;

namespace MonitörProje
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();


        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                panel form2 = new panel();
                form2.Show();
                this.Hide();
            }
            else if (textBox1.Text == "kullanıcı" && textBox2.Text == "kullanıcı")
            {
                kullanıcıpanel form = new kullanıcıpanel();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Lütfen Tekrar Deneyiniz...");
            }
        }
    }
}