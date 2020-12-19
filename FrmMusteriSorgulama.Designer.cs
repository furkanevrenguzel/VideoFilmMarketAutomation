namespace VideoMarketPortalim
{
    partial class FrmMusteriSorgulama
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
            this.lsvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyAdaGore = new System.Windows.Forms.TextBox();
            this.txtAdinaGoreAra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsvMusteriler
            // 
            this.lsvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvMusteriler.FullRowSelect = true;
            this.lsvMusteriler.GridLines = true;
            this.lsvMusteriler.Location = new System.Drawing.Point(-5, 101);
            this.lsvMusteriler.Name = "lsvMusteriler";
            this.lsvMusteriler.Size = new System.Drawing.Size(507, 208);
            this.lsvMusteriler.TabIndex = 0;
            this.lsvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lsvMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Musteri No";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri Adı";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri Soyadı";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 234;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Adına Göre Ara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Soyadına Göre Ara:";
            // 
            // txtSoyAdaGore
            // 
            this.txtSoyAdaGore.Location = new System.Drawing.Point(180, 60);
            this.txtSoyAdaGore.Name = "txtSoyAdaGore";
            this.txtSoyAdaGore.Size = new System.Drawing.Size(117, 20);
            this.txtSoyAdaGore.TabIndex = 4;
            this.txtSoyAdaGore.TextChanged += new System.EventHandler(this.txtSoyAdaGore_TextChanged);
            this.txtSoyAdaGore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyAdaGore_KeyPress);
            // 
            // txtAdinaGoreAra
            // 
            this.txtAdinaGoreAra.Location = new System.Drawing.Point(180, 16);
            this.txtAdinaGoreAra.Name = "txtAdinaGoreAra";
            this.txtAdinaGoreAra.Size = new System.Drawing.Size(117, 20);
            this.txtAdinaGoreAra.TabIndex = 5;
            this.txtAdinaGoreAra.TextChanged += new System.EventHandler(this.txtAdinaGoreAra_TextChanged_1);
            this.txtAdinaGoreAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdinaGoreAra_KeyPress_1);
            // 
            // FrmMusteriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 319);
            this.Controls.Add(this.txtAdinaGoreAra);
            this.Controls.Add(this.txtSoyAdaGore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvMusteriler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmMusteriSorgulama";
            this.Text = "Müşteri Sorgulama";
            this.Load += new System.EventHandler(this.FrmMusteriSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyAdaGore;
        private System.Windows.Forms.TextBox txtAdinaGoreAra;
    }
}