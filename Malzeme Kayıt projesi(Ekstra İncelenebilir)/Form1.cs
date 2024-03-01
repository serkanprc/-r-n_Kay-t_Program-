using System.Data.SqlClient;

namespace Malzeme_Kayıt_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con;
        void griddoldur()
        {
            try
            {

                con = new SqlConnection("server=DESKTOP-93QE84P; Initial Catalog=malzemeler;Integrated Security=SSPI");
                listView1.Items.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from kayitlar", con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listView1.Items.Add(rdr["StokKodu"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["StokAdi"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["MevcutStok"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["Birim"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["MinStok"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(rdr["MaxStok"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut2 = new SqlCommand("Insert into kayitlar (StokKodu,StokAdi,MevcutStok,Birim,MinStok,MaxStok) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
            komut2.ExecuteNonQuery();
            con.Close();
            button1.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Adet");
            comboBox1.Items.Add("Gram");
            button1.PerformClick();
        }
        int kod = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            kod = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut3 = new SqlCommand("Delete from kayitlar where StokKodu=(" + kod + ")", con);
            komut3.ExecuteNonQuery();
            con.Close();
            button1.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut4 = new SqlCommand("Update kayitlar set StokKodu='" + textBox1.Text.ToString() +
                "'," + "StokAdi='" + textBox2.Text.ToString() + "',MevcutStok='" + textBox3.Text.ToString() + "'," +
                "Birim='" + comboBox1.Text.ToString() + "',MinStok='" + textBox5.Text.ToString() + "'," +
                 "MaxStok='" + textBox6.Text.ToString() + "'where StokKodu='" + kod + "'", con);
            komut4.ExecuteNonQuery();
            con.Close();
            button1.PerformClick();

        }
    }
}