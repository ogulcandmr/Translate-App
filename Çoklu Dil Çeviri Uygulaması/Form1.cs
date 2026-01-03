using System;
using System.Windows.Forms;
using GTranslate.Translators; // İndirdiğimiz kütüphaneyi çağırıyoruz

namespace Çoklu_Dil_Çeviri_Uygulaması
{
    public partial class Form1 : Form
    {
        // Çeviri işini yapacak olan aracı tanımlıyoruz
        AggregateTranslator cevirmen;

        public Form1()
        {
            InitializeComponent();
            // Çevirmen aracını oluşturuyoruz
            cevirmen = new AggregateTranslator();
        }

        // Dil listesi için yardımcı bir yapı (Sınıf)
        public class DilSecenegi
        {
            public string Isim { get; set; } // Ekranda görünecek (Türkçe)
            public string Kod { get; set; }  // Google'ın anladığı (tr)

            // ComboBox bu fonksiyonu kullanarak ekranda ne göstereceğini bilir
            public override string ToString()
            {
                return Isim;
            }
        }

        // Program ilk açıldığında çalışacak kodlar
        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox'a dilleri ekleyelim
            cmbDiller.Items.Add(new DilSecenegi { Isim = "İngilizce", Kod = "en" });
            cmbDiller.Items.Add(new DilSecenegi { Isim = "Türkçe", Kod = "tr" });
            cmbDiller.Items.Add(new DilSecenegi { Isim = "Almanca", Kod = "de" });
            cmbDiller.Items.Add(new DilSecenegi { Isim = "Fransızca", Kod = "fr" });
            cmbDiller.Items.Add(new DilSecenegi { Isim = "İspanyolca", Kod = "es" });
            cmbDiller.Items.Add(new DilSecenegi { Isim = "Rusça", Kod = "ru" });

            // İlk açılışta İngilizce seçili olsun (Listede 0. sırada)
            cmbDiller.SelectedIndex = 0;
        }

        // ÇEVİR butonuna tıklanınca çalışacak kodlar
        // "async" kelimesi önemli, programın donmasını engeller
        private async void btnCevir_Click(object sender, EventArgs e)
        {
            // 1. Kutuda yazı var mı kontrol et
            if (string.IsNullOrWhiteSpace(txtGiris.Text))
            {
                MessageBox.Show("Lütfen çevrilecek bir şeyler yazın!");
                return;
            }

            // 2. Butonu kilitle ki kullanıcı üst üste basmasın
            btnCevir.Enabled = false;
            btnCevir.Text = "Çevriliyor...";

            try
            {
                // 3. Seçilen hedef dili al
                DilSecenegi secilenDil = (DilSecenegi)cmbDiller.SelectedItem;

                // 4. ÇEVİRİ İŞLEMİ (Kütüphaneyi kullanıyoruz)
                // Kaynak dili otomatik algılar, biz sadece hedefi (secilenDil.Kod) veriyoruz.
                var sonuc = await cevirmen.TranslateAsync(txtGiris.Text, secilenDil.Kod);

                // 5. Sonucu ekrana yaz
                txtSonuc.Text = sonuc.Translation;
                panel2.Visible = true;
            }
            catch (Exception hata)
            {
                // Bir sorun olursa (İnternet yoksa vs.)
                MessageBox.Show("Bir hata oluştu: " + hata.Message);
            }
            finally
            {
                // 6. İşlem bitince butonu eski haline getir
                btnCevir.Enabled = true;
                btnCevir.Text = "ÇEVİR";
                
            }
        }

        // Bu kısım butonu ve olayı bağlamak için gereklidir.
        // Eğer Designer üzerinden çift tıklayarak butonu açtıysan buraya gerek yok
        // ama kod kopyalarken butonun "Click" olayının bağlı olduğundan emin olmalısın.
    }
}