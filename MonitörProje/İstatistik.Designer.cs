﻿namespace MonitörProje
{
    partial class İstatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İstatistik));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 140);
            label1.Name = "label1";
            label1.Size = new Size(173, 23);
            label1.TabIndex = 0;
            label1.Text = "Toplam Ürün Sayısı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 187);
            label2.Name = "label2";
            label2.Size = new Size(239, 23);
            label2.TabIndex = 1;
            label2.Text = "En Çok Tercih Edilen Renk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 235);
            label3.Name = "label3";
            label3.Size = new Size(234, 23);
            label3.TabIndex = 2;
            label3.Text = "En Pahalı Ürünün Markası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 289);
            label4.Name = "label4";
            label4.Size = new Size(225, 23);
            label4.TabIndex = 3;
            label4.Text = "En Ucuz Ürünün Markası";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 338);
            label5.Name = "label5";
            label5.Size = new Size(251, 23);
            label5.TabIndex = 4;
            label5.Text = "En Çok Tercih Edilen Marka";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 140);
            label7.Name = "label7";
            label7.Size = new Size(0, 23);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(336, 187);
            label8.Name = "label8";
            label8.Size = new Size(0, 23);
            label8.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(336, 235);
            label9.Name = "label9";
            label9.Size = new Size(0, 23);
            label9.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(336, 289);
            label10.Name = "label10";
            label10.Size = new Size(0, 23);
            label10.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(336, 338);
            label11.Name = "label11";
            label11.Size = new Size(0, 23);
            label11.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(189, 408);
            button1.Name = "button1";
            button1.Size = new Size(128, 88);
            button1.TabIndex = 12;
            button1.Text = "İstatistikleri Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(593, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 385);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(392, 9);
            label13.Name = "label13";
            label13.Size = new Size(209, 43);
            label13.TabIndex = 14;
            label13.Text = "İstatistikler";
            // 
            // İstatistik
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1371, 690);
            Controls.Add(label13);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "İstatistik";
            Text = "İstatistik";
            Load += İstatistik_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label13;
    }
}