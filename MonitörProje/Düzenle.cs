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
    public partial class Düzenle : Form
    {
        public Düzenle()
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

        private void Düzenle_Load(object sender, EventArgs e)
        {
            griddoldur();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int kod = 0;

        void okuma()
        {
            kod = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            textBox11.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox9.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox10.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            okuma();

        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                SqlCommand komut4 = new SqlCommand("Update ürün_özellik set marka='" + textBox1.Text.ToString() +
                    "'," + "üretici='" + textBox2.Text.ToString() + "',ekran_boyutu='" + textBox3.Text.ToString() + "'," +
                    "fiyat='" + textBox4.Text.ToString() + "',çözünürlük='" + textBox5.Text.ToString() + "'," +
                     "yenileme_hizi='" + textBox6.Text.ToString() + "',stok='" + textBox7.Text.ToString() +
                     "',agirlik='" + textBox8.Text.ToString() + "',islemci_sayisi='" + textBox9.Text.ToString() +
                     "',renk='" + textBox10.Text.ToString() + "'where id='" + textBox11.Text.ToString() + "'", con);

                komut4.ExecuteNonQuery();
   
                con.Close();
                MessageBox.Show("Güncelleme Başarılı...");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                
                griddoldur();
               



            }

            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Başarısız...");

            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand komut3 = new SqlCommand("Delete from ürün_özellik where id=(" + textBox11.Text + ")", con);
                komut3.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Ürün Silme Başarılı...");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ürün Silme Başarısız...");
            }
          
        }
    }
}
