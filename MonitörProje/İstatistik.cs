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
    public partial class İstatistik : Form
    {
        public İstatistik()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void İstatistik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("server=DESKTOP-93QE84P; Initial Catalog=Monitör;Integrated Security=SSPI");
            con.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) as sayi from ürün_özellik ", con);

            SqlDataReader rdr = komut2.ExecuteReader();

            while (rdr.Read())
            {
                label7.Text = rdr["sayi"].ToString();
            }

            con.Close();
            con.Open();
            SqlCommand komut3 = new SqlCommand("select TOP 1 renk, count(*) as urun_sayisi from ürün_özellik GROUP BY renk ORDER BY COUNT(*) DESC ", con);

            SqlDataReader kdr = komut3.ExecuteReader();

            while (kdr.Read())
            {
                label8.Text = kdr["renk"].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand komut4 = new SqlCommand("SELECT TOP 1 marka FROM ürün_özellik ORDER BY fiyat DESC ", con);

            SqlDataReader cdr = komut4.ExecuteReader();

            while (cdr.Read())
            {
                label9.Text = cdr["marka"].ToString();
            }
            con.Close();

            con.Open();
            SqlCommand komut5 = new SqlCommand("SELECT TOP 1 marka FROM ürün_özellik ORDER BY fiyat ASC ", con);

            SqlDataReader sdr = komut5.ExecuteReader();

            while (sdr.Read())
            {
                label10.Text = sdr["marka"].ToString();
            }
            con.Close();

            con.Open();
            SqlCommand komut6 = new SqlCommand("SELECT TOP 1 marka, COUNT(*) as urun_sayisi FROM ürün_özellik GROUP BY marka ORDER BY COUNT(*) DESC ", con);

            SqlDataReader zdr = komut6.ExecuteReader();

            while (zdr.Read())
            {
                label11.Text = zdr["marka"].ToString();
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
