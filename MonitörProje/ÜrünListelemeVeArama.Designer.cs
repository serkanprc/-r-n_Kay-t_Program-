namespace MonitörProje
{
    partial class ÜrünListelemeVeArama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜrünListelemeVeArama));
            label1 = new Label();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            button1 = new Button();
            ımageList1 = new ImageList(components);
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(207, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(393, 38);
            label1.TabIndex = 12;
            label1.Text = "Ürün Listeleme ve Arama";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(528, 67);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ara";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 13;
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Location = new Point(75, 110);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(667, 298);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "İd";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "marka";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "üretici";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ekran_boyutu";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "fiyat";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "çözünürlük";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "yenileme_hizi";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "stok";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "agirlik";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "islemci_sayisi";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "renk";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(716, 67);
            button1.Name = "button1";
            button1.Size = new Size(26, 23);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageSize = new Size(16, 16);
            ımageList1.TransparentColor = Color.Transparent;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "agirlik", "çözünürlük", "ekran_boyutu", "fiyat", "islemci_sayisi", "marka", "renk", "stok", "üretici", "yenileme_hizi" });
            comboBox1.Location = new Point(386, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ÜrünListelemeVeArama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ÜrünListelemeVeArama";
            Text = "ÜrünListelemeVeArama";
            Load += ÜrünListelemeVeArama_Load;
            DoubleClick += ÜrünListelemeVeArama_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button button1;
        private ImageList ımageList1;
        private ComboBox comboBox1;
        private ListView listView1;
    }
}