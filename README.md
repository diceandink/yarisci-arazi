# TRT Çocuk Yarışçı (2009) - Bug Fix & Server Bypass

Bu proje, 2009 yapımı "TRT Çocuk Yarışçı" oyununun decompiled edilmiş kaynak kodlarını da içeren ve araç seçim bug'ı fixlenmiş halidir.



 **Araç Seçim Ekranı Enter (Giriş) Tuşu Bug'ı:**
   - Günümüz bilgisayarları orijinal oyunda yüksek FPS aldığı için `FixedUpdate` döngüsü arasına sıkışan klavye girdileri (özellikle araç seçmek için kullanılan Enter tuşu) yakalanamıyordu. Girdi dinleyicileri `Update` fonksiyonuna taşınarak bu sorun tamamen çözüldü. Artık çok hızlı basmaya gerek kalmadan tek bir seferde araç seçilebiliyor.

   Oyun açıldığında kullanıcı adı ve şifre soruyor, gelen kullanıcı adı şifreyi, aynı zamanda oyun sonunda yaptığımız skoru yollarken de aynı şekilde geçersiz sunucuya yolluyordu, bunlar fixlendi.

