using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //string[] color = new string[4];

            //color[0] = "Kırmızı";
            //color[1] = "Sarı";
            //color[2] = "Beyaz";
            //color[3] = "Mavi";

            //Console.WriteLine(color[2]);


            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)

            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] sembols = {'a','b','c','*','/','-' };

            //for (int i = 0; i <sembols.Length; i++)
            //{
            //    Console.WriteLine(sembols[i]);
            //}

            // dizideki en büyük sayyı bulma

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumbers = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumbers)
            //    {
            //        maxNumbers = myArray[i];

            //    }
            //}

            //Console.WriteLine(maxNumbers);
            //
            ////int[] numbers = {75,32,54,874,12,2,98,654 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };

            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numebers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };

            //Console.WriteLine("Dizinin En Büyük Elemanı " + numebers.Max() + " Dizinin En Küçük Elemanı " + numebers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{

            //    Console.Write($"Lütfen{i+1 }. Şehri Giriniz ");
            //    cities[i] = Console.ReadLine();


            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum=0 ;
            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    sum+= numbers[i] ;
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 52, 69, 65, 458, 954, 2541 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);


            //    }

            //}


            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);


            //    }

            //}
            #endregion

            Console.Read();
        }
    }
}
