namespace Gazi.KararYapilariApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int s1 = 10;
            //int s2 = 20;

            //if (s1 > s2)
            //{
            //    Console.WriteLine("Sayı 1 büyüktür");
            //}
            //else if (s2 > s1)
            //{
            //    Console.WriteLine("Sayı 2 büyük");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşittir");
            //}

            //string msg1, msg2, msg3, msg4,msg5;

            //Console.WriteLine("Dil Seçiniz/Select Language(TR/EN):");
            //string cevap=Console.ReadLine();
            //if (cevap.ToUpper()=="TR")
            //{
            //    msg1 = "Bir sayı giriniz:";
            //    msg2 = "Bir sayı daha giriniz:";
            //    msg3 = "İşlem seçiniz:";
            //    msg4 = "İşlemin sonucu:";
            //    msg5 = "Hatalı işlem seçtiniz.";
            //}
            //else
            //{
            //    msg1 = "Enter first number:";
            //    msg2 = "Enter second number:";
            //    msg3 = "Select operation:";
            //    msg4 = "Result:";
            //    msg5 = "Incorrect operation selected";
            //}

            //Console.WriteLine(msg1);
            //double s1=double.Parse(Console.ReadLine());
            //Console.WriteLine(msg2);
            //double s2=double.Parse(Console.ReadLine());
            //Console.WriteLine(msg3);
            //char islem=char.Parse(Console.ReadLine());            
            //if (islem=='+')
            //{
            //    Console.WriteLine($"{msg4}{s1+s2}");
            //}
            //else if(islem=='-')
            //{
            //    Console.WriteLine($"{msg4}{s1 - s2}");
            //}
            //else if(islem=='*')
            //{
            //    Console.WriteLine($"{msg4}{s1 * s2}");
            //}
            //else if (islem=='/')
            //{
            //    Console.WriteLine($"{msg4}{s1 / s2}");
            //}
            //else
            //{
            //    Console.WriteLine(msg5);
            //}    

            try
            {
                Console.WriteLine("Hava nasıl?");
                string durum = Console.ReadLine().ToLower();

                if (durum == "güzel" || durum == "iyi")
                {
                    Console.WriteLine("Kaç derece?");
                    sbyte derece = sbyte.Parse(Console.ReadLine());
                    if (derece < 15)
                    {
                        Console.WriteLine("Hava soğuk evde otur");
                    }
                    else if (derece >= 15 && derece <= 40)
                    {
                        Console.WriteLine("Hava iyi dışarı çık");
                    }
                    else
                    {
                        Console.WriteLine("Çok sıcak evde otur");
                    }
                }
                else if (durum == "kötü")
                {
                    Console.WriteLine("Evde otur");
                }
                else
                {
                    Console.WriteLine("Hatalı giriş");
                }
            }
            catch (Exception)
            {

                throw;
            }


            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    byte sayi = byte.Parse(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sadece sayı giriniz");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arası sayı giriniz");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bilinmeyen bir hata oluştu!");
            //}


        }
    }
}

//Dil seçiniz/Select Language:EN
//Enter first number:10
//Enter second number:20
//Select Operation: +
//Result: 30

//Dil seçiniz/Select Language:TR

//Exception Handling - Hata Yakalama

