using System;

namespace ConsoleAppAlgoritmaSoruları
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Çift Sayı");
            Console.WriteLine("2-Eşit yada Tam Bölünen Sayı");
            Console.WriteLine("3-Sondan Başa Kelime Yazdırma");
            Console.WriteLine("4-Harf ve Kelime Sayısı");

            var deger = Console.ReadLine();
            bool sayiMi = int.TryParse(deger, out int sonuc);
            if (sayiMi && sonuc == 1)
            {
                CiftSayi();
            }
            else if (sayiMi && sonuc == 2)
            {
                TamBolunen();
            }
            else if (sayiMi && sonuc == 3)
            {
                SondanBasaKelimeYazdır();
            }
            else if (sayiMi && sonuc == 4)
            {
                KelimeVeHarfSayisi();
            }
            else
            {
                return;
            }
        }

        public static string CiftSayi()
        {
            Console.WriteLine("Bir Sayı Giriniz.");
            var deger = Console.ReadLine();
            bool pozitifSayımı = int.TryParse(deger, out int sayi);

            if (pozitifSayımı && sayi > 0)
            {
                int[] sayilarArray = new int[sayi];
                for (int i = 1; i <= sayi; i++)
                {
                    Console.WriteLine(i + ". sayıyı giriniz");
                    sayilarArray[i - 1] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("***** Çift Sayılar *****");
                foreach (var item in sayilarArray)
                {
                    if (item % 2 == 0)
                    {
                        Console.WriteLine(item);
                    }
                }

                return "";
            }
            else
            {
                Console.WriteLine("Hatalı değer girdiniz.");
                return CiftSayi();
            }
        }

        public static string TamBolunen()
        {
            Console.WriteLine("Bir Sayı Giriniz.");
            var deger = Console.ReadLine();
            bool pozitifSayımı = int.TryParse(deger, out int sayi);

            Console.WriteLine("Bir Sayı Giriniz.");
            var deger2 = Console.ReadLine();
            bool pozitifSayımı2 = int.TryParse(deger2, out int sayi2);

            if (pozitifSayımı && sayi > 0)
            {
                int[] sayilarArray = new int[sayi];
                for (int i = 1; i <= sayi; i++)
                {
                    Console.WriteLine(i + ". sayıyı giriniz");
                    sayilarArray[i - 1] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("***** Tam Bölenler *****");
                foreach (var item in sayilarArray)
                {
                    if (item % sayi2 == 0)
                    {
                        Console.WriteLine(item);
                    }
                }

                return "";
            }
            else
            {
                Console.WriteLine("Hatalı değer girdiniz.");
                return TamBolunen();
            }
        }

        public static string SondanBasaKelimeYazdır()
        {

            Console.WriteLine("Sayı Giriniz");
            var deger = Console.ReadLine();
            bool sayiMi = int.TryParse(deger, out int sayi);
            if (sayiMi)
            {
                string[] kelimeArray = new string[sayi];
                for (int i = 1; i <= sayi; i++)
                {
                    Console.WriteLine(i + ". Kelimeyi Giriniz");
                    kelimeArray[i - 1] = Console.ReadLine();
                }
                Array.Reverse(kelimeArray);

                foreach (var item in kelimeArray)
                {
                    Console.WriteLine(item);
                }

            }
            return "";
        }

        public static string KelimeVeHarfSayisi()
        {
            Console.WriteLine("Cümle Giriniz");
            string cumle = Console.ReadLine();

            string harfler = cumle.Replace(" ","");          
            int harfSayisi = harfler.Length;
            var kelime = cumle.Split(" ");
            int kelimeSayisi = kelime.Length;

            Console.WriteLine("Harf Sayısı :" + harfSayisi);
            Console.WriteLine("Kelime Sayısı :" + kelimeSayisi);
            return "";
        }
    }
}