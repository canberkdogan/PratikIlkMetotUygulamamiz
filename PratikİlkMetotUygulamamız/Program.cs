//1.Geriye Değer Döndürmeyen Bir void metot.

using System.Reflection.Metadata;

static void SarkiSozu()
{
    Console.WriteLine("Haberin yok ben ölüyorum");
}
// 2. Geriye Tamsayı Döndüren Bir metot

//Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

int RastgeleSayi()
{
    Random random = new Random();
    int sayi = random.Next();
    int bolumdenKalan = sayi % 2;
    return bolumdenKalan;
}

//3. Parametre Alan ve Geriye Değer Döndüren Bir Metot

//Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

int Carpim(int s1, int s2)
{
    return s1 * s2;
}

// 4.Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

//Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.

 void AdSoyad()
{

    Console.WriteLine("Adınız nedir?");
    string ad = Console.ReadLine();
    Console.WriteLine("Soyadınız");
    string soyad = Console.ReadLine();

    Console.WriteLine("Hoşgeldiniz " + ad + soyad);

}
