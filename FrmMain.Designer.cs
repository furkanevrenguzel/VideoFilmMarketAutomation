namespace VideoMarketPortalim
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuAnaSayfa = new System.Windows.Forms.MenuStrip();
            this.mFilmler = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemFilmTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemFilmSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFilmTurleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemFilmTuruTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMusteriler = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemMusteriKarti = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemMusteriSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSatislar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemFilmSatisIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemSatisSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lnkBilgi = new System.Windows.Forms.LinkLabel();
            this.mnuAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnaSayfa
            // 
            this.mnuAnaSayfa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFilmler,
            this.mnFilmTurleri,
            this.mnMusteriler,
            this.mnSatislar,
            this.mnCikis});
            this.mnuAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnaSayfa.Name = "mnuAnaSayfa";
            this.mnuAnaSayfa.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuAnaSayfa.Size = new System.Drawing.Size(849, 24);
            this.mnuAnaSayfa.TabIndex = 0;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // mFilmler
            // 
            this.mFilmler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemFilmTanimlama,
            this.mnItemFilmSorgulama});
            this.mFilmler.Name = "mFilmler";
            this.mFilmler.Size = new System.Drawing.Size(65, 20);
            this.mFilmler.Text = "Filmler";
            // 
            // mnItemFilmTanimlama
            // 
            this.mnItemFilmTanimlama.Name = "mnItemFilmTanimlama";
            this.mnItemFilmTanimlama.Size = new System.Drawing.Size(174, 22);
            this.mnItemFilmTanimlama.Text = "FilmTanımlama";
            this.mnItemFilmTanimlama.Click += new System.EventHandler(this.mnItemFilmTanimlama_Click);
            // 
            // mnItemFilmSorgulama
            // 
            this.mnItemFilmSorgulama.Name = "mnItemFilmSorgulama";
            this.mnItemFilmSorgulama.Size = new System.Drawing.Size(174, 22);
            this.mnItemFilmSorgulama.Text = "FilmSorgulama";
            this.mnItemFilmSorgulama.Click += new System.EventHandler(this.mnItemFilmSorgulama_Click);
            // 
            // mnFilmTurleri
            // 
            this.mnFilmTurleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemFilmTuruTanimlama});
            this.mnFilmTurleri.Name = "mnFilmTurleri";
            this.mnFilmTurleri.Size = new System.Drawing.Size(91, 20);
            this.mnFilmTurleri.Text = "FilmTürleri";
            // 
            // mnItemFilmTuruTanimlama
            // 
            this.mnItemFilmTuruTanimlama.Name = "mnItemFilmTuruTanimlama";
            this.mnItemFilmTuruTanimlama.Size = new System.Drawing.Size(204, 22);
            this.mnItemFilmTuruTanimlama.Text = "FilmTürüTanımlama";
            this.mnItemFilmTuruTanimlama.Click += new System.EventHandler(this.mnItemFilmTuruTanimlama_Click);
            // 
            // mnMusteriler
            // 
            this.mnMusteriler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemMusteriKarti,
            this.mnItemMusteriSorgulama});
            this.mnMusteriler.Name = "mnMusteriler";
            this.mnMusteriler.Size = new System.Drawing.Size(84, 20);
            this.mnMusteriler.Text = "Müşteriler";
            this.mnMusteriler.Click += new System.EventHandler(this.mnMusteriler_Click);
            // 
            // mnItemMusteriKarti
            // 
            this.mnItemMusteriKarti.Name = "mnItemMusteriKarti";
            this.mnItemMusteriKarti.Size = new System.Drawing.Size(192, 22);
            this.mnItemMusteriKarti.Text = "MüşteriKartı";
            this.mnItemMusteriKarti.Click += new System.EventHandler(this.mnItemMusteriKarti_Click);
            // 
            // mnItemMusteriSorgulama
            // 
            this.mnItemMusteriSorgulama.Name = "mnItemMusteriSorgulama";
            this.mnItemMusteriSorgulama.Size = new System.Drawing.Size(192, 22);
            this.mnItemMusteriSorgulama.Text = "MüşteriSorgulama";
            this.mnItemMusteriSorgulama.Click += new System.EventHandler(this.mnItemMusteriSorgulama_Click);
            // 
            // mnSatislar
            // 
            this.mnSatislar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemFilmSatisIslemleri,
            this.mnItemSatisSorgulama});
            this.mnSatislar.Name = "mnSatislar";
            this.mnSatislar.Size = new System.Drawing.Size(68, 20);
            this.mnSatislar.Text = "Satışlar";
            // 
            // mnItemFilmSatisIslemleri
            // 
            this.mnItemFilmSatisIslemleri.Name = "mnItemFilmSatisIslemleri";
            this.mnItemFilmSatisIslemleri.Size = new System.Drawing.Size(187, 22);
            this.mnItemFilmSatisIslemleri.Text = "FilmSatışİşlemleri";
            this.mnItemFilmSatisIslemleri.Click += new System.EventHandler(this.mnItemFilmSatisIslemleri_Click);
            // 
            // mnItemSatisSorgulama
            // 
            this.mnItemSatisSorgulama.Name = "mnItemSatisSorgulama";
            this.mnItemSatisSorgulama.Size = new System.Drawing.Size(187, 22);
            this.mnItemSatisSorgulama.Text = "SatışSorgulama";
            this.mnItemSatisSorgulama.Click += new System.EventHandler(this.mnItemSatisSorgulama_Click);
            // 
            // mnCikis
            // 
            this.mnCikis.Name = "mnCikis";
            this.mnCikis.Size = new System.Drawing.Size(49, 20);
            this.mnCikis.Text = "Çıkış";
            this.mnCikis.Click += new System.EventHandler(this.mnCikis_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lnkBilgi
            // 
            this.lnkBilgi.AutoSize = true;
            this.lnkBilgi.Location = new System.Drawing.Point(367, 9);
            this.lnkBilgi.Name = "lnkBilgi";
            this.lnkBilgi.Size = new System.Drawing.Size(182, 15);
            this.lnkBilgi.TabIndex = 2;
            this.lnkBilgi.TabStop = true;
            this.lnkBilgi.Text = "Detaylı Bilgi/Soru/Görüş/Öneri";
            this.lnkBilgi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBilgi_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 501);
            this.Controls.Add(this.lnkBilgi);
            this.Controls.Add(this.mnuAnaSayfa);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnaSayfa;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = " F. Evren Güzel Video Market Uygulaması  Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuAnaSayfa.ResumeLayout(false);
            this.mnuAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem mFilmler;
        private System.Windows.Forms.ToolStripMenuItem mnFilmTurleri;
        private System.Windows.Forms.ToolStripMenuItem mnMusteriler;
        private System.Windows.Forms.ToolStripMenuItem mnSatislar;
        private System.Windows.Forms.ToolStripMenuItem mnCikis;
        private System.Windows.Forms.ToolStripMenuItem mnItemFilmTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mnItemFilmSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mnItemFilmTuruTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mnItemMusteriKarti;
        private System.Windows.Forms.ToolStripMenuItem mnItemMusteriSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mnItemFilmSatisIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mnItemSatisSorgulama;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel lnkBilgi;
    }
}