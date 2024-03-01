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
    public partial class ÜrünListelemeVeArama : Form
    {
        public ÜrünListelemeVeArama()
        {
            InitializeComponent();
        }
        SqlConnection con;
        void griddoldur()
        {
            try
            {

                con = new SqlConnection("server=DESKTOP-93QE84P; Initial Catalog=Monitör;Integrated Security=SSPI");
                listView1.Items.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from ürün_özellik", con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listView1.Items.Add(rdr["id"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["marka"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["üretici"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["ekran_boyutu"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["fiyat"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["çözünürlük"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["yenileme_hizi"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["stok"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["agirlik"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["islemci_sayisi"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["renk"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ÜrünListelemeVeArama_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from ürün_özellik where " + comboBox1.SelectedItem.ToString() + " LIKE '%" + textBox1.Text.ToString() + "%'", con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listView1.Items.Add(rdr["id"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["marka"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["üretici"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["ekran_boyutu"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["fiyat"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["çözünürlük"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["yenileme_hizi"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["stok"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["agirlik"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["islemci_sayisi"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["renk"].ToString());
            }
            con.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ÜrünListelemeVeArama_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
