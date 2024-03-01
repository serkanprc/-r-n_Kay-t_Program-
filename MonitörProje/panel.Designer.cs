namespace MonitörProje
{
    partial class panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panel));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(128, 116);
            button1.Name = "button1";
            button1.Size = new Size(143, 73);
            button1.TabIndex = 0;
            button1.Text = "Ürün Kaydetme ve Düzenleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 36);
            label1.TabIndex = 4;
            label1.Text = "Yönetim Paneli";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(128, 211);
            button2.Name = "button2";
            button2.Size = new Size(143, 76);
            button2.TabIndex = 6;
            button2.Text = "Ürün Listeleme ve Arama";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(128, 313);
            button4.Name = "button4";
            button4.Size = new Size(143, 73);
            button4.TabIndex = 8;
            button4.Text = "İstatistik";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "panel";
            Text = "panel";
            Load += panel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button4;
        private PictureBox pictureBox1;
    }
}