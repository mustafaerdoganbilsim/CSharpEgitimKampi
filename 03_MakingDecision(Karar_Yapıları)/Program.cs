using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision_Karar_Yapıları_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreiy giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");


            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");

            //}
            //else
            //{ 
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata!";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1+exam2+exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması: "+average);

            //if (average >= 0 & average < 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average >= 50 & average < 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average >= 70 & average < 85)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average >= 85 & average <= 10)
            //{
            //    result = "Sonuç Çok İyi";
            //}


            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen bir şehir giriniz: ");

            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "kayseri" | city == "bursa")
            //{
            //    Console.WriteLine("Bu şehir listede mevcut");
            //}
            //else {

            //    Console.WriteLine("Bu şehir listede mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı!");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}



            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 =int.Parse( Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int resutl=number1%number2;
            //Console.WriteLine("1. Sayının 2. Sayıya bölümündne kalan: "+resutl);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayımız Çift");

            //}

            //else
            //{
            //    Console.WriteLine("Sayımız Tek");
            //}
            #endregion

            #region  Char Değişkeler İle Karar Yapıları

            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //char team=char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            //else
            //{
            //    Console.WriteLine("Hata!");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //int menuItem;
            //Console.Write("Detayı görmek istediğiniz menü seçiniz: ");
            //menuItem = int.Parse(Console.ReadLine());


            //if (menuItem == 1)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Ana Yemekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------------Ana Yemekler-----------");
            //    Console.WriteLine();


            //}


            //if (menuItem == 2)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Çorbalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");

            //    Console.WriteLine("-------------Çorbalar-----------");
            //    Console.WriteLine();


            //}

            //if (menuItem == 3)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Pizzalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margerita");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-------------Pizzalar-----------");
            //    Console.WriteLine();


            //}

            //if (menuItem == 4)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------İçecekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Şalgam");
            //    Console.WriteLine("-------------İçecekler-----------");
            //    Console.WriteLine();


            //}
            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişini yapınız: ");
            //int montNumber = int.Parse(Console.ReadLine());

            //switch (montNumber)
            //{

            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    // 12 adet olacak şekilde ay değerlerinin girilmesi gerekiyor
            //    default:
            //        Console.WriteLine("Hatalı Veri Girişi"); break;



            //}
            #endregion

            #region Switch Hesap Makinesi

            //int number1, number2, result;
            //char sembol;

            //Console.Write("1. Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //sembol = char.Parse(Console.ReadLine());

            //switch (sembol)
            //{

            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result); break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma: " + result); break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme: " + result); break;

            //    default: 
            //        Console.WriteLine("Hatalı bir sembol girdiniz"); break;
            //}


            #endregion
            Console.Read();

        }
    }
}
