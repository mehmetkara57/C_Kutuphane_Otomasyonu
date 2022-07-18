namespace Kutuphane.Forms
{
    partial class Grafik
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
            this.panelGrafik = new System.Windows.Forms.Panel();
            this.zedGraphGrafik = new ZedGraph.ZedGraphControl();
            this.btn_grafik = new System.Windows.Forms.Button();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.btn_ogrenciler = new System.Windows.Forms.Button();
            this.btn_islemler = new System.Windows.Forms.Button();
            this.panelGrafik.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGrafik
            // 
            this.panelGrafik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrafik.Controls.Add(this.zedGraphGrafik);
            this.panelGrafik.Location = new System.Drawing.Point(471, 52);
            this.panelGrafik.Margin = new System.Windows.Forms.Padding(4);
            this.panelGrafik.Name = "panelGrafik";
            this.panelGrafik.Size = new System.Drawing.Size(799, 471);
            this.panelGrafik.TabIndex = 2;
            // 
            // zedGraphGrafik
            // 
            this.zedGraphGrafik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphGrafik.Location = new System.Drawing.Point(0, 0);
            this.zedGraphGrafik.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphGrafik.Name = "zedGraphGrafik";
            this.zedGraphGrafik.ScrollGrace = 0D;
            this.zedGraphGrafik.ScrollMaxX = 0D;
            this.zedGraphGrafik.ScrollMaxY = 0D;
            this.zedGraphGrafik.ScrollMaxY2 = 0D;
            this.zedGraphGrafik.ScrollMinX = 0D;
            this.zedGraphGrafik.ScrollMinY = 0D;
            this.zedGraphGrafik.ScrollMinY2 = 0D;
            this.zedGraphGrafik.Size = new System.Drawing.Size(799, 471);
            this.zedGraphGrafik.TabIndex = 0;
            // 
            // btn_grafik
            // 
            this.btn_grafik.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_grafik.BackColor = System.Drawing.Color.Teal;
            this.btn_grafik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_grafik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_grafik.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grafik.ForeColor = System.Drawing.Color.Black;
            this.btn_grafik.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_grafik.Location = new System.Drawing.Point(107, 457);
            this.btn_grafik.Margin = new System.Windows.Forms.Padding(4);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(203, 90);
            this.btn_grafik.TabIndex = 15;
            this.btn_grafik.Text = "Grafik";
            this.btn_grafik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_grafik.UseVisualStyleBackColor = false;
            this.btn_grafik.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_grafik.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btn_kitaplar
            // 
            this.btn_kitaplar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_kitaplar.BackColor = System.Drawing.Color.Teal;
            this.btn_kitaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kitaplar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kitaplar.ForeColor = System.Drawing.Color.Black;
            this.btn_kitaplar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kitaplar.Location = new System.Drawing.Point(107, 42);
            this.btn_kitaplar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(203, 90);
            this.btn_kitaplar.TabIndex = 12;
            this.btn_kitaplar.Text = "Kitaplar";
            this.btn_kitaplar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitaplar.UseVisualStyleBackColor = false;
            this.btn_kitaplar.Click += new System.EventHandler(this.btn_kitaplar_Click);
            this.btn_kitaplar.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_kitaplar.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btn_ogrenciler
            // 
            this.btn_ogrenciler.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_ogrenciler.BackColor = System.Drawing.Color.Teal;
            this.btn_ogrenciler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ogrenciler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ogrenciler.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciler.ForeColor = System.Drawing.Color.Black;
            this.btn_ogrenciler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ogrenciler.Location = new System.Drawing.Point(107, 174);
            this.btn_ogrenciler.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ogrenciler.Name = "btn_ogrenciler";
            this.btn_ogrenciler.Size = new System.Drawing.Size(203, 90);
            this.btn_ogrenciler.TabIndex = 13;
            this.btn_ogrenciler.Text = "Öğrenciler";
            this.btn_ogrenciler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ogrenciler.UseVisualStyleBackColor = false;
            this.btn_ogrenciler.Click += new System.EventHandler(this.btn_ogrenciler_Click_1);
            this.btn_ogrenciler.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_ogrenciler.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btn_islemler
            // 
            this.btn_islemler.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_islemler.BackColor = System.Drawing.Color.Teal;
            this.btn_islemler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_islemler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_islemler.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_islemler.ForeColor = System.Drawing.Color.Black;
            this.btn_islemler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_islemler.Location = new System.Drawing.Point(107, 309);
            this.btn_islemler.Margin = new System.Windows.Forms.Padding(4);
            this.btn_islemler.Name = "btn_islemler";
            this.btn_islemler.Size = new System.Drawing.Size(203, 90);
            this.btn_islemler.TabIndex = 14;
            this.btn_islemler.Text = "İşlemler";
            this.btn_islemler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_islemler.UseVisualStyleBackColor = false;
            this.btn_islemler.Click += new System.EventHandler(this.btn_islemler_Click_1);
            this.btn_islemler.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_islemler.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1311, 669);
            this.Controls.Add(this.btn_grafik);
            this.Controls.Add(this.btn_kitaplar);
            this.Controls.Add(this.btn_ogrenciler);
            this.Controls.Add(this.btn_islemler);
            this.Controls.Add(this.panelGrafik);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grafik";
            this.Text = "Grafik";
            this.Load += new System.EventHandler(this.Grafik_Load);
            this.panelGrafik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGrafik;
        private System.Windows.Forms.Button btn_grafik;
        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Button btn_ogrenciler;
        private System.Windows.Forms.Button btn_islemler;
        private ZedGraph.ZedGraphControl zedGraphGrafik;
    }
}