namespace MonitörProje
{
    partial class KullaniciGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(331, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 41);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Giriş";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 150);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 31);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(179, 262);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(277, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(277, 264);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '·';
            textBox2.Size = new Size(167, 29);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(639, 390);
            button1.Name = "button1";
            button1.Size = new Size(167, 62);
            button1.TabIndex = 5;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(572, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // KullaniciGiris
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(892, 477);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 6, 7, 6);
            Name = "KullaniciGiris";
            Text = "Form1";
            Load += KullaniciGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}