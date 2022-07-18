
namespace Kutuphane.Forms
{
    partial class KitapGuncelle
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
            this.tb_stok = new System.Windows.Forms.TextBox();
            this.tb_sayfa = new System.Windows.Forms.TextBox();
            this.tb_tur = new System.Windows.Forms.TextBox();
            this.tb_yazar = new System.Windows.Forms.TextBox();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.lbl_sayfa = new System.Windows.Forms.Label();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.lbl_yazar = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_stok
            // 
            this.tb_stok.Location = new System.Drawing.Point(400, 290);
            this.tb_stok.Multiline = true;
            this.tb_stok.Name = "tb_stok";
            this.tb_stok.Size = new System.Drawing.Size(136, 29);
            this.tb_stok.TabIndex = 23;
            // 
            // tb_sayfa
            // 
            this.tb_sayfa.Location = new System.Drawing.Point(400, 225);
            this.tb_sayfa.Multiline = true;
            this.tb_sayfa.Name = "tb_sayfa";
            this.tb_sayfa.Size = new System.Drawing.Size(136, 29);
            this.tb_sayfa.TabIndex = 22;
            // 
            // tb_tur
            // 
            this.tb_tur.Location = new System.Drawing.Point(400, 166);
            this.tb_tur.Multiline = true;
            this.tb_tur.Name = "tb_tur";
            this.tb_tur.Size = new System.Drawing.Size(136, 29);
            this.tb_tur.TabIndex = 21;
            // 
            // tb_yazar
            // 
            this.tb_yazar.Location = new System.Drawing.Point(400, 114);
            this.tb_yazar.Multiline = true;
            this.tb_yazar.Name = "tb_yazar";
            this.tb_yazar.Size = new System.Drawing.Size(136, 29);
            this.tb_yazar.TabIndex = 20;
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(400, 51);
            this.tb_ad.Multiline = true;
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(136, 29);
            this.tb_ad.TabIndex = 19;
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stok.Location = new System.Drawing.Point(217, 290);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(149, 29);
            this.lbl_stok.TabIndex = 18;
            this.lbl_stok.Text = "Kitap Adedi :";
            // 
            // lbl_sayfa
            // 
            this.lbl_sayfa.AutoSize = true;
            this.lbl_sayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayfa.Location = new System.Drawing.Point(212, 225);
            this.lbl_sayfa.Name = "lbl_sayfa";
            this.lbl_sayfa.Size = new System.Drawing.Size(154, 29);
            this.lbl_sayfa.TabIndex = 17;
            this.lbl_sayfa.Text = "Sayfa Sayısı :";
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tur.Location = new System.Drawing.Point(230, 166);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(136, 29);
            this.lbl_tur.TabIndex = 16;
            this.lbl_tur.Text = "Kitap Türü :";
            // 
            // lbl_yazar
            // 
            this.lbl_yazar.AutoSize = true;
            this.lbl_yazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazar.Location = new System.Drawing.Point(239, 114);
            this.lbl_yazar.Name = "lbl_yazar";
            this.lbl_yazar.Size = new System.Drawing.Size(127, 29);
            this.lbl_yazar.TabIndex = 15;
            this.lbl_yazar.Text = "Yazar Adı :";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(245, 51);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(121, 29);
            this.lbl_ad.TabIndex = 14;
            this.lbl_ad.Text = "Kitap Adı :";
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(321, 357);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(81, 43);
            this.btn_iptal.TabIndex = 13;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(484, 357);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(85, 43);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click_1);
            // 
            // KitapGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_stok);
            this.Controls.Add(this.tb_sayfa);
            this.Controls.Add(this.tb_tur);
            this.Controls.Add(this.tb_yazar);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.lbl_sayfa);
            this.Controls.Add(this.lbl_tur);
            this.Controls.Add(this.lbl_yazar);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_guncelle);
            this.Name = "KitapGuncelle";
            this.Text = "Kitap Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_stok;
        private System.Windows.Forms.TextBox tb_sayfa;
        private System.Windows.Forms.TextBox tb_tur;
        private System.Windows.Forms.TextBox tb_yazar;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.Label lbl_sayfa;
        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.Label lbl_yazar;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_guncelle;
    }
}