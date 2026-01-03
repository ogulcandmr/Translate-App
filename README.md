# 🌍 C# Çoklu Dil Çeviri Uygulaması (Google Translate Altyapılı)

Bu proje, C# Windows Forms kullanılarak geliştirilmiş, hızlı ve pratik bir masaüstü çeviri uygulamasıdır. Google Translate altyapısını kullanan `GTranslate` kütüphanesi sayesinde, API anahtarı gerektirmeden anlık çeviri yapabilir.

## 🚀 Özellikler

* **Çoklu Dil Desteği:** İngilizce, Türkçe, Almanca, Fransızca, İspanyolca ve Rusça dilleri arasında çeviri.
* **Otomatik Dil Algılama:** Kaynak metnin dilini otomatik olarak tanır, sadece hedef dili seçmeniz yeterlidir.
* **Dinamik Arayüz:** Çeviri sonucu, işlem tamamlandığında açılan özel bir panel içerisinde gösterilir (Gizli Panel Mantığı).
* **Asenkron Çalışma:** Çeviri yapılırken arayüz donmaz, kullanıcı deneyimi akıcıdır.
* **API Anahtarı Gerektirmez:** Ücretsiz `GTranslate` kütüphanesi kullanılır.

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Arayüz:** Windows Forms Application (WinForms)
* **Platform:** .NET Framework veya .NET Core
* **Kütüphane:** [GTranslate](https://github.com/marcosrg/gtranslate) (NuGet)

## 📦 Kurulum ve Çalıştırma

Projeyi kendi bilgisayarınızda çalıştırmak için şu adımları izleyin:

1.  **Projeyi İndirin:**
    Bu repoyu bilgisayarınıza klonlayın veya ZIP olarak indirip açın.

2.  **Visual Studio ile Açın:**
    `.sln` uzantılı dosyayı çift tıklayarak projeyi Visual Studio'da açın.

3.  **Kütüphaneleri Yükleyin:**
    Proje `GTranslate` paketine bağımlıdır. Çözüm Gezgini'nde (Solution Explorer) projeye sağ tıklayın ve **"Restore NuGet Packages"** diyerek eksik paketleri otomatik yükleyin.
    *Alternatif olarak:* `Package Manager Console` üzerinden şu komutu çalıştırabilirsiniz:
    ```powershell
    Install-Package GTranslate
    ```

4.  **Başlatın:**
    `F5` tuşuna basarak veya "Start" butonuna tıklayarak uygulamayı çalıştırın.

## 💻 Kod Yapısı Hakkında Notlar

* **Panel Yönetimi:** Sonuç kutusu (`txtSonuc`), varsayılan olarak gizli (`Visible = false`) olan `pnlSonuc` paneli içerisindedir. "Çevir" butonuna basıldığında ve veri başarılı bir şekilde çekildiğinde bu panel görünür hale gelir.
* **AggregateTranslator:** Uygulama, çeviri için en uygun servisi (Google, Bing, Yandex vb.) otomatik seçen `AggregateTranslator` sınıfını kullanır.

## ⚠️ Yasal Uyarı

Bu proje eğitim ve kişisel kullanım amaçlıdır. Kullanılan `GTranslate` kütüphanesi, Google Translate'in web arayüzünü kullanır. Ticari veya çok yoğun kullanımlarda Google IP adresinizi geçici olarak kısıtlayabilir.

## 🤝 Katkıda Bulunma

Geliştirmek isterseniz:
1.  Bu projeyi Fork'layın.
2.  Yeni özellikler ekleyin (Örn: "Panoya Kopyala" butonu, Sesli Okuma özelliği).
3.  Pull Request gönderin.

---MEHMET YUSUF YILIKOĞLU
