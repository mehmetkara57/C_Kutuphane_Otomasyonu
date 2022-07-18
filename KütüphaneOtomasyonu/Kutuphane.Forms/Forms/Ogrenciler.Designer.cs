
namespace Kutuphane.Forms
{
    partial class Ogrenciler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_islem = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_grafik = new System.Windows.Forms.Button();
            this.btn_islemler = new System.Windows.Forms.Button();
            this.btn_ogrenciler = new System.Windows.Forms.Button();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.panelOgrenciler = new System.Windows.Forms.Panel();
            this.dataGridViewOgrenciler = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAlabilirMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbl_ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kutuphaneDataSet = new Kutuphane.Forms.db_kutuphaneDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_ogrenciTableAdapter = new Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.tbl_ogrenciTableAdapter();
            this.tableAdapterManager = new Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.TableAdapterManager();
            this.panelOgrenciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_islem
            // 
            this.btn_islem.BackColor = System.Drawing.Color.Teal;
            this.btn_islem.Location = new System.Drawing.Point(1268, 446);
            this.btn_islem.Name = "btn_islem";
            this.btn_islem.Size = new System.Drawing.Size(111, 50);
            this.btn_islem.TabIndex = 19;
            this.btn_islem.Text = "İşlem yap";
            this.btn_islem.UseVisualStyleBackColor = false;
            this.btn_islem.Click += new System.EventHandler(this.btn_islem_Click_1);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Teal;
            this.btn_sil.Location = new System.Drawing.Point(1268, 283);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(111, 50);
            this.btn_sil.TabIndex = 18;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click_1);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Teal;
            this.btn_guncelle.Location = new System.Drawing.Point(1268, 188);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(111, 50);
            this.btn_guncelle.TabIndex = 17;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click_1);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Teal;
            this.btn_ekle.Location = new System.Drawing.Point(1268, 106);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(111, 50);
            this.btn_ekle.TabIndex = 16;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click_1);
            // 
            // btn_grafik
            // 
            this.btn_grafik.BackColor = System.Drawing.Color.Teal;
            this.btn_grafik.Location = new System.Drawing.Point(800, 27);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(138, 62);
            this.btn_grafik.TabIndex = 15;
            this.btn_grafik.Text = "Grafik";
            this.btn_grafik.UseVisualStyleBackColor = false;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click_1);
            // 
            // btn_islemler
            // 
            this.btn_islemler.BackColor = System.Drawing.Color.Teal;
            this.btn_islemler.Location = new System.Drawing.Point(608, 27);
            this.btn_islemler.Name = "btn_islemler";
            this.btn_islemler.Size = new System.Drawing.Size(138, 62);
            this.btn_islemler.TabIndex = 14;
            this.btn_islemler.Text = "İşlemler";
            this.btn_islemler.UseVisualStyleBackColor = false;
            this.btn_islemler.Click += new System.EventHandler(this.btn_islemler_Click);
            // 
            // btn_ogrenciler
            // 
            this.btn_ogrenciler.BackColor = System.Drawing.Color.Teal;
            this.btn_ogrenciler.Location = new System.Drawing.Point(413, 27);
            this.btn_ogrenciler.Name = "btn_ogrenciler";
            this.btn_ogrenciler.Size = new System.Drawing.Size(138, 62);
            this.btn_ogrenciler.TabIndex = 13;
            this.btn_ogrenciler.Text = "Öğrenciler";
            this.btn_ogrenciler.UseVisualStyleBackColor = false;
            // 
            // btn_kitaplar
            // 
            this.btn_kitaplar.BackColor = System.Drawing.Color.Teal;
            this.btn_kitaplar.Location = new System.Drawing.Point(226, 27);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(138, 62);
            this.btn_kitaplar.TabIndex = 12;
            this.btn_kitaplar.Text = "Kitaplar";
            this.btn_kitaplar.UseVisualStyleBackColor = false;
            this.btn_kitaplar.Click += new System.EventHandler(this.btn_kitaplar_Click);
            // 
            // panelOgrenciler
            // 
            this.panelOgrenciler.Controls.Add(this.dataGridViewOgrenciler);
            this.panelOgrenciler.Location = new System.Drawing.Point(12, 106);
            this.panelOgrenciler.Name = "panelOgrenciler";
            this.panelOgrenciler.Size = new System.Drawing.Size(1170, 407);
            this.panelOgrenciler.TabIndex = 11;
            // 
            // dataGridViewOgrenciler
            // 
            this.dataGridViewOgrenciler.AllowUserToAddRows = false;
            this.dataGridViewOgrenciler.AllowUserToDeleteRows = false;
            this.dataGridViewOgrenciler.AllowUserToResizeColumns = false;
            this.dataGridViewOgrenciler.AllowUserToResizeRows = false;
            this.dataGridViewOgrenciler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOgrenciler.AutoGenerateColumns = false;
            this.dataGridViewOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOgrenciler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOgrenciler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOgrenciler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOgrenciler.ColumnHeadersHeight = 50;
            this.dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOgrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.ogrenciNoDataGridViewTextBoxColumn,
            this.tcNoDataGridViewTextBoxColumn,
            this.telNoDataGridViewTextBoxColumn,
            this.borcDataGridViewTextBoxColumn,
            this.kitapAlabilirMiDataGridViewCheckBoxColumn});
            this.dataGridViewOgrenciler.DataSource = this.tbl_ogrenciBindingSource;
            this.dataGridViewOgrenciler.EnableHeadersVisualStyles = false;
            this.dataGridViewOgrenciler.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewOgrenciler.MultiSelect = false;
            this.dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            this.dataGridViewOgrenciler.ReadOnly = true;
            this.dataGridViewOgrenciler.RowHeadersVisible = false;
            this.dataGridViewOgrenciler.RowHeadersWidth = 51;
            this.dataGridViewOgrenciler.RowTemplate.Height = 24;
            this.dataGridViewOgrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOgrenciler.ShowCellToolTips = false;
            this.dataGridViewOgrenciler.ShowEditingIcon = false;
            this.dataGridViewOgrenciler.Size = new System.Drawing.Size(1161, 401);
            this.dataGridViewOgrenciler.TabIndex = 0;
            this.dataGridViewOgrenciler.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciNoDataGridViewTextBoxColumn
            // 
            this.ogrenciNoDataGridViewTextBoxColumn.DataPropertyName = "ogrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.HeaderText = "ogrenciNo";
            this.ogrenciNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciNoDataGridViewTextBoxColumn.Name = "ogrenciNoDataGridViewTextBoxColumn";
            this.ogrenciNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tcNoDataGridViewTextBoxColumn
            // 
            this.tcNoDataGridViewTextBoxColumn.DataPropertyName = "tcNo";
            this.tcNoDataGridViewTextBoxColumn.HeaderText = "tcNo";
            this.tcNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcNoDataGridViewTextBoxColumn.Name = "tcNoDataGridViewTextBoxColumn";
            this.tcNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telNoDataGridViewTextBoxColumn
            // 
            this.telNoDataGridViewTextBoxColumn.DataPropertyName = "telNo";
            this.telNoDataGridViewTextBoxColumn.HeaderText = "telNo";
            this.telNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telNoDataGridViewTextBoxColumn.Name = "telNoDataGridViewTextBoxColumn";
            this.telNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borcDataGridViewTextBoxColumn
            // 
            this.borcDataGridViewTextBoxColumn.DataPropertyName = "borc";
            this.borcDataGridViewTextBoxColumn.HeaderText = "borc";
            this.borcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borcDataGridViewTextBoxColumn.Name = "borcDataGridViewTextBoxColumn";
            this.borcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitapAlabilirMiDataGridViewCheckBoxColumn
            // 
            this.kitapAlabilirMiDataGridViewCheckBoxColumn.DataPropertyName = "kitapAlabilirMi";
            this.kitapAlabilirMiDataGridViewCheckBoxColumn.HeaderText = "kitapAlabilirMi";
            this.kitapAlabilirMiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.kitapAlabilirMiDataGridViewCheckBoxColumn.Name = "kitapAlabilirMiDataGridViewCheckBoxColumn";
            this.kitapAlabilirMiDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tbl_ogrenciBindingSource
            // 
            this.tbl_ogrenciBindingSource.DataMember = "tbl_ogrenci";
            this.tbl_ogrenciBindingSource.DataSource = this.db_kutuphaneDataSet;
            // 
            // db_kutuphaneDataSet
            // 
            this.db_kutuphaneDataSet.DataSetName = "db_kutuphaneDataSet";
            this.db_kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1182, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kitap İşlemleri İçin Yandan Bir Öğrenci Seçin";
            // 
            // tbl_ogrenciTableAdapter
            // 
            this.tbl_ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_emanetTableAdapter = null;
            this.tableAdapterManager.tbl_kitapTableAdapter = null;
            this.tableAdapterManager.tbl_ogrenciTableAdapter = this.tbl_ogrenciTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Ogrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1481, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_islem);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_grafik);
            this.Controls.Add(this.btn_islemler);
            this.Controls.Add(this.btn_ogrenciler);
            this.Controls.Add(this.btn_kitaplar);
            this.Controls.Add(this.panelOgrenciler);
            this.Name = "Ogrenciler";
            this.Text = "Öğrenciler";
            this.Load += new System.EventHandler(this.Ogrenciler_Load_1);
            this.panelOgrenciler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_islem;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_grafik;
        private System.Windows.Forms.Button btn_islemler;
        private System.Windows.Forms.Button btn_ogrenciler;
        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Panel panelOgrenciler;
        private System.Windows.Forms.DataGridView dataGridViewOgrenciler;
        private System.Windows.Forms.Label label1;
        private db_kutuphaneDataSet db_kutuphaneDataSet;
        private System.Windows.Forms.BindingSource tbl_ogrenciBindingSource;
        private db_kutuphaneDataSetTableAdapters.tbl_ogrenciTableAdapter tbl_ogrenciTableAdapter;
        private db_kutuphaneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kitapAlabilirMiDataGridViewCheckBoxColumn;
    }
}