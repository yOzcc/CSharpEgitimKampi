using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region dizi tanımlama
            //string[] colors = new string[4];

            //colors[0] = "red";
            //colors[1] = "blue";
            //colors[2] = "Yellow";
            //colors[3] = "green";

            //string[] cities = new string[4];

            //cities[0] = "ankara";
            //cities[1] = "istanbul";
            //cities[2] = "antalya";
            //cities[3] = "trabzon";
            #endregion

            #region Dizi Elemanlarını Ekrana Yazdırma
            //Console.WriteLine("Dizinin tüm elemanlarını yazdırma");
            //string[] names = { "ali", "veli", "ayşe", "fatma" };
            //for(int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            #endregion

            #region Kullanıcıdan sayı alıp 3'e bölünenleri ekrana yazdırma
            //Console.WriteLine("Kullanıcıdan alınan sayıları 3'e bölünenleri ekrana yazdırma");
            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Sayı giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion

            #region En büyük sayıyı bulma
            //Console.WriteLine("Deneme");

            //Console.WriteLine("Sayilari giriniz");
            //int bigNum = 0;
            //int[] sayilar = new int[10];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write("Sayi giriniz: ");
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > bigNum)
            //    {
            //        bigNum = sayilar[i];
            //    }
            //}
            //Console.WriteLine("En büyük sayi: " + bigNum);
            #endregion

            #region Dizi elemanlarını sıralama
            //int[] numbers = { 23, 12, 4, 86, 72, 3, 11, 17, 8, 9 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //    { 
            //        Console.WriteLine(numbers[i]);
            //}

            //string[] names = { "ali", "veli", "ayşe", "fatma" };
            //Array.Sort(names);
            //Array.Reverse(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            #endregion

            #region Dizideki en büyük ve en küçük sayıyı bulma
            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Sayı giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int max = numbers[0];
            //int min = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}

            //Console.WriteLine("En büyük sayı: " + max);
            //Console.WriteLine("En küçük sayı: " + min);
            #endregion

            #region Dizideki çift VE tek sayıları ayırma

            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Sayıları giriniz: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] tekSayilar = new int[numbers.Length];
            int[] ciftSayilar = new int[numbers.Length];
            int tekIndex = 0;
            int ciftIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    ciftSayilar[ciftIndex++] = numbers[i];
                }
                else
                {
                    tekSayilar[tekIndex++] = numbers[i];
                }
            }

            Console.WriteLine("Tek Sayılar");
            Console.WriteLine("***********");
            for (int i = 0; i < tekIndex; i++)
            {
                Console.WriteLine(tekSayilar[i]);
            }

            Console.WriteLine("Çift Sayılar");
            Console.WriteLine("***********");
            for (int i = 0; i < ciftIndex; i++)
            {
                Console.WriteLine(ciftSayilar[i]);
            }

            #endregion
        }
    }
}
