namespace VideoMarketPortalim
{
    partial class FrmFilmSatisIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilmSatisIslemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.txtFilmAra = new System.Windows.Forms.TextBox();
            this.btnMusteriAra = new System.Windows.Forms.Button();
            this.btnFilmAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.lsvSatislar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtFilmNo = new System.Windows.Forms.TextBox();
            this.txtSatisNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film:";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(83, 5);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(116, 20);
            this.txtTarih.TabIndex = 3;
            this.txtTarih.TextChanged += new System.EventHandler(this.txtTarih_TextChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(204, 5);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(12, 20);
            this.dtpTarih.TabIndex = 4;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(83, 47);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(116, 20);
            this.txtMusteriAra.TabIndex = 5;
            // 
            // txtFilmAra
            // 
            this.txtFilmAra.Location = new System.Drawing.Point(83, 93);
            this.txtFilmAra.Name = "txtFilmAra";
            this.txtFilmAra.Size = new System.Drawing.Size(116, 20);
            this.txtFilmAra.TabIndex = 6;
            // 
            // btnMusteriAra
            // 
            this.btnMusteriAra.Location = new System.Drawing.Point(204, 45);
            this.btnMusteriAra.Name = "btnMusteriAra";
            this.btnMusteriAra.Size = new System.Drawing.Size(62, 23);
            this.btnMusteriAra.TabIndex = 7;
            this.btnMusteriAra.Text = "...";
            this.btnMusteriAra.UseVisualStyleBackColor = true;
            this.btnMusteriAra.Click += new System.EventHandler(this.btnMusteriAra_Click);
            // 
            // btnFilmAra
            // 
            this.btnFilmAra.Location = new System.Drawing.Point(204, 91);
            this.btnFilmAra.Name = "btnFilmAra";
            this.btnFilmAra.Size = new System.Drawing.Size(62, 23);
            this.btnFilmAra.TabIndex = 8;
            this.btnFilmAra.Text = "...";
            this.btnFilmAra.UseVisualStyleBackColor = true;
            this.btnFilmAra.Click += new System.EventHandler(this.btnFilmAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(463, 144);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(59, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(391, 144);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(66, 23);
            this.btnDegistir.TabIndex = 11;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(317, 144);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(67, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeni.Location = new System.Drawing.Point(11, 144);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(64, 23);
            this.btnYeni.TabIndex = 9;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lsvSatislar
            // 
            this.lsvSatislar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lsvSatislar.FullRowSelect = true;
            this.lsvSatislar.GridLines = true;
            this.lsvSatislar.Location = new System.Drawing.Point(2, 180);
            this.lsvSatislar.Name = "lsvSatislar";
            this.lsvSatislar.Size = new System.Drawing.Size(521, 253);
            this.lsvSatislar.TabIndex = 13;
            this.lsvSatislar.UseCompatibleStateImageBehavior = false;
            this.lsvSatislar.View = System.Windows.Forms.View.Details;
            this.lsvSatislar.SelectedIndexChanged += new System.EventHandler(this.lsvSatislar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SatisNo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IslemTarihi";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Musteri";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FilmAdi";
            this.columnHeader4.Width = 54;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 69;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "BirimFiyat";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 109;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tutar";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 105;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "MusteriNo";
            this.columnHeader8.Width = 1;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "FilmNo";
            this.columnHeader9.Width = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adet:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(83, 147);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(72, 20);
            this.txtAdet.TabIndex = 15;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(161, 146);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(71, 20);
            this.txtFiyat.TabIndex = 17;
            this.txtFiyat.TextChanged += new System.EventHandler(this.txtFiyat_TextChanged);
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fiyat:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(238, 146);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(73, 20);
            this.txtTutar.TabIndex = 19;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tutar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Toplam Adet:";
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(195, 439);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.Size = new System.Drawing.Size(100, 20);
            this.txtToplamAdet.TabIndex = 21;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(418, 439);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 20);
            this.txtToplamTutar.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Toplam Tutar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(71, 48);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.ReadOnly = true;
            this.txtMusteriNo.Size = new System.Drawing.Size(10, 20);
            this.txtMusteriNo.TabIndex = 25;
            this.txtMusteriNo.Visible = false;
            // 
            // txtFilmNo
            // 
            this.txtFilmNo.Location = new System.Drawing.Point(71, 93);
            this.txtFilmNo.Name = "txtFilmNo";
            this.txtFilmNo.ReadOnly = true;
            this.txtFilmNo.Size = new System.Drawing.Size(10, 20);
            this.txtFilmNo.TabIndex = 26;
            this.txtFilmNo.Visible = false;
            // 
            // txtSatisNo
            // 
            this.txtSatisNo.Location = new System.Drawing.Point(71, 5);
            this.txtSatisNo.Name = "txtSatisNo";
            this.txtSatisNo.ReadOnly = true;
            this.txtSatisNo.Size = new System.Drawing.Size(10, 20);
            this.txtSatisNo.TabIndex = 27;
            this.txtSatisNo.Visible = false;
            // 
            // FrmFilmSatisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(524, 465);
            this.Controls.Add(this.txtSatisNo);
            this.Controls.Add(this.txtFilmNo);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsvSatislar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnFilmAra);
            this.Controls.Add(this.btnMusteriAra);
            this.Controls.Add(this.txtFilmAra);
            this.Controls.Add(this.txtMusteriAra);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmFilmSatisIslemleri";
            this.Text = "FrmFilmSatisIslemleri";
            this.Load += new System.EventHandler(this.FrmFilmSatisIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.TextBox txtFilmAra;
        private System.Windows.Forms.Button btnMusteriAra;
        private System.Windows.Forms.Button btnFilmAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ListView lsvSatislar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtFilmNo;
        private System.Windows.Forms.TextBox txtSatisNo;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}