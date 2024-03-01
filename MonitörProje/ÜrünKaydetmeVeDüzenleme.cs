using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MonitörProje
{
    public partial class ÜrünKaydetmeVeDüzenleme : Form
    {
        public ÜrünKaydetmeVeDüzenleme()
        {
            InitializeComponent();
        }
        SqlConnection con;


        private void ÜrünKaydetmeVeDüzenleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("server=DESKTOP-93QE84P; Initial Catalog=Monitör;Integrated Security=SSPI");

            try
            {
                con.Open();
                SqlCommand komut2 = new SqlCommand("Insert into ürün_özellik (marka,üretici,ekran_boyutu,fiyat,çözünürlük,yenileme_hizi,stok,agirlik,islemci_sayisi,renk) values ('" + marka.Text + "','" + üretici.Text + "','" + ekranboyutu.Text + "','" + fiyat.Text + "','" + çözünürlük.Text + "','" + yenileme.Text + "','" + stok.Text + "','" + ağırlık.Text + "','" + işlemci.Text + "','" + renk.Text + "')", con);
                komut2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Ürün Başarıyla Eklendi...");
                marka.Text = "";
                üretici.Text = "";
                ekranboyutu.Text = "";
                fiyat.Text = "";
                çözünürlük.Text = "";
                yenileme.Text = "";
                stok.Text = "";
                ağırlık.Text = "";
                işlemci.Text = "";
                renk.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Ekleme Başarısız...");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Düzenle form1 = new Düzenle();
            form1.Show();

        }
    }
}
