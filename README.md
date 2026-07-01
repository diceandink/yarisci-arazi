# TRT Çocuk Yarışçı (2009) - Bug Fix & Server Bypass

Bu proje, 2009 yapımı "TRT Çocuk Yarışçı" oyununun decompiled edilmiş kaynak kodlarını da içeren ve araç seçim bug'ı fixlenmiş halidir.



 **Neler Düzeltildi?**

1. **Araç Seçim Ekranı Enter (Giriş) Tuşu Bug'ı:**
   - Günümüz bilgisayarları orijinal oyunda yüksek FPS aldığı için `FixedUpdate` döngüsü arasına sıkışan klavye girdileri (özellikle araç seçmek için kullanılan Enter tuşu) yakalanamıyordu. Girdi dinleyicileri `Update` fonksiyonuna taşınarak bu sorun tamamen çözüldü. Artık çok hızlı basmaya gerek kalmadan tek bir seferde araç seçilebiliyor.

2. **Sunucu Sorunları & Bypass:**
   - Oyun açıldığında kullanıcı adı ve şifre soruyor, gelen kullanıcı adı şifreyi ve aynı zamanda oyun sonunda yaptığımız skoru yollarken geçersiz sunucuya yolluyordu. Zararı yoktu ama trt'ye durduk yere istek atmaya gerek yok.
3. **Araç Seçim Ekranı Animasyon Hızı:**
   - Yine yüksek fps'ten dolayı araç seçim menüsünde araçlar saniyede yüzlerce tur atıp fırıldak gibi dönüyordu. Bu animasyonlar FPS'ten bağımsız hale getirilerek araçların normal hızda dönmesi sağlandı.

4. **Soru Ekranı Bekleme Süresi:**
   - Yarış içindeki kum saatlerini topladığımızda açılan soru ekranında cevap verdikten sonraki "gereksiz uzun (yaklaşık 3.5 saniye)" bekleme süresi 1 saniyeye düşürüldü. Artık soruları daha hızlı cevaplayabiliyoruz.
