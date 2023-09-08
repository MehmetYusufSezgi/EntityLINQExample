namespace EntityLINQExample
{
    partial class Form1
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
            this.dgwList = new System.Windows.Forms.DataGridView();
            this.buttonOgrenciListele = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbOgrenciId = new System.Windows.Forms.TextBox();
            this.txbOgrenciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbOgrenciFoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbOrtalama = new System.Windows.Forms.TextBox();
            this.txbSinav1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSinav3 = new System.Windows.Forms.TextBox();
            this.txbSinav2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDersId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDersAd = new System.Windows.Forms.TextBox();
            this.txbDurum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDersListe = new System.Windows.Forms.Button();
            this.buttonNotListele = new System.Windows.Forms.Button();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.buttonNotGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwList
            // 
            this.dgwList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Location = new System.Drawing.Point(0, 0);
            this.dgwList.Name = "dgwList";
            this.dgwList.Size = new System.Drawing.Size(844, 150);
            this.dgwList.TabIndex = 0;
            this.dgwList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonOgrenciListele
            // 
            this.buttonOgrenciListele.Location = new System.Drawing.Point(0, 156);
            this.buttonOgrenciListele.Name = "buttonOgrenciListele";
            this.buttonOgrenciListele.Size = new System.Drawing.Size(204, 30);
            this.buttonOgrenciListele.TabIndex = 1;
            this.buttonOgrenciListele.Text = "Öğrenci Listele";
            this.buttonOgrenciListele.UseVisualStyleBackColor = true;
            this.buttonOgrenciListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(0, 265);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(204, 30);
            this.buttonKaydet.TabIndex = 2;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(0, 302);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(204, 30);
            this.buttonSil.TabIndex = 3;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(0, 336);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(204, 30);
            this.buttonGuncelle.TabIndex = 4;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            // 
            // buttonBul
            // 
            this.buttonBul.Location = new System.Drawing.Point(0, 372);
            this.buttonBul.Name = "buttonBul";
            this.buttonBul.Size = new System.Drawing.Size(204, 30);
            this.buttonBul.TabIndex = 5;
            this.buttonBul.Text = "Bul";
            this.buttonBul.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbOgrenciId
            // 
            this.txbOgrenciId.Location = new System.Drawing.Point(90, 25);
            this.txbOgrenciId.Name = "txbOgrenciId";
            this.txbOgrenciId.Size = new System.Drawing.Size(143, 20);
            this.txbOgrenciId.TabIndex = 7;
            // 
            // txbOgrenciAd
            // 
            this.txbOgrenciAd.Location = new System.Drawing.Point(90, 56);
            this.txbOgrenciAd.Name = "txbOgrenciAd";
            this.txbOgrenciAd.Size = new System.Drawing.Size(143, 20);
            this.txbOgrenciAd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad : ";
            // 
            // txbOgrenciSoyad
            // 
            this.txbOgrenciSoyad.Location = new System.Drawing.Point(90, 88);
            this.txbOgrenciSoyad.Name = "txbOgrenciSoyad";
            this.txbOgrenciSoyad.Size = new System.Drawing.Size(143, 20);
            this.txbOgrenciSoyad.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soyad : ";
            // 
            // txbOgrenciFoto
            // 
            this.txbOgrenciFoto.Location = new System.Drawing.Point(90, 119);
            this.txbOgrenciFoto.Name = "txbOgrenciFoto";
            this.txbOgrenciFoto.Size = new System.Drawing.Size(143, 20);
            this.txbOgrenciFoto.TabIndex = 13;
            this.txbOgrenciFoto.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fotoğraf : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbOgrenciFoto);
            this.groupBox1.Controls.Add(this.txbOgrenciId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbOgrenciSoyad);
            this.groupBox1.Controls.Add(this.txbOgrenciAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(210, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 148);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNotGuncelle);
            this.groupBox2.Controls.Add(this.buttonHesapla);
            this.groupBox2.Controls.Add(this.txbDurum);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbOrtalama);
            this.groupBox2.Controls.Add(this.txbSinav1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbSinav3);
            this.groupBox2.Controls.Add(this.txbSinav2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(487, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 246);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sınav 1 : ";
            // 
            // txbOrtalama
            // 
            this.txbOrtalama.Location = new System.Drawing.Point(85, 119);
            this.txbOrtalama.Name = "txbOrtalama";
            this.txbOrtalama.Size = new System.Drawing.Size(191, 20);
            this.txbOrtalama.TabIndex = 13;
            // 
            // txbSinav1
            // 
            this.txbSinav1.Location = new System.Drawing.Point(85, 25);
            this.txbSinav1.Name = "txbSinav1";
            this.txbSinav1.Size = new System.Drawing.Size(191, 20);
            this.txbSinav1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ortalama  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sınav 2 : ";
            // 
            // txbSinav3
            // 
            this.txbSinav3.Location = new System.Drawing.Point(85, 88);
            this.txbSinav3.Name = "txbSinav3";
            this.txbSinav3.Size = new System.Drawing.Size(191, 20);
            this.txbSinav3.TabIndex = 11;
            // 
            // txbSinav2
            // 
            this.txbSinav2.Location = new System.Drawing.Point(85, 56);
            this.txbSinav2.Name = "txbSinav2";
            this.txbSinav2.Size = new System.Drawing.Size(191, 20);
            this.txbSinav2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sınav 3 : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txbDersId);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txbDersAd);
            this.groupBox3.Location = new System.Drawing.Point(210, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 92);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ders";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "ID : ";
            // 
            // txbDersId
            // 
            this.txbDersId.Location = new System.Drawing.Point(85, 19);
            this.txbDersId.Name = "txbDersId";
            this.txbDersId.Size = new System.Drawing.Size(148, 20);
            this.txbDersId.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ad : ";
            // 
            // txbDersAd
            // 
            this.txbDersAd.Location = new System.Drawing.Point(85, 50);
            this.txbDersAd.Name = "txbDersAd";
            this.txbDersAd.Size = new System.Drawing.Size(148, 20);
            this.txbDersAd.TabIndex = 13;
            // 
            // txbDurum
            // 
            this.txbDurum.Location = new System.Drawing.Point(85, 145);
            this.txbDurum.Name = "txbDurum";
            this.txbDurum.Size = new System.Drawing.Size(191, 20);
            this.txbDurum.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Durum : ";
            // 
            // buttonDersListe
            // 
            this.buttonDersListe.Location = new System.Drawing.Point(0, 192);
            this.buttonDersListe.Name = "buttonDersListe";
            this.buttonDersListe.Size = new System.Drawing.Size(204, 30);
            this.buttonDersListe.TabIndex = 17;
            this.buttonDersListe.Text = "Ders Listele";
            this.buttonDersListe.UseVisualStyleBackColor = true;
            this.buttonDersListe.Click += new System.EventHandler(this.buttonDersListe_Click);
            // 
            // buttonNotListele
            // 
            this.buttonNotListele.Location = new System.Drawing.Point(0, 228);
            this.buttonNotListele.Name = "buttonNotListele";
            this.buttonNotListele.Size = new System.Drawing.Size(204, 30);
            this.buttonNotListele.TabIndex = 18;
            this.buttonNotListele.Text = "Not Listele";
            this.buttonNotListele.UseVisualStyleBackColor = true;
            this.buttonNotListele.Click += new System.EventHandler(this.buttonNotListele_Click);
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(72, 173);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(204, 30);
            this.buttonHesapla.TabIndex = 16;
            this.buttonHesapla.Text = "Ortalama Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            // 
            // buttonNotGuncelle
            // 
            this.buttonNotGuncelle.Location = new System.Drawing.Point(72, 207);
            this.buttonNotGuncelle.Name = "buttonNotGuncelle";
            this.buttonNotGuncelle.Size = new System.Drawing.Size(204, 30);
            this.buttonNotGuncelle.TabIndex = 17;
            this.buttonNotGuncelle.Text = "Sınav Notu Güncelle";
            this.buttonNotGuncelle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 414);
            this.Controls.Add(this.buttonNotListele);
            this.Controls.Add(this.buttonDersListe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBul);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.buttonOgrenciListele);
            this.Controls.Add(this.dgwList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwList;
        private System.Windows.Forms.Button buttonOgrenciListele;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbOgrenciId;
        private System.Windows.Forms.TextBox txbOgrenciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbOgrenciSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbOgrenciFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbOrtalama;
        private System.Windows.Forms.TextBox txbSinav1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSinav3;
        private System.Windows.Forms.TextBox txbSinav2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDersId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDersAd;
        private System.Windows.Forms.TextBox txbDurum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDersListe;
        private System.Windows.Forms.Button buttonNotListele;
        private System.Windows.Forms.Button buttonNotGuncelle;
        private System.Windows.Forms.Button buttonHesapla;
    }
}

