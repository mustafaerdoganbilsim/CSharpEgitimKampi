using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Varibles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkener

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice +" TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram,orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice=appleGram*applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice=strawberryGram*strawberryPrice;
            //double potatoTotalPrice=potatoGram*potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma -  "+ "Birim Fiyatı: " + applePrice + " -Gramaj: " + appleGram + " -Toplam Fiyatı: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal -  "+ "Birim Fiyatı: " + orangePrice + " -Gramaj: " + orangeGram + " -Toplam Fiyatı: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek - "+"Birim Fiyatı: "+strawberryPrice+" -Gramaj: "+strawberryGram+ " -Toplam Fiyatı: "+ strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates - "+"Birim Fiyatı: "+potatoPrice+" -Gramaj: "+potatoGram+ " -Toplam Fiyatı: "+ potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates - "+"Birim Fiyatı: "+tomatoPrice+" -Gramaj: "+tomatoGram+ " -Toplam Fiyatı: "+ tomatoTotalPrice + " TL");


            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: "+shoppingTotalPrice+" TL");


            #endregion

            #region Char Değişkenler

            //char sembol;
            //sembol = 'a';
            //Console.WriteLine(sembol);



            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler


            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistricy, passengerCity,
            //    passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName= Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname= Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistricy= Console.ReadLine(); 

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity= Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: "+passengerIdentityNumber+" "+"Yolcu Ad Soyad: "+passengerName+" "+passengerSurname+ " " +
            //    passengerDistricy + " / "+passengerCity+" "+passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler


            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;


            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice+ " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, average;

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());


            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+average);

            #endregion

            #region Klavyeden Karakter Girişi


            //char gender;
            //Console.Write("Cinsiyet Giriniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Girdiğiniz Cinsiyet: " + gender);



            #endregion

            Console.Read();
        }
    }
}
