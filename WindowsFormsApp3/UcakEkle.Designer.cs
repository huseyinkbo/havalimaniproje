namespace WindowsFormsApp3
{
    partial class UcakEkle
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelsecim = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxUcakID = new System.Windows.Forms.TextBox();
            this.tBoxUcakAd = new System.Windows.Forms.TextBox();
            this.tBoxHavayoluID = new System.Windows.Forms.TextBox();
            this.tboxKoltukSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxUcakTuru = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.tboxGuncelleKoltukSayisi = new System.Windows.Forms.TextBox();
            this.tboxGuncelleUcakTuru = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tboxGuncelleUcakAdi = new System.Windows.Forms.TextBox();
            this.tboxGuncelleHavayoluID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Uçak Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Uçak Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelsecim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(394, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uçak Sil";
            // 
            // labelsecim
            // 
            this.labelsecim.AutoSize = true;
            this.labelsecim.Location = new System.Drawing.Point(117, 83);
            this.labelsecim.Name = "labelsecim";
            this.labelsecim.Size = new System.Drawing.Size(0, 17);
            this.labelsecim.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Seçtiğiniz Ucak ID";
            // 
            // tboxUcakID
            // 
            this.tboxUcakID.Location = new System.Drawing.Point(118, 36);
            this.tboxUcakID.Name = "tboxUcakID";
            this.tboxUcakID.Size = new System.Drawing.Size(121, 22);
            this.tboxUcakID.TabIndex = 3;
            // 
            // tBoxUcakAd
            // 
            this.tBoxUcakAd.Location = new System.Drawing.Point(118, 64);
            this.tBoxUcakAd.Name = "tBoxUcakAd";
            this.tBoxUcakAd.Size = new System.Drawing.Size(121, 22);
            this.tBoxUcakAd.TabIndex = 4;
            // 
            // tBoxHavayoluID
            // 
            this.tBoxHavayoluID.Location = new System.Drawing.Point(118, 92);
            this.tBoxHavayoluID.Name = "tBoxHavayoluID";
            this.tBoxHavayoluID.Size = new System.Drawing.Size(121, 22);
            this.tBoxHavayoluID.TabIndex = 5;
            // 
            // tboxKoltukSayisi
            // 
            this.tboxKoltukSayisi.Location = new System.Drawing.Point(118, 120);
            this.tboxKoltukSayisi.Name = "tboxKoltukSayisi";
            this.tboxKoltukSayisi.Size = new System.Drawing.Size(121, 22);
            this.tboxKoltukSayisi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ucak ID =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ucak Adi =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Havayolu_id =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Koltuk Sayisi =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Uçak Türü =";
            // 
            // cboxUcakTuru
            // 
            this.cboxUcakTuru.FormattingEnabled = true;
            this.cboxUcakTuru.Items.AddRange(new object[] {
            "Askeri Uçak",
            "Yolcu Uçağı"});
            this.cboxUcakTuru.Location = new System.Drawing.Point(118, 148);
            this.cboxUcakTuru.Name = "cboxUcakTuru";
            this.cboxUcakTuru.Size = new System.Drawing.Size(121, 24);
            this.cboxUcakTuru.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(878, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 50);
            this.button3.TabIndex = 14;
            this.button3.Text = "Personel Anasayfasına Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(878, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 50);
            this.button4.TabIndex = 15;
            this.button4.Text = "Çıkış Yap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxUcakTuru);
            this.groupBox2.Controls.Add(this.tboxUcakID);
            this.groupBox2.Controls.Add(this.tBoxUcakAd);
            this.groupBox2.Controls.Add(this.tBoxHavayoluID);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tboxKoltukSayisi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 198);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uçak Ekle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-37, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(888, 225);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.labelID);
            this.groupBox3.Controls.Add(this.tboxGuncelleKoltukSayisi);
            this.groupBox3.Controls.Add(this.tboxGuncelleUcakTuru);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.tboxGuncelleUcakAdi);
            this.groupBox3.Controls.Add(this.tboxGuncelleHavayoluID);
            this.groupBox3.Location = new System.Drawing.Point(682, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 206);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uçak Güncelleme";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Seçtiğiniz Uçak ID";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(257, 172);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 17);
            this.labelID.TabIndex = 31;
            // 
            // tboxGuncelleKoltukSayisi
            // 
            this.tboxGuncelleKoltukSayisi.Location = new System.Drawing.Point(173, 31);
            this.tboxGuncelleKoltukSayisi.Name = "tboxGuncelleKoltukSayisi";
            this.tboxGuncelleKoltukSayisi.Size = new System.Drawing.Size(121, 22);
            this.tboxGuncelleKoltukSayisi.TabIndex = 27;
            // 
            // tboxGuncelleUcakTuru
            // 
            this.tboxGuncelleUcakTuru.Location = new System.Drawing.Point(173, 58);
            this.tboxGuncelleUcakTuru.Name = "tboxGuncelleUcakTuru";
            this.tboxGuncelleUcakTuru.Size = new System.Drawing.Size(121, 22);
            this.tboxGuncelleUcakTuru.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 40);
            this.button5.TabIndex = 25;
            this.button5.Text = "Uçak Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tboxGuncelleUcakAdi
            // 
            this.tboxGuncelleUcakAdi.Location = new System.Drawing.Point(38, 31);
            this.tboxGuncelleUcakAdi.Name = "tboxGuncelleUcakAdi";
            this.tboxGuncelleUcakAdi.Size = new System.Drawing.Size(113, 22);
            this.tboxGuncelleUcakAdi.TabIndex = 6;
            // 
            // tboxGuncelleHavayoluID
            // 
            this.tboxGuncelleHavayoluID.Location = new System.Drawing.Point(38, 59);
            this.tboxGuncelleHavayoluID.Name = "tboxGuncelleHavayoluID";
            this.tboxGuncelleHavayoluID.Size = new System.Drawing.Size(113, 22);
            this.tboxGuncelleHavayoluID.TabIndex = 8;
            // 
            // UcakEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1039, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UcakEkle";
            this.Text = "UcakEkle";
            this.Load += new System.EventHandler(this.UcakEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxUcakID;
        private System.Windows.Forms.TextBox tBoxUcakAd;
        private System.Windows.Forms.TextBox tBoxHavayoluID;
        private System.Windows.Forms.TextBox tboxKoltukSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxUcakTuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelsecim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox tboxGuncelleKoltukSayisi;
        private System.Windows.Forms.TextBox tboxGuncelleUcakTuru;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tboxGuncelleUcakAdi;
        private System.Windows.Forms.TextBox tboxGuncelleHavayoluID;
    }
}