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

            Console.WriteLine("Hava nasıl?");
            string durum = Console.ReadLine().ToLower();

            if (durum == "güzel" || durum=="iyi")
            {
                Console.WriteLine("Dışarı çık");
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
    }
}

//Dil seçiniz/Select Language:EN
//Enter first number:10
//Enter second number:20
//Select Operation: +
//Result: 30

//Dil seçiniz/Select Language:TR

