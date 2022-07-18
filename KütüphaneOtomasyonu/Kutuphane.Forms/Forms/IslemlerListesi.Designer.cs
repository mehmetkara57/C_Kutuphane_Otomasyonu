
namespace Kutuphane.Forms
{
    partial class IslemlerListesi
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
            this.button_kitaplar = new System.Windows.Forms.Button();
            this.button_ogrenciler = new System.Windows.Forms.Button();
            this.button_islemler = new System.Windows.Forms.Button();
            this.button_grafik = new System.Windows.Forms.Button();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.dataGridViewIslemler = new System.Windows.Forms.DataGridView();
            this.tblemanetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kutuphaneDataSet = new Kutuphane.Forms.db_kutuphaneDataSet();
            this.tbl_emanetTableAdapter = new Kutuphane.Forms.db_kutuphaneDataSetTableAdapters.tbl_emanetTableAdapter();
            this.tblemanetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemanetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemanetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_kitaplar
            // 
            this.button_kitaplar.BackColor = System.Drawing.Color.Teal;
            this.button_kitaplar.Location = new System.Drawing.Point(304, 42);
            this.button_kitaplar.Name = "button_kitaplar";
            this.button_kitaplar.Size = new System.Drawing.Size(137, 68);
            this.button_kitaplar.TabIndex = 0;
            this.button_kitaplar.Text = "Kitaplar";
            this.button_kitaplar.UseVisualStyleBackColor = false;
            this.button_kitaplar.Click += new System.EventHandler(this.btn_kitaplar_Click);
            this.button_kitaplar.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.button_kitaplar.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // button_ogrenciler
            // 
            this.button_ogrenciler.BackColor = System.Drawing.Color.Teal;
            this.button_ogrenciler.Location = new System.Drawing.Point(518, 42);
            this.button_ogrenciler.Name = "button_ogrenciler";
            this.button_ogrenciler.Size = new System.Drawing.Size(137, 68);
            this.button_ogrenciler.TabIndex = 1;
            this.button_ogrenciler.Text = "ogrenciler";
            this.button_ogrenciler.UseVisualStyleBackColor = false;
            this.button_ogrenciler.Click += new System.EventHandler(this.btn_ogrenciler_Click);
            this.button_ogrenciler.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.button_ogrenciler.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // button_islemler
            // 
            this.button_islemler.BackColor = System.Drawing.Color.Teal;
            this.button_islemler.Location = new System.Drawing.Point(736, 42);
            this.button_islemler.Name = "button_islemler";
            this.button_islemler.Size = new System.Drawing.Size(137, 68);
            this.button_islemler.TabIndex = 2;
            this.button_islemler.Text = "İşlemler";
            this.button_islemler.UseVisualStyleBackColor = false;
            // 
            // button_grafik
            // 
            this.button_grafik.BackColor = System.Drawing.Color.Teal;
            this.button_grafik.Location = new System.Drawing.Point(975, 42);
            this.button_grafik.Name = "button_grafik";
            this.button_grafik.Size = new System.Drawing.Size(137, 68);
            this.button_grafik.TabIndex = 3;
            this.button_grafik.Text = "Grafik";
            this.button_grafik.UseVisualStyleBackColor = false;
            this.button_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            this.button_grafik.MouseLeave += new System.EventHandler(this.button_mouseleave);
            this.button_grafik.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // panelIslemler
            // 
            this.panelIslemler.Controls.Add(this.dataGridViewIslemler);
            this.panelIslemler.Location = new System.Drawing.Point(152, 130);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(1151, 393);
            this.panelIslemler.TabIndex = 4;
            // 
            // dataGridViewIslemler
            // 
            this.dataGridViewIslemler.AllowUserToAddRows = false;
            this.dataGridViewIslemler.AllowUserToDeleteRows = false;
            this.dataGridViewIslemler.AllowUserToResizeColumns = false;
            this.dataGridViewIslemler.AllowUserToResizeRows = false;
            this.dataGridViewIslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIslemler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewIslemler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIslemler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIslemler.EnableHeadersVisualStyles = false;
            this.dataGridViewIslemler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewIslemler.MultiSelect = false;
            this.dataGridViewIslemler.Name = "dataGridViewIslemler";
            this.dataGridViewIslemler.ReadOnly = true;
            this.dataGridViewIslemler.RowHeadersVisible = false;
            this.dataGridViewIslemler.RowHeadersWidth = 51;
            this.dataGridViewIslemler.RowTemplate.Height = 24;
            this.dataGridViewIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIslemler.ShowCellToolTips = false;
            this.dataGridViewIslemler.ShowEditingIcon = false;
            this.dataGridViewIslemler.Size = new System.Drawing.Size(1151, 393);
            this.dataGridViewIslemler.TabIndex = 0;
            this.dataGridViewIslemler.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewIslemler_ColumnAdded);
            // 
            // tblemanetBindingSource
            // 
            this.tblemanetBindingSource.DataMember = "tbl_emanet";
            this.tblemanetBindingSource.DataSource = this.db_kutuphaneDataSet;
            // 
            // db_kutuphaneDataSet
            // 
            this.db_kutuphaneDataSet.DataSetName = "db_kutuphaneDataSet";
            this.db_kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_emanetTableAdapter
            // 
            this.tbl_emanetTableAdapter.ClearBeforeFill = true;
            // 
            // tblemanetBindingSource1
            // 
            this.tblemanetBindingSource1.DataMember = "tbl_emanet";
            this.tblemanetBindingSource1.DataSource = this.db_kutuphaneDataSet;
            // 
            // IslemlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1503, 535);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.button_grafik);
            this.Controls.Add(this.button_islemler);
            this.Controls.Add(this.button_ogrenciler);
            this.Controls.Add(this.button_kitaplar);
            this.Name = "IslemlerListesi";
            this.Text = "İşlemler Listesi";
            this.Load += new System.EventHandler(this.IslemlerListesi_Load);
            this.panelIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemanetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemanetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_kitaplar;
        private System.Windows.Forms.Button button_ogrenciler;
        private System.Windows.Forms.Button button_islemler;
        private System.Windows.Forms.Button button_grafik;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.DataGridView dataGridViewIslemler;
        private db_kutuphaneDataSet db_kutuphaneDataSet;
        private System.Windows.Forms.BindingSource tblemanetBindingSource;
        private db_kutuphaneDataSetTableAdapters.tbl_emanetTableAdapter tbl_emanetTableAdapter;
        private System.Windows.Forms.BindingSource tblemanetBindingSource1;
    }
}