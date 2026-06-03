using UnityEngine;

public class Sorular : MonoBehaviour
{
	private string[] baslangicSorularListe;

	private string[,] baslangicCevaplarListe;

	private string[] sonSorularListe;

	private string[,] sonCevaplarListe;

	private int baslangicSoruSayisi = 98;

	private int sonSoruSayisi = 29;

	private string[] baslangicSorular;

	private string[,] baslangicCevaplar;

	private string[] sonSorular;

	private string[,] sonCevaplar;

	private void Start()
	{
		baslangicSorular = new string[4];
		baslangicCevaplar = new string[4, 2];
		sonSorular = new string[5];
		sonCevaplar = new string[5, 2];
		sorularInitialize();
		randomSoruDoldur();
		((Component)this).gameObject.SendMessage("sorulariAl", (object)baslangicSorular);
		((Component)this).gameObject.SendMessage("cevaplariAl", (object)cevapAl(baslangicCevaplar, 4));
	}

	public void sorulariSec(int soruSayi)
	{
		((Component)this).gameObject.SendMessage("sorulariAlSonu", (object)soruAl(sonSorular, soruSayi));
		((Component)this).gameObject.SendMessage("cevaplariAlSonu", (object)cevapAl(sonCevaplar, soruSayi));
	}

	private string[] soruAl(string[] soru, int soruSayi)
	{
		string[] array = new string[soruSayi];
		for (int i = 0; i < soruSayi; i++)
		{
			array[i] = soru[i];
		}
		return array;
	}

	private string[] cevapAl(string[,] cevaplar, int soruSayi)
	{
		string[] array = new string[soruSayi * 2];
		for (int i = 0; i < soruSayi; i++)
		{
			array[i * 2] = cevaplar[i, 0];
			array[i * 2 + 1] = cevaplar[i, 1];
		}
		return array;
	}

	private void randomSoruDoldur()
	{
		ilkSorularDoldur();
		sonSorularDoldur();
	}

	private void ilkSorularDoldur()
	{
		int[] array = new int[4] { -1, -1, -1, -1 };
		int num = 0;
		while (num < 4)
		{
			int num2 = Random.Range(0, baslangicSoruSayisi);
			if (!randomKontrol(num2, array))
			{
				array[num] = num2;
				baslangicSorular[num] = baslangicSorularListe[num2];
				baslangicCevaplar[num, 0] = baslangicCevaplarListe[num2, 0];
				baslangicCevaplar[num, 1] = baslangicCevaplarListe[num2, 1];
				num++;
			}
		}
	}

	private bool randomKontrol(int secilen, int[] secilenSorular)
	{
		bool result = false;
		for (int i = 0; i < 3; i++)
		{
			if (secilenSorular[i] == secilen)
			{
				result = true;
			}
		}
		return result;
	}

	private void sonSorularDoldur()
	{
		int[] array = new int[5] { -1, -1, -1, -1, -1 };
		int num = 0;
		while (num < 5)
		{
			int num2 = Random.Range(0, sonSoruSayisi);
			if (!randomKontrol(num2, array))
			{
				array[num] = num2;
				sonSorular[num] = sonSorularListe[num2];
				sonCevaplar[num, 0] = sonCevaplarListe[num2, 0];
				sonCevaplar[num, 1] = sonCevaplarListe[num2, 1];
				num++;
			}
		}
	}

	private void sorularInitialize()
	{
		baslangicSorularListe = new string[99]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
			"21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
			"31", "32", "33", "34", "35", "36", "37", "38", "39", "40",
			"41", "42", "43", "44", "45", "46", "47", "48", "49", "50",
			"51", "52", "53", "54", "55", "56", "57", "58", "59", "60",
			"61", "62", "63", "64", "65", "66", "67", "68", "69", "70",
			"71", "72", "73", "74", "75", "76", "77", "78", "79", "80",
			"81", "82", "83", "84", "85", "86", "87", "88", "89", "90",
			"91", "92", "93", "94", "95", "96", "97", "98", "99"
		};
		baslangicCevaplarListe = new string[99, 2]
		{
			{ "Yol Ver", "Dur" },
			{ "Dur", "Yol Ver" },
			{ "Karşıdan Gelene Yol Ver", "Sollamak Yasaktır" },
			{ "Girişi Olmayan Yol", "Çıkmaz Sokak" },
			{ "Taşıt Trafiğine Kapalı Yol", "Yol Ver" },
			{ "Motosiklet Hariç Taşıt Trafiğine Kapalı Yol", "Taşıt Trafiğine Kapalı Yol" },
			{ "Motosiklet Giremez", "Mopet Giremez" },
			{ "Bisiklet Giremez", "Mecburi Bisiklet Yolu" },
			{ "Mopet Giremez", "Bisiklet Giremez" },
			{ "Kamyon Giremez", "Traktör Giremez" },
			{ "Otobüs Giremez", "Treyler Giremez" },
			{ "Treyler Giremez", "Otobüs Giremez" },
			{ "Yaya Giremez", "Mecburi Yaya Yolu" },
			{ "At Arabası Giremez", "Traktör Giremez" },
			{ "El Arabası Giremez", "Yaya Giremez" },
			{ "Traktör Giremez", "Kamyon Giremez" },
			{ "Belirli Miktarlardan Fazla Patlayıcı ve Parlayıcı Madde Taşıyan Taşıt Giremez", "Belirli Miktarlardan Fazla Su Kirletici Madde Taşıyan Taşıt Giremez" },
			{ "Tehlikeli Madde Taşıyan Taşıt Giremez", "Belirli Miktarlardan Fazla Patlayıcı ve Parlayıcı Madde Taşıyan Taşıt Giremez" },
			{ "Belirli Miktarlardan Fazla Su Kirletici Madde Taşıyan Taşıt Giremez", "Tehlikeli Madde Taşıyan Taşıt Giremez" },
			{ "Motorlu Taşıt Giremez", "Taşıt Giremez" },
			{ "Taşıt Giremez", "Motorlu Taşıt Giremez" },
			{ "Genişliği 2,30 Metreden Fazla Olan Taşıt Giremez", "Uzunluğu 10 Metreden Fazla Olan Taşıt Giremez" },
			{ "Yüksekliği 3,50 Metreden Fazla Olan Taşıt Giremez", "Uzunluğu 10 Metreden Fazla Olan Taşıt Giremez" },
			{ "Uzunluğu 10 Metreden Fazla Olan Taşıt Giremez", "Yük Ağırlığı 7 Tondan Fazla Yük Düşen Taşıt Giremez" },
			{ "Dingil Başına 6 Tondan Fazla Yük Düşen Taşıt Giremez", "Yük Ağırlığı 7 Tondan Fazla Yük Düşen Taşıt Giremez" },
			{ "Yük Ağırlığı 7 Tondan Fazla Yük Düşen Taşıt Giremez", "Dingil Başına 6 Tondan Fazla Yük Düşen Taşıt Giremez" },
			{ "Öndeki Taşıt 70 Metreden Daha Yakın Takip Edilemez", "Uzunluğu 10 Metreden Fazla Olan Taşıt Giremez" },
			{ "Sağa Dönülmez", "Sağa Tehlikeli Viraj" },
			{ "Sola Dönülmez", "Sağa Dönülmez" },
			{ "U Dönüşü Yapılmaz", "Sağa Tehlikeli Devamlı Virajlar" },
			{ "Öndeki Taşıtı Geçmek Yasaktır", "Yük Taşıtlarının Öndeki Taşıtı Geçmesi Yasaktır" },
			{ "Yük Taşıtlarının Öndeki Taşıtı Geçmesi Yasaktır", "Öndeki Taşıtı Geçmek Yasaktır" },
			{ "Azami Hız Sınırlaması", "Mecburi Asgari Hız" },
			{ "Bütün Yasaklama ve Kısıtlamaların Sonu", "Taşıt Giremez" },
			{ "Hız Sınırlaması Sonu", "Mecburi Asgari Hız Sonu" },
			{ "Geçme Yasağı Sonu", "Öndeki Taşıtı Geçmek Yasaktır" },
			{ "Kamyonlar için Geçme Yasağı Sonu", "Yük Taşıtlarının Öndeki Taşıtı Geçmesi Yasaktır" },
			{ "Sağa Mecburi Yön", "İlerden Sağa Mecburi Yön" },
			{ "Sola Mecburi Yön", "İlerden Sola Mecburi Yön" },
			{ "İleri Mecburi Yön", "İleri ve Sola Mecburi Yön" },
			{ "İleri ve Sağa Mecburi Yön", "Sağa ve Sola Mecburi Yön" },
			{ "İleri ve Sola Mecburi Yön", "Sağa ve Sola Mecburi Yön" },
			{ "Sağa ve Sola Mecburi Yön", "Her İki Yandan Gidiniz" },
			{ "İlerden Sağa Mecburi Yön", "Sağdan Gidiniz" },
			{ "İlerden Sola Mecburi Yön", "Soldan Gidiniz" },
			{ "Sağdan Gidiniz", "Sağa Mecburi Yön" },
			{ "Soldan Gidiniz", "Sola Mecburi Yön" },
			{ "Her İki Yandan Gidiniz", "Sağa ve Sola Mecburi Yön" },
			{ "Ada Etrafında Dönünüz", "Dönel Kavşak" },
			{ "Mecburi Bisiklet Yolu", "Bisiklet Geçebilir" },
			{ "Mecburi Bisiklet Yolu Sonu", "Bisiklet Giremez" },
			{ "Mecburi Yaya Yolu", "Yaya Geçidi" },
			{ "Mecburi Yaya Yolu Sonu", "Yaya Giremez" },
			{ "Mecburi Atlı Yolu", "At Arabası Giremez" },
			{ "Mecburi Atlı Yolu Sonu", "At Arabası Giremez" },
			{ "Mecburi Asgari Hız", "Azami Hız Sınırlaması" },
			{ "Mecburi Asgari Hız Sonu", "Hız Sınırlaması Sonu" },
			{ "Zincir Takmak Mecburidir", "Kaygan Yol" },
			{ "Zincir Takma Mecburiyeti Sonu", "Dikkat" },
			{ "Tehlikeli Madde Taşıyan Taşıtlar için Sola Mecburi Yön", "Sola Mecburi Yön" },
			{ "Tehlikeli Madde Taşıyan Taşıtlar için İleri Mecburi Yön", "İleri Mecburi Yön" },
			{ "Tehlikeli Madde Taşıyan Taşıtlar için Sağa Mecburi Yön", "Sağa Mecburi Yön" },
			{ "Sesli İkaz Cihazlarinin Kullanimi Yasaktir", "Işıklı İşaret Cihazı" },
			{ "Sağa Tehlikeli Viraj", "Sağa Tehlikeli Devamlı Virajlar" },
			{ "Sola Tehlikeli Viraj", "Sola Tehlikeli Devamlı Virajlar" },
			{ "Sağa Tehlikeli Devamlı Virajlar", "Sağa Tehlikeli Viraj" },
			{ "Sola Tehlikeli Devamlı Virajlar", "Sola Tehlikeli Viraj" },
			{ "Tehlikeli Eğim (İniş)", "Tehlikeli Eğim (Çıkış)" },
			{ "Tehlikeli Eğim (Çıkış)", "Tehlikeli Eğim (İniş)" },
			{ "İki Taraftan Daralan Kaplama", "Soldan Daralan Kaplama" },
			{ "Ehli Hayvanlar Geçebilir", "Vahşi Hayvanlar Geçebilir" },
			{ "Vahşi Hayvanlar Geçebilir", "Ehli Hayvanlar Geçebilir" },
			{ "Yolda Çalışma Var", "Kasisli Yol" },
			{ "Işıklı İşaret Cihazı", "Sesli İkaz Cihazlarinin Kullanimi Yasaktir" },
			{ "Havaalanı - Havalimanı (alçak-uçuş)", "Yandan Rüzgar" },
			{ "Yandan Rüzgar", "Gizli Buzlanma" },
			{ "İki Yönlü Trafik", "Karşıdan Gelene Yol Ver" },
			{ "Sagdan Daralan Kaplama", "Soldan Daralan Kaplama" },
			{ "Soldan Daralan Kaplama", "Sagdan Daralan Kaplama" },
			{ "Açılan Köprü", "Deniz veya Nehir Kıyısında Biten Yol" },
			{ "Deniz veya Nehir Kıyısında Biten Yol", "Açılan Köprü" },
			{ "Kasisli Yol", "Kaygan Yol" },
			{ "Kaygan Yol", "Gevşek Malzemeli Zemin" },
			{ "Gevşek Malzemeli Zemin", "Kaygan Yol" },
			{ "Dikkat", "Bütün Yasaklama ve Kısıtlamaların Sonu" },
			{ "Kontrolsüz Kavşak", "Dönel Kavşak" },
			{ "Ana Yol-Tali Yol Kavşağı", "Sağa ve Sola Mecburi Yön" },
			{ "Ana Yol-Tali Yol Kavşağı", "Sağa Mecburi Yön" },
			{ "Ana Yol-Tali Yol Kavşağı", "Sola Mecburi Yön" },
			{ "Ana Yol-Tali Yol Kavşağı", "İki Taraftan Daralan Kaplama" },
			{ "Ana Yol-Tali Yol Kavşağı", "Kasisli Yol" },
			{ "Gevşek Şev", "Kasisli Yol" },
			{ "Yaya Geçidi", "Okul Geçidi" },
			{ "Okul Geçidi", "Yaya Geçidi" },
			{ "Bisiklet Geçebilir", "Mecburi Bisiklet Yolu" },
			{ "Gizli Buzlanma", "Kaygan Yol" },
			{ "Kontrollü Demir Yolu Geçidi", "Kontrolsüz Demir Yolu Geçidi" },
			{ "Kontrolsüz Demir Yolu Geçidi", "Kontrollü Demir Yolu Geçidi" },
			{ "Dönel Kavşak", "Ada Etrafında Dönünüz" }
		};
		sonSorularListe = new string[29]
		{
			"Aşağıdaki ülkelerden hangisinde trafik soldan akar?", "Aşağıdaki ülkelerden hangisinde trafik, diğerlerinden ters yönde akar?", "Aşağıdaki ülkelerden hangisinde trafik sağdan akar?", "İngiltere ile Fransa’yı birbirine bağlayan denizaltı tünelinin adı nedir?", "İstanbul’da “İkinci Köprü” olarak adlandırılan boğaz köprüsünün tam adı nedir?", "İstanbul’da ilk boğaz köprüsü kaç yılında tamamlanmıştır?", "Yapımı süren, İstanbul Boğazı’nı denizin altından kat ederek Asya ile Avrupa’yı birleştirecek tünelin adı nedir?", "Dünyanın tamamlanmış en uzun asma köprüsü hangisidir?", "Fatih Sultan Mehmet Köprüsü, dünyanın kaçıncı en uzun asma köprüsüdür?", "Dünyanın en uzun araç trafiğine açık tüneli hangisidir?",
			"Dünyanın en uzun ulaşım tüneli hangisidir?", "Dünyanın ulaşıma açık en uzun sualtı tüneli hangisidir?", "Manş Tüneli hangi ülkeleri birbirine bağlar?", "Boğaziçi Köprüsü’nün ayakları  İstanbul’da hangi semtlerde yer alır?", "Türkiye’nin en uzun karayolu tüneli hangisidir?", "Yerleşim yerleri içinde otomobillerin yasal hız sınırı nedir?", "Otoyollarda otomobillerin yasal hız sınırı nedir?", "Türkiye’de hizmete açık otoyol uzunluğu kaç km’dir?", "Türkiye’de makine ile yol yapımına hangi yılda başlanmıştır?", "Karayolları Genel Müdürlüğü ne zaman kurulmuştur?",
			"“Emniyet şeridi” aşağıdakilerden hangisi için kullanılamaz?", "Aşağıdaki araçlardan hangisinde geri vites bulunmaz?", "Ambulansların önündeki “Ambulans” yazısı neden tersten yazılır?", "Ambulans sireni çaldığında, diğer araçlar ne yapmalıdır?", "Aşağıdakilerden hangisinin araçta bulundurulması zorunludur?", "Türkiye’nin en uzun karayolu ağına sahip ili hangisidir?", "Aşağıdakilerden hangisi toplu taşıma aracı değildir?", "B tipi standart araç ehliyetine sahip bir sürücü aşağıdakilerden hangisini kullanamaz?", "Aşağıdakilerden hangisi “motorlu taşıt” değildir?"
		};
		sonCevaplarListe = new string[29, 2]
		{
			{ "İngiltere", "Almanya" },
			{ "Avustralya", "Amerika" },
			{ "Fransa", "Hindistan" },
			{ "Manş Tüneli", "Brenner Tüneli" },
			{ "Fatih Sultan Mehmet Köprüsü", "Boğaziçi Köprüsü" },
			{ "1973", "1983" },
			{ "Marmaray", "Denizray" },
			{ "Akashi-Kaikyo Köprüsü", "Öresund Köprüsü" },
			{ "15", "12" },
			{ "Lærdal Tüneli", "Fréjus Demiryolu Tüneli" },
			{ "Seikan Tüneli", "Brenner Tüneli" },
			{ "Manş Tüneli", "Marmaray" },
			{ "Fransa – İngiltere", "Almanya - İngiltere" },
			{ "Avrupa’da Ortaköy, Asya’da Beylerbeyi", "Avrupa'da Hisarüstü, Asya'da Kavacık" },
			{ "Nefise Akçelik Tüneli", "Bolu Tüneli" },
			{ "50 km/saat", "60 km/saat" },
			{ "120 km/saat", "90 km/saat" },
			{ "1851 km.", "1723 km." },
			{ "1948", "1962" },
			{ "1950", "1960" },
			{ "Yoğun trafikte ek şerit olarak", "Arızalanan aracın kenara çekilmesi" },
			{ "Motosiklet", "Otomobil" },
			{ "Önde giden aracın dikiz aynasından doğru olarak okunması için", "Helikopterden doğru olarak okunması için" },
			{ "Ambulansa yol vermelidir", "Aynı yolda devam etmelidir" },
			{ "Yedek Lastik", "Levye" },
			{ "Konya", "İstanbul" },
			{ "Taksi", "Metro" },
			{ "Motosiklet", "Otomobil" },
			{ "Bisiklet", "Motosiklet" }
		};
	}
}
