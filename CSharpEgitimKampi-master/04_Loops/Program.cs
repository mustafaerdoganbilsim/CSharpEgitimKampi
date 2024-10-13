using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //for (int i = 1; i <= 5; i++)
            //{ 
            //    Console.WriteLine("C# Eğitim Kampı");

            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finisValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finisValue; i++)
            //{

            //    Console.WriteLine("Yaşasın Cumhuriyet");

            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //1-100 arasında 5 e tam bölünebilen sayılar
            //for (int i = 1; i <= 100; i++)
            //{

            //    if (i % 5 == 0)
            //    {

            //        Console.WriteLine(i);


            //    }

            //}


            // 1-10 arasındaki sayıların toplamı
            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{

            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            // 1-20 arasındaki 2 ye tam bölünebilen sayılar ve toplamı
            //int totalValue = 0;
            //for (int i = 0; i < 21; i++)
            //{

            //    if (i % 2 == 0)
            //    {

            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------");
            //Console.WriteLine(totalValue);

            //1-50 sayıları arasında 7 ye bölünebilen sayıların adeti

            //int caunt = 0;
            //for (int i = 1; i <=50; i++)
            //{

            //    if (i % 7 == 0)
            //    { caunt += 1; }
            //}
            //Console.WriteLine(caunt);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{

            //    bacterium *= 2;
            //    if (i < 10)// numaralar 1-9 dan sonra çift rakamlı olnca bir satır kaymasını engellemek için yapılmıştır. maksat ugraşmak olsun :)
            //    {
            //        Console.WriteLine(i + "    . Saatin Sonunda= " + bacterium);
            //    }
            //    else
            //    Console.WriteLine(i + "   . Saatin Sonunda= " + bacterium);
            //}






            #endregion

            #region While Döngüsü

            // ekrana 10 defa Merhaba Dünya yazdıran program While Döngüsü ile

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //    i++;
            //}

            //1-10 arasındaki sayılardan 3 e bölünenleri alt alta yazdıran while döngüsü

            //int i = 1;
            //while (i <= 10) {

            //    if (i % 3 == 0)
            //    { 
            //    Console.WriteLine(i);

            //    }
            //    i++;


            //}


            //1-10 arasındaki sayıların toplamını while döngüsü ile ekrana yazdıran

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;    
            //}

            //Console.WriteLine(sum);

            //
            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden girilen 3 basamaklı sayının basamak değerlerini bulan program
            //Console.Write("Sayıyı Giriniz: ");

            //int number=int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Kılavyeden Girilen Sayı: "+number);

            //int ones = number % 10;
            //int tens=((number % 100)-ones)/10;
            //int hundred=((number % 1000)-(tens*10)-ones)/100;

            //Console.WriteLine();
            //Console.WriteLine("Birler Basamağı: " + ones);
            //Console.WriteLine("Onlar Basamağı: "    +tens);
            //Console.WriteLine("Yüzler Basamağı: "+hundred);
            
            
            #endregion
            Console.Read();
        }
    }
}
