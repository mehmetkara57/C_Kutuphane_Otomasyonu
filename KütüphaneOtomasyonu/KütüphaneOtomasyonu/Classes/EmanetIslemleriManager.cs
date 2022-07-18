using Kutuphane.DataAccess.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Business.Classes
{
    
       
        public class EmanetIslemleriManager
        {
            DataSet dataSet;
            EmanetIslemleri emanetIslemleri;
           
       public DataSet listele()
        {
            dataSet = new DataSet();
            emanetIslemleri = new EmanetIslemleri(); // Veritabanında EmanetIslemlerinden nesne oluşturdum

            dataSet = emanetIslemleri.listele(); // listele fonksiyonunu çağırdım

            return dataSet;
        }
        
        public Boolean kitapAlma(int ogrenciID, int kitapID)
        {
            emanetIslemleri = new EmanetIslemleri();

            int borc = 0;
            DateTime emanetTarihi = DateTime.Now;
            DateTime teslimTarihi = emanetTarihi.AddDays(15);
            Boolean teslimDurumu = false;

            OgrenciManager ogrenciManager = new OgrenciManager();
            KitapManager kitapManager = new KitapManager();

            DataSet dataSetOgrenci = ogrenciManager.ara(ogrenciID); 
            DataSet dataSetKitap = kitapManager.ara(kitapID);

            Boolean kitapAlabilirMi = Boolean.Parse(dataSetOgrenci.Tables[0].Rows[0]["kitapAlabilirMi"].ToString());
            int kitapStok = Int32.Parse(dataSetKitap.Tables[0].Rows[0]["stok"].ToString());

            // Kontrol işlemlerini yaptım(kitap alma& stok sayısı)
            if (kitapAlabilirMi & kitapStok > 0)
            {
                emanetIslemleri.kitapAlma(ogrenciID, kitapID, borc, teslimTarihi.Date, emanetTarihi.Date, teslimDurumu);
                return true; 
            }
            else
            {
                return false; 
            }
        }
        
        public Boolean kitapIade(int islemID, int kitapID, int ogrenciID)
        {
            emanetIslemleri = new EmanetIslemleri();
            DataSet dataSet = emanetIslemleri.dahaOnceTeslimEdildiMi(islemID);

            // emanetIslemlerinden gelen teslim durumunu aldım
            Boolean kontrol = Boolean.Parse(dataSet.Tables[0].Rows[0]["teslimDurumu"].ToString());

            if (!kontrol) // teslim durumunu kontrol ettim
            {
                emanetIslemleri.kitapIade(islemID, kitapID, ogrenciID);

                OgrenciManager ogrenciManager = new OgrenciManager();
                ogrenciManager.guncelle(ogrenciID, 0);

                return true;
            }
            else // teslim işlemini yapma denildi
            {
                return false;
            }
        }
        
        public DataSet ara(int id, String ogrenci_kitap)// ara fonksyinonunu çağrıldı
        {
            emanetIslemleri = new EmanetIslemleri();

            dataSet = emanetIslemleri.ara(id, ogrenci_kitap);

            return dataSet;
        }
        
        public void borcHesapla()
        {
            emanetIslemleri = new EmanetIslemleri();
            DataSet dataSetEmanet = emanetIslemleri.getborcHesapla(); // borç hesaplama işlemleri başladı

            foreach (DataRow row in dataSetEmanet.Tables[0].Rows) // her emanet işlemi için borç hesaplaması yaptım
            {
                int ogrenciID = Int32.Parse(row[0].ToString());
                DateTime teslimTarihi = DateTime.Parse(row[1].ToString());
                Boolean teslimDurumu = Boolean.Parse(row[2].ToString());

                DateTime now = DateTime.Now;

                if (!teslimDurumu) // teslim edilmemişse
                {
                    if (now > teslimTarihi) // teslim tarihi geçmişse
                    {
                        Ogrenci ogrenci = new Ogrenci();

                        TimeSpan gecikenGun = now.Subtract(teslimTarihi); 

                        int borc = gecikenGun.Days; // geciken günü borca eşitle

                        ogrenci.guncelle(ogrenciID, borc); // öğrencinin borç verisini güncelle
                    }
                }
            }
        }
       
        public int emanetVerilenKitapSayisi()
        {
            emanetIslemleri = new EmanetIslemleri();

            int emanetVerilenKitapSayisi = emanetIslemleri.emanetVerilenKitapSayisi();

            return emanetVerilenKitapSayisi;
        }
        
    }
}
