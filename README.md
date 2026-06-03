# TRT Çocuk Yarışçı (2009) - Bug Fix & Server Bypass

Bu proje, 2009 yapımı "TRT Çocuk Yarışçı" oyununun decompiled edilmiş kaynak kodlarını da içeren ve araç seçim bug'ı fixlenmiş halidir.



 **Araç Seçim Ekranı Enter (Giriş) Tuşu Bug'ı:**
   - Orijinal oyunda yüksek FPS alındığı için `FixedUpdate` döngüsü arasına sıkışan klavye girdileri (özellikle araç seçmek için kullanılan Enter tuşu) yakalanamıyordu. Girdi dinleyicileri `Update` fonksiyonuna taşınarak bu sorun tamamen çözüldü. Artık çok hızlı basmaya gerek kalmadan tek bir basışta araç seçilebiliyor.

   Oyun açıldığında kullanıcı adı ve şifre soruyor, gelen kullanıcı adı şifreyi, aynı zamanda oyun sonunda yaptığımız skoru yollarken de aynı şekilde geçersiz sunucuya yolluyordu, bunlar fixlendi.


##  Kurulum (Nasıl Yüklenir?)

Bu repoda bulunan `Assembly - UnityScript.dll` dosyası, tüm düzeltmeleri ve bypass işlemlerini içeren derlenmiş ana yama dosyasıdır. Yamayı kurmak için şu adımları izleyin:

1. Bilgisayarınızdaki TRT Çocuk Yarışçı oyununun kurulu olduğu ana dizine gidin.
2. `trt cocuk yarisci_Data` klasörünün içine girin.
3. Repodan indirdiğiniz `Assembly - UnityScript.dll` dosyasını bu klasörün içine (ana dizine) kopyalayın ve mevcut dosyanın üzerine yazın.
   > **Not:** Her ihtimale karşı orijinal `Assembly - UnityScript.dll` dosyanızın bir yedeğini (`.bak` uzantısı vb. ekleyerek) almayı unutmayın.
4. Oyunu (`trt cocuk yarisci.exe`) çalıştırın ve yeni özelliklerle oynamaya başlayın!

## 🔧 Geliştirme (Kendin Derle)

Projedeki değiştirilmiş açık kaynak kodlar `DecompiledUnityScript` klasöründe bulunmaktadır. Kodlar olabildiğince sade tutulmuş ve derleyici tarafından eklenen gereksiz yorum satırları (`//IL_0000...`) temizlenmiştir. Kendi düzenlemelerinizi yapmak isterseniz kodları inceleyebilir, ardından `dotnet build` komutuyla kendi DLL dosyanızı derleyebilirsiniz.
