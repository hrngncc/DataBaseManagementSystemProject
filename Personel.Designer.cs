
namespace Veritabaniproje
{
    partial class Personel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtPersonelid = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.Label();
            this.txtpad = new System.Windows.Forms.TextBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtSoyad = new System.Windows.Forms.Label();
            this.txtpsoyad = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.txtarap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // TxtPersonelid
            // 
            this.TxtPersonelid.AutoSize = true;
            this.TxtPersonelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelid.Location = new System.Drawing.Point(537, 63);
            this.TxtPersonelid.Name = "TxtPersonelid";
            this.TxtPersonelid.Size = new System.Drawing.Size(102, 20);
            this.TxtPersonelid.TabIndex = 1;
            this.TxtPersonelid.Text = "Personel ID:";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(654, 63);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(129, 22);
            this.txtpid.TabIndex = 2;
            // 
            // TxtAd
            // 
            this.TxtAd.AutoSize = true;
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(537, 101);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(105, 20);
            this.TxtAd.TabIndex = 3;
            this.TxtAd.Text = "Personel Ad:";
            // 
            // txtpad
            // 
            this.txtpad.Location = new System.Drawing.Point(654, 99);
            this.txtpad.Name = "txtpad";
            this.txtpad.Size = new System.Drawing.Size(129, 22);
            this.txtpad.TabIndex = 4;
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(654, 166);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(108, 40);
            this.BtnListele.TabIndex = 5;
            this.BtnListele.Text = "Listele\r\n";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.AutoSize = true;
            this.TxtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(508, 140);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(131, 20);
            this.TxtSoyad.TabIndex = 6;
            this.TxtSoyad.Text = "Personel Soyad:";
            // 
            // txtpsoyad
            // 
            this.txtpsoyad.Location = new System.Drawing.Point(654, 138);
            this.txtpsoyad.Name = "txtpsoyad";
            this.txtpsoyad.Size = new System.Drawing.Size(129, 22);
            this.txtpsoyad.TabIndex = 7;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(654, 212);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(108, 36);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(654, 254);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(108, 35);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "Sil\r\n";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(654, 295);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(108, 38);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // txtarap
            // 
            this.txtarap.Location = new System.Drawing.Point(654, 341);
            this.txtarap.Name = "txtarap";
            this.txtarap.Size = new System.Drawing.Size(129, 22);
            this.txtarap.TabIndex = 11;
            this.txtarap.TextChanged += new System.EventHandler(this.txtarap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(511, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Personel Ara:";
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtarap);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.txtpsoyad);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.txtpad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.TxtPersonelid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TxtPersonelid;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label TxtAd;
        private System.Windows.Forms.TextBox txtpad;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Label TxtSoyad;
        private System.Windows.Forms.TextBox txtpsoyad;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox txtarap;
        private System.Windows.Forms.Label label1;
    }
}