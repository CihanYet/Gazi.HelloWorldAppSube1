namespace Gazi.DongulerAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İsminizi giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Kaç kere yazılsın:");
            //byte tekrar = byte.Parse(Console.ReadLine());


            //for (int i = 0; i < tekrar; i++)
            //{
            //    Console.WriteLine($"{i+1}.{isim}");
            //}




            try
            {
                Console.WriteLine("Başlangıç değeri giriniz:");
                int bas = int.Parse(Console.ReadLine());
                Console.WriteLine("Bitiş değeri giriniz:");
                int bit = int.Parse(Console.ReadLine());
                Console.WriteLine("Çift mi tek mi?");
                string cevap = Console.ReadLine();

                int sonuc = 0;

                //bas:10 bit:5
                if (bas > bit)
                {
                    int temp = bas;
                    bas = bit;
                    bit = temp;
                }
                for (int i = bas; i <= bit; i++)
                {
                    if (i % 2 == (cevap == "tek" ? 1 : 0))
                    {
                        Console.WriteLine(i);
                        //sonuc = sonuc + i;
                        sonuc += i;
                    }
                }
                Console.WriteLine(sonuc);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Çok büyük yada çok küçük değer girdiniz.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen sayı giriniz");
            }
            catch (Exception)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu.");
            }
        }
    }
}