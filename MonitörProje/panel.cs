using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitörProje
{
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
        }

        private void panel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÜrünKaydetmeVeDüzenleme form = new ÜrünKaydetmeVeDüzenleme();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜrünListelemeVeArama form2 = new ÜrünListelemeVeArama();
            form2.Show();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            İstatistik form1 = new İstatistik();
            form1.Show();
            
        }
    }
}
