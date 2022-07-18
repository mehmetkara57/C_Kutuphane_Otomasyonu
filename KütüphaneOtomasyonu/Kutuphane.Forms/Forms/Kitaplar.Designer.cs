
namespace Kutuphane.Forms
{
    partial class Kitaplar
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
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kutuphaneDataSet = new Kutuphane.Forms.db_kutuphaneDataSet();
            this.dbkutuphaneDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelKitaplar = new System.Windows.Forms.Panel();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.btn_ogrenciler = new System.Windows.Forms.Button();
            this.btn_islemler = new System.Windows.Forms.Button();
            this.btn_grafik = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.dbkutuphaneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_kitapTableAdapter = new Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.tbl_kitapTableAdapter();
            this.tableAdapterManager = new Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkutuphaneDataSetBindingSource1)).BeginInit();
            this.panelKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbkutuphaneDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AllowUserToAddRows = false;
            this.dataGridViewKitaplar.AllowUserToDeleteRows = false;
            this.dataGridViewKitaplar.AllowUserToResizeColumns = false;
            this.dataGridViewKitaplar.AllowUserToResizeRows = false;
            this.dataGridViewKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKitaplar.AutoGenerateColumns = false;
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewKitaplar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKitaplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKitaplar.ColumnHeadersHeight = 29;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.sayfaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn});
            this.dataGridViewKitaplar.DataSource = this.tbl_kitapBindingSource;
            this.dataGridViewKitaplar.EnableHeadersVisualStyles = false;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKitaplar.MultiSelect = false;
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.ReadOnly = true;
            this.dataGridViewKitaplar.RowHeadersVisible = false;
            this.dataGridViewKitaplar.RowHeadersWidth = 51;
            this.dataGridViewKitaplar.RowTemplate.Height = 24;
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.ShowCellToolTips = false;
            this.dataGridViewKitaplar.ShowEditingIcon = false;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(1050, 398);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewKitaplar_ColumnAdded);
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
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "yazar";
            this.yazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            this.yazarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "tur";
            this.turDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            this.turDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sayfaDataGridViewTextBoxColumn
            // 
            this.sayfaDataGridViewTextBoxColumn.DataPropertyName = "sayfa";
            this.sayfaDataGridViewTextBoxColumn.HeaderText = "sayfa";
            this.sayfaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sayfaDataGridViewTextBoxColumn.Name = "sayfaDataGridViewTextBoxColumn";
            this.sayfaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbl_kitapBindingSource
            // 
            this.tbl_kitapBindingSource.DataMember = "tbl_kitap";
            this.tbl_kitapBindingSource.DataSource = this.db_kutuphaneDataSet;
            // 
            // db_kutuphaneDataSet
            // 
            this.db_kutuphaneDataSet.DataSetName = "db_kutuphaneDataSet";
            this.db_kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbkutuphaneDataSetBindingSource1
            // 
            this.dbkutuphaneDataSetBindingSource1.DataSource = this.db_kutuphaneDataSet;
            this.dbkutuphaneDataSetBindingSource1.Position = 0;
            // 
            // panelKitaplar
            // 
            this.panelKitaplar.Controls.Add(this.dataGridViewKitaplar);
            this.panelKitaplar.Location = new System.Drawing.Point(172, 111);
            this.panelKitaplar.Name = "panelKitaplar";
            this.panelKitaplar.Size = new System.Drawing.Size(1050, 398);
            this.panelKitaplar.TabIndex = 1;
            // 
            // btn_kitaplar
            // 
            this.btn_kitaplar.BackColor = System.Drawing.Color.Teal;
            this.btn_kitaplar.Location = new System.Drawing.Point(233, 32);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(138, 62);
            this.btn_kitaplar.TabIndex = 2;
            this.btn_kitaplar.Text = "Kitaplar";
            this.btn_kitaplar.UseVisualStyleBackColor = false;
            
            this.btn_kitaplar.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_kitaplar.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btn_ogrenciler
            // 
            this.btn_ogrenciler.BackColor = System.Drawing.Color.Teal;
            this.btn_ogrenciler.Location = new System.Drawing.Point(420, 32);
            this.btn_ogrenciler.Name = "btn_ogrenciler";
            this.btn_ogrenciler.Size = new System.Drawing.Size(138, 62);
            this.btn_ogrenciler.TabIndex = 3;
            this.btn_ogrenciler.Text = "Öğrenciler";
            this.btn_ogrenciler.UseVisualStyleBackColor = false;
            this.btn_ogrenciler.Click += new System.EventHandler(this.btn_ogrenciler_Click_1);
            this.btn_ogrenciler.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_ogrenciler.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btn_islemler
            // 
            this.btn_islemler.BackColor = System.Drawing.Color.Teal;
            this.btn_islemler.Location = new System.Drawing.Point(615, 32);
            this.btn_islemler.Name = "btn_islemler";
            this.btn_islemler.Size = new System.Drawing.Size(138, 62);
            this.btn_islemler.TabIndex = 4;
            this.btn_islemler.Text = "İşlemler";
            this.btn_islemler.UseVisualStyleBackColor = false;
            this.btn_islemler.Click += new System.EventHandler(this.btn_islemler_Click);
            this.btn_islemler.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_islemler.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btn_grafik
            // 
            this.btn_grafik.BackColor = System.Drawing.Color.Teal;
            this.btn_grafik.Location = new System.Drawing.Point(807, 32);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(138, 62);
            this.btn_grafik.TabIndex = 5;
            this.btn_grafik.Text = "Grafik";
            this.btn_grafik.UseVisualStyleBackColor = false;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click_1);
            this.btn_grafik.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.btn_grafik.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Teal;
            this.btn_ekle.Location = new System.Drawing.Point(1275, 111);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(111, 50);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click_1);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Teal;
            this.btn_guncelle.Location = new System.Drawing.Point(1275, 193);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(111, 50);
            this.btn_guncelle.TabIndex = 7;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click_1);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Teal;
            this.btn_sil.Location = new System.Drawing.Point(1275, 288);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(111, 50);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click_1);
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.Teal;
            this.btn_ara.Location = new System.Drawing.Point(1275, 451);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(111, 50);
            this.btn_ara.TabIndex = 9;
            this.btn_ara.Text = "Detaylar";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click_1);
            // 
            // textBoxArama
            // 
            this.textBoxArama.Location = new System.Drawing.Point(1242, 398);
            this.textBoxArama.Multiline = true;
            this.textBoxArama.Name = "textBoxArama";
            this.textBoxArama.Size = new System.Drawing.Size(182, 31);
            this.textBoxArama.TabIndex = 10;
            this.textBoxArama.Enter += new System.EventHandler(this.textBoxArama_Enter);
            this.textBoxArama.Leave += new System.EventHandler(this.textBoxArama_Leave);
            // 
            // dbkutuphaneDataSetBindingSource
            // 
            this.dbkutuphaneDataSetBindingSource.DataSource = this.db_kutuphaneDataSet;
            this.dbkutuphaneDataSetBindingSource.Position = 0;
            // 
            // tbl_kitapTableAdapter
            // 
            this.tbl_kitapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_emanetTableAdapter = null;
            this.tableAdapterManager.tbl_kitapTableAdapter = this.tbl_kitapTableAdapter;
            this.tableAdapterManager.tbl_ogrenciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1480, 542);
            this.Controls.Add(this.textBoxArama);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_grafik);
            this.Controls.Add(this.btn_islemler);
            this.Controls.Add(this.btn_ogrenciler);
            this.Controls.Add(this.btn_kitaplar);
            this.Controls.Add(this.panelKitaplar);
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkutuphaneDataSetBindingSource1)).EndInit();
            this.panelKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbkutuphaneDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.Panel panelKitaplar;
        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Button btn_ogrenciler;
        private System.Windows.Forms.Button btn_islemler;
        private System.Windows.Forms.Button btn_grafik;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox textBoxArama;
        private System.Windows.Forms.BindingSource dbkutuphaneDataSetBindingSource;
        private db_kutuphaneDataSet db_kutuphaneDataSet;
        private System.Windows.Forms.BindingSource dbkutuphaneDataSetBindingSource1;
        private System.Windows.Forms.BindingSource tbl_kitapBindingSource;
        private db_kutuphaneDataSetTableAdapters.tbl_kitapTableAdapter tbl_kitapTableAdapter;
        private db_kutuphaneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
    }
}