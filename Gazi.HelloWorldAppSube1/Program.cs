namespace Gazi.HelloWorldAppSube1
{
    internal class Program
    {
        static int sayi = 50;
        static void Main(string[] args)
        {
            //byte a;
            //a = 30;

            //byte b= 30;
            //Console.WriteLine(a);

            //const int number = 100;
            //Console.WriteLine(number);  
            //number = 50;
            //Console.WriteLine(number);  

            //byte yas;
            //Console.WriteLine(yas);

            //byte s1 = 50;

            //short s2 = 50;
            //int s3 = 50;
            //long s4 = 50;

            //Int16 s5 = 50;  
            //Int32 s6 = 50;
            //Int64 s7 = 50;

            //var isim = "Ahmet";
            //byte sayi = 100;

            //var harf = 'A';

            //string isim = "Ahmet";
            //string soyad = "Mehmet";

            //Console.WriteLine("Merhaba " + isim + " " + soyad);
            //Console.WriteLine("Merhaba {0} {1}", isim, soyad);
            //Console.WriteLine($"Merhaba {isim} {soyad}");

            //Console.WriteLine("İsminizi Giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Soyadınızı Giriniz:");
            //string soyad = Console.ReadLine();
            //Console.WriteLine("Yaşınızı giriniz:");
            //byte yas = byte.Parse(Console.ReadLine());
            //Console.WriteLine($"Hoşgeldin {isim} {soyad}");

            //C# Tip Güvenliği (Type Safety) sağlayan bir programlama dilidir. Bu özellik, veri tipine uygun olmayan tipte değer atanmasının önüne geçer.Eğer bu değeri uygun hale getirerek atamak istersek, TÜR DÖNÜŞÜMÜ(Type Casting) yapmamız gerekir.

            //double maas = 5000;
            //maas += 1000;//maas=maas+1000
            //Console.WriteLine(maas);

            //int sayi1 = 10;
            //int sayi2 = 20;

            //string sonuc = sayi2 > sayi1 ? "Sayı 2 büyüktür." : "Sayı 1 büyüktür yada sayılar eşittir";
            //Console.WriteLine(sonuc);


            //TÜR DÖNÜŞÜMLERİ(Type Casting)

            //byte sayi = 20;
            //int number = sayi;//Implicit Type Casting


            //checked
            //{
            //    int sayi = 255;
            //    byte number = (byte)sayi;//Explicit Type Casting
            //    Console.WriteLine(number); 
            //}
            //Büyük tür->Küçük tür RİSK: Değer kaybı

            //string->değer türlerine 

            //string sayi = "25";
            ////int number = Convert.ToInt32(sayi);
            //byte number = byte.Parse(sayi);



            //Console.WriteLine("Bir sayı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bir sayı daha giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Girilen sayıların toplamı:{sayi1 + sayi2}");




        }
    }
}

//Bit: 0-1
//8 Bit = 1 Byte
//1024Byte = 1 Kilobyte  (KB)
//1024KB = 1 Megabyte (MB)
//1024MB = 1 Gigabyte(GB)
//1024GB = 1 Terabyte(TB)


//Binary: 2'li sayı sistemi
//Decimal: 10 tabanlı

/*
-Namespace: İçinde classları bulunduran yapılardır.
-{ }: Blok yapıları(Scope)
-Class: İçinde metodları bulunduran yapılardır.
-Metod: İş yapan kod bloklarıdır.
-Main Metodu: Console uygulamalarının giriş noktasıdır.                      Bulunması zorunludur.
-Syntax: Kod yazım kuralları
-Build->Derleme(Compile): Programlama Dilinin makina diline çevrilmesi işlemi
-Solution: İçinde birden fazla proje bulundurabilen yapılara solution denir.

MS-IL: Microsoft Intermediate Language

C#->Build->MS-IL(exe)->Runtime->JIT Compiler->Binary(0-1)
Runtime: Çalışma zamanı 
.Net Core->Core Common Language Runtime
JIT: Just In Time
Compiler: Derleyici

.NET: Microsoft tarafından yazılım geliştirmek için tasarlanan bir framework. İçinde programlama dilleri,editörler,derleyiciler, kütüphaneler bulunur.

- Programlama Dilleri- C#-Visual Basic-F#
- Editör: Visual Studio-Visual Studio Code
- Kütüphaneler(Library): İçinde classlar bulunur.
- Derleyiciler: Kodları makina diline çevirmek için gerekli yazılımlar.

- Desktop(Masaüstü) 
- Web Based Software(Web tabanlı yazılım)
- Mobile Application (Android-iOS) Xamarin ile
- Game Software (Unity ile)
- iOT: Internet Of Things (Akıllı Cihazlar için yazılımlar)
- AI (Yapay Zeka) Uygulamaları yapılabilir.

Cross Platform: Windows, MacOs, Linux işletim sistemlerinde çalışabilen uygulamalar. 

.NET Framework: Windows
.NET Core: Cross Platform
.NET


0 && 0 = 0
0 && 1 = 0
1 && 0 = 0
1 && 1 = 1

0 || 0 = 0
0 || 1 = 1
1 || 0 = 1
1 || 1 = 1

*/