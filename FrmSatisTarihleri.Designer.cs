namespace VideoMarketPortalim
{
    partial class FrmSatisTarihleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpilk = new System.Windows.Forms.DateTimePicker();
            this.dtpSon = new System.Windows.Forms.DateTimePicker();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlk Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Son Tarih";
            // 
            // dtpilk
            // 
            this.dtpilk.Location = new System.Drawing.Point(124, 63);
            this.dtpilk.Name = "dtpilk";
            this.dtpilk.Size = new System.Drawing.Size(77, 20);
            this.dtpilk.TabIndex = 2;
            // 
            // dtpSon
            // 
            this.dtpSon.Location = new System.Drawing.Point(330, 63);
            this.dtpSon.Name = "dtpSon";
            this.dtpSon.Size = new System.Drawing.Size(81, 20);
            this.dtpSon.TabIndex = 3;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(217, 90);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(87, 23);
            this.btnSorgula.TabIndex = 4;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(-3, 119);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.Size = new System.Drawing.Size(539, 203);
            this.dgvSatislar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toplam Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam Tutar:";
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(160, 336);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.Size = new System.Drawing.Size(116, 20);
            this.txtToplamAdet.TabIndex = 8;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(406, 336);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(116, 20);
            this.txtToplamTutar.TabIndex = 9;
            // 
            // FrmSatisTarihleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 368);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.dtpSon);
            this.Controls.Add(this.dtpilk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmSatisTarihleri";
            this.Text = "Tarihler Arası Satış";
            this.Load += new System.EventHandler(this.FrmSatisTarihleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpilk;
        private System.Windows.Forms.DateTimePicker dtpSon;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.TextBox txtToplamTutar;
    }
}