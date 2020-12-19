namespace VideoMarketPortalim
{
    partial class FrmFilmSorgula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilmSorgula));
            this.lsvFilmler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFilmAdinaGore = new System.Windows.Forms.TextBox();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.txtYonetmeneGore = new System.Windows.Forms.TextBox();
            this.txtOyuncuyaGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvFilmler
            // 
            this.lsvFilmler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9});
            this.lsvFilmler.FullRowSelect = true;
            this.lsvFilmler.GridLines = true;
            this.lsvFilmler.Location = new System.Drawing.Point(3, 195);
            this.lsvFilmler.Name = "lsvFilmler";
            this.lsvFilmler.Size = new System.Drawing.Size(576, 224);
            this.lsvFilmler.TabIndex = 0;
            this.lsvFilmler.UseCompatibleStateImageBehavior = false;
            this.lsvFilmler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FilmAdi";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FilmTürü";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yönetmen";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Oyuncular";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Özet";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Miktar";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TurNo";
            this.columnHeader8.Width = 1;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "FilmNo";
            this.columnHeader9.Width = 1;
            // 
            // txtFilmAdinaGore
            // 
            this.txtFilmAdinaGore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtFilmAdinaGore.Location = new System.Drawing.Point(3, 195);
            this.txtFilmAdinaGore.Name = "txtFilmAdinaGore";
            this.txtFilmAdinaGore.Size = new System.Drawing.Size(89, 20);
            this.txtFilmAdinaGore.TabIndex = 1;
            this.txtFilmAdinaGore.TextChanged += new System.EventHandler(this.txtFilmAdinaGore_TextChanged);
            this.txtFilmAdinaGore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilmAdinaGore_KeyPress);
            // 
            // cmbTurler
            // 
            this.cmbTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(98, 195);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(105, 21);
            this.cmbTurler.TabIndex = 2;
            this.cmbTurler.SelectedIndexChanged += new System.EventHandler(this.cmbTurler_SelectedIndexChanged);
            // 
            // txtYonetmeneGore
            // 
            this.txtYonetmeneGore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtYonetmeneGore.Location = new System.Drawing.Point(209, 195);
            this.txtYonetmeneGore.Name = "txtYonetmeneGore";
            this.txtYonetmeneGore.Size = new System.Drawing.Size(97, 20);
            this.txtYonetmeneGore.TabIndex = 3;
            this.txtYonetmeneGore.TextChanged += new System.EventHandler(this.txtYonetmeneGore_TextChanged);
            this.txtYonetmeneGore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYonetmeneGore_KeyPress);
            // 
            // txtOyuncuyaGore
            // 
            this.txtOyuncuyaGore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtOyuncuyaGore.Location = new System.Drawing.Point(312, 195);
            this.txtOyuncuyaGore.Name = "txtOyuncuyaGore";
            this.txtOyuncuyaGore.Size = new System.Drawing.Size(100, 20);
            this.txtOyuncuyaGore.TabIndex = 4;
            this.txtOyuncuyaGore.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtOyuncuyaGore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOyuncuyaGore_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Film Adına Göre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Film Türüne Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(206, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yönetmene  Göre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(310, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oyunculara Göre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFilmSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(583, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOyuncuyaGore);
            this.Controls.Add(this.txtYonetmeneGore);
            this.Controls.Add(this.cmbTurler);
            this.Controls.Add(this.txtFilmAdinaGore);
            this.Controls.Add(this.lsvFilmler);
            this.Name = "FrmFilmSorgula";
            this.Text = "FrmFilmSorgula";
            this.Load += new System.EventHandler(this.FrmFilmSorgula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvFilmler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtFilmAdinaGore;
        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.TextBox txtYonetmeneGore;
        private System.Windows.Forms.TextBox txtOyuncuyaGore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}