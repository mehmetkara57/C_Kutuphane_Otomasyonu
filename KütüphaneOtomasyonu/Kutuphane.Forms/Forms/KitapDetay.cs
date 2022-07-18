using Kutuphane.Business.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.Forms
{
    public partial class KitapDetay : Form
    {
       
        int kitapID = 0;
        string kitapAdi = "";
        public KitapDetay()
        {
            InitializeComponent();
        }
        public KitapDetay(string kitapAdi) //fonksiyon ile kitap adını aldım
        {
            InitializeComponent();
            this.kitapAdi = kitapAdi;
        }
        public KitapDetay(int kitapID) //fonksiyon ile kitap ID'sini aldım
        {
            InitializeComponent();
            this.kitapID = kitapID;
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KitapDetay_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; 

            KitapManager kitapManager = new KitapManager();
            DataSet dataSet;

            if (kitapID == 0) // Kitap ID ile arama yapılmadıysa diye oluşturdum
            {
                dataSet = kitapManager.ara(kitapAdi); // Ada göre arama yapıldı
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    kitapID = Int32.Parse(dataSet.Tables[0].Rows[0]["ID"].ToString()); // Kitap ID'yi ada göre gelen sonucun ID'sine eşitledim
                }
            }
            else // Kitap ID ile arama yapıldıysa diye oluşturdum
            {
                dataSet = kitapManager.ara(kitapID); // ID'ye göre arama yapıldı
            }
            if (dataSet.Tables[0].Rows.Count > 0)
            { 

                
                lbl_adVal.Text = dataSet.Tables[0].Rows[0]["ad"].ToString();
                lbl_yazarVal.Text = dataSet.Tables[0].Rows[0]["yazar"].ToString();
                lbl_turVal.Text = dataSet.Tables[0].Rows[0]["tur"].ToString();
                lbl_sayfaVal.Text = dataSet.Tables[0].Rows[0]["sayfa"].ToString();
                lbl_stokVal.Text = dataSet.Tables[0].Rows[0]["stok"].ToString();

                EmanetIslemleriManager emanetIslemleriManager = new EmanetIslemleriManager();
                OgrenciManager ogrenciManager = new OgrenciManager();

                dataSet = emanetIslemleriManager.ara(kitapID, "kitap"); // Kitabın emanet verilerini arama yapıldı
                dataGridViewKitapDetay.DataSource = dataSet.Tables[0];

                // Emanet işlemi tablosu oluşturdum
                DataTable tablo = new DataTable();
                tablo.Columns.Add("İşlem ID", typeof(int));
                tablo.Columns.Add("Öğrenci ID", typeof(int));
                tablo.Columns.Add("Öğrenci Adı", typeof(String));
                tablo.Columns.Add("Emanet Tarihi", typeof(DateTime));
                tablo.Columns.Add("Teslim Edilen Tarih", typeof(DateTime));

                foreach (DataGridViewRow row in dataGridViewKitapDetay.Rows) // gelen verileri tabloya aktardım
                {
                    dataSet = ogrenciManager.ara(Int32.Parse(row.Cells["ogrenciID"].Value.ToString()));
                    String ad = dataSet.Tables[0].Rows[0]["ad"].ToString();

                    tablo.Rows.Add(row.Cells["ID"].Value, row.Cells["ogrenciID"].Value, ad, row.Cells["emanetTarihi"].Value, row.Cells["teslimEdilenTarih"].Value);

                }
                dataGridViewKitapDetay.DataSource = tablo; // tablomdaki verileri dataGridView'a aktardım
            }
            else
            {
                MessageBox.Show("Aradığınız kitap bulunamadı..");
                this.Close();
            }
            dataGridViewKitapDetay.ClearSelection();
        }
        private void dataGridViewKitapDetay_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
