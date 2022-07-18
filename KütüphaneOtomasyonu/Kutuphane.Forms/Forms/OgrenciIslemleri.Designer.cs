namespace Kutuphane.Forms
{
    partial class OgrenciIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_emanet = new System.Windows.Forms.Button();
            this.panelKitaplar = new System.Windows.Forms.Panel();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblkitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kutuphaneDataSet = new Kutuphane.Forms.db_kutuphaneDataSet();
            this.dataGridViewEmanet = new System.Windows.Forms.DataGridView();
            this.lbl_hosgeldiniz = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_iade = new System.Windows.Forms.Button();
            this.lbl_borc = new System.Windows.Forms.Label();
            this.panelEmanet = new System.Windows.Forms.Panel();
            this.tbl_emanetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_emanetTableAdapter = new Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.tbl_emanetTableAdapter();
            this.tableAdapterManager = new Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.TableAdapterManager();
            this.tbl_kitapTableAdapter = new Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.tbl_kitapTableAdapter();
            this.panelKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).BeginInit();
            this.panelEmanet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_emanetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_emanet
            // 
            this.btn_emanet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_emanet.BackColor = System.Drawing.Color.Teal;
            this.btn_emanet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_emanet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_emanet.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emanet.ForeColor = System.Drawing.Color.Black;
            this.btn_emanet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_emanet.Location = new System.Drawing.Point(251, 599);
            this.btn_emanet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_emanet.Name = "btn_emanet";
            this.btn_emanet.Size = new System.Drawing.Size(108, 53);
            this.btn_emanet.TabIndex = 16;
            this.btn_emanet.Text = "Emanet Al";
            this.btn_emanet.UseVisualStyleBackColor = false;
            this.btn_emanet.Click += new System.EventHandler(this.btn_emanet_Click);
            // 
            // panelKitaplar
            // 
            this.panelKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKitaplar.Controls.Add(this.dataGridViewKitaplar);
            this.panelKitaplar.Location = new System.Drawing.Point(13, 63);
            this.panelKitaplar.Margin = new System.Windows.Forms.Padding(4);
            this.panelKitaplar.Name = "panelKitaplar";
            this.panelKitaplar.Size = new System.Drawing.Size(770, 516);
            this.panelKitaplar.TabIndex = 17;
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
            this.dataGridViewKitaplar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewKitaplar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewKitaplar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKitaplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKitaplar.ColumnHeadersHeight = 50;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.sayfaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn});
            this.dataGridViewKitaplar.DataSource = this.tblkitapBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKitaplar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKitaplar.EnableHeadersVisualStyles = false;
            this.dataGridViewKitaplar.GridColor = System.Drawing.Color.White;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(9, 30);
            this.dataGridViewKitaplar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKitaplar.MultiSelect = false;
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.ReadOnly = true;
            this.dataGridViewKitaplar.RowHeadersVisible = false;
            this.dataGridViewKitaplar.RowHeadersWidth = 51;
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.ShowCellToolTips = false;
            this.dataGridViewKitaplar.ShowEditingIcon = false;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(757, 444);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_ColumnAdded);
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
            // tblkitapBindingSource
            // 
            this.tblkitapBindingSource.DataMember = "tbl_kitap";
            this.tblkitapBindingSource.DataSource = this.db_kutuphaneDataSet;
            // 
            // db_kutuphaneDataSet
            // 
            this.db_kutuphaneDataSet.DataSetName = "db_kutuphaneDataSet";
            this.db_kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewEmanet
            // 
            this.dataGridViewEmanet.AllowUserToAddRows = false;
            this.dataGridViewEmanet.AllowUserToDeleteRows = false;
            this.dataGridViewEmanet.AllowUserToResizeColumns = false;
            this.dataGridViewEmanet.AllowUserToResizeRows = false;
            this.dataGridViewEmanet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmanet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmanet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewEmanet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmanet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmanet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmanet.ColumnHeadersHeight = 50;
            this.dataGridViewEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmanet.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmanet.EnableHeadersVisualStyles = false;
            this.dataGridViewEmanet.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewEmanet.Location = new System.Drawing.Point(4, 30);
            this.dataGridViewEmanet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEmanet.MultiSelect = false;
            this.dataGridViewEmanet.Name = "dataGridViewEmanet";
            this.dataGridViewEmanet.ReadOnly = true;
            this.dataGridViewEmanet.RowHeadersVisible = false;
            this.dataGridViewEmanet.RowHeadersWidth = 51;
            this.dataGridViewEmanet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmanet.ShowCellToolTips = false;
            this.dataGridViewEmanet.ShowEditingIcon = false;
            this.dataGridViewEmanet.Size = new System.Drawing.Size(737, 444);
            this.dataGridViewEmanet.TabIndex = 1;
            this.dataGridViewEmanet.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_ColumnAdded);
            // 
            // lbl_hosgeldiniz
            // 
            this.lbl_hosgeldiniz.AutoSize = true;
            this.lbl_hosgeldiniz.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hosgeldiniz.ForeColor = System.Drawing.Color.Black;
            this.lbl_hosgeldiniz.Location = new System.Drawing.Point(14, 11);
            this.lbl_hosgeldiniz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hosgeldiniz.Name = "lbl_hosgeldiniz";
            this.lbl_hosgeldiniz.Size = new System.Drawing.Size(211, 48);
            this.lbl_hosgeldiniz.TabIndex = 18;
            this.lbl_hosgeldiniz.Text = "lbl_hosgeldiniz";
            // 
            // btn_geri
            // 
            this.btn_geri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_geri.BackColor = System.Drawing.Color.Teal;
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geri.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_geri.ForeColor = System.Drawing.Color.Black;
            this.btn_geri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_geri.Location = new System.Drawing.Point(1231, 599);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(108, 53);
            this.btn_geri.TabIndex = 19;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click_1);
            // 
            // btn_iade
            // 
            this.btn_iade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_iade.BackColor = System.Drawing.Color.Teal;
            this.btn_iade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iade.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iade.ForeColor = System.Drawing.Color.Black;
            this.btn_iade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iade.Location = new System.Drawing.Point(731, 599);
            this.btn_iade.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iade.Name = "btn_iade";
            this.btn_iade.Size = new System.Drawing.Size(108, 53);
            this.btn_iade.TabIndex = 20;
            this.btn_iade.Text = "İade Et";
            this.btn_iade.UseVisualStyleBackColor = false;
            this.btn_iade.Click += new System.EventHandler(this.btn_iade_Click_1);
            // 
            // lbl_borc
            // 
            this.lbl_borc.AutoSize = true;
            this.lbl_borc.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_borc.Location = new System.Drawing.Point(816, 9);
            this.lbl_borc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_borc.Name = "lbl_borc";
            this.lbl_borc.Size = new System.Drawing.Size(122, 48);
            this.lbl_borc.TabIndex = 21;
            this.lbl_borc.Text = "lbl_borc";
            // 
            // panelEmanet
            // 
            this.panelEmanet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmanet.Controls.Add(this.dataGridViewEmanet);
            this.panelEmanet.Location = new System.Drawing.Point(791, 63);
            this.panelEmanet.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmanet.Name = "panelEmanet";
            this.panelEmanet.Size = new System.Drawing.Size(745, 516);
            this.panelEmanet.TabIndex = 18;
            // 
            // tbl_emanetBindingSource
            // 
            this.tbl_emanetBindingSource.DataMember = "tbl_emanet";
            this.tbl_emanetBindingSource.DataSource = this.db_kutuphaneDataSet;
            // 
            // tbl_emanetTableAdapter
            // 
            this.tbl_emanetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_emanetTableAdapter = this.tbl_emanetTableAdapter;
            this.tableAdapterManager.tbl_kitapTableAdapter = null;
            this.tableAdapterManager.tbl_ogrenciTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_kitapTableAdapter
            // 
            this.tbl_kitapTableAdapter.ClearBeforeFill = true;
            // 
            // OgrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1648, 693);
            this.Controls.Add(this.panelEmanet);
            this.Controls.Add(this.lbl_borc);
            this.Controls.Add(this.btn_iade);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.lbl_hosgeldiniz);
            this.Controls.Add(this.panelKitaplar);
            this.Controls.Add(this.btn_emanet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OgrenciIslemleri";
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.OgrenciIslemleri_Load);
            this.panelKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblkitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).EndInit();
            this.panelEmanet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_emanetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_emanet;
        private System.Windows.Forms.Panel panelKitaplar;
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.Label lbl_hosgeldiniz;
        private System.Windows.Forms.DataGridView dataGridViewEmanet;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_iade;
        private System.Windows.Forms.Label lbl_borc;
        private System.Windows.Forms.Panel panelEmanet;
        private db_kutuphaneDataSet db_kutuphaneDataSet;
        private System.Windows.Forms.BindingSource tbl_emanetBindingSource;
        private db_kutuphaneDataSetTableAdapters.tbl_emanetTableAdapter tbl_emanetTableAdapter;
        private db_kutuphaneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tblkitapBindingSource;
        private db_kutuphaneDataSetTableAdapters.tbl_kitapTableAdapter tbl_kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
    }
}