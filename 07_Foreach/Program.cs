using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //1.Değişken türü
            //2.Değişken adı
            //3.In
            //4.Liste, dizi, koleksiyon

            //string[] cities = { "ankara", "istanbul", "antalya", "trabzon", "izmir", "balikesir" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach ( int number in numbers)
            //{
            //    while(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //        break;
            //    }
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 50, 100, 1320 };
            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //    Console.WriteLine("Mevcut toplam : " + total +" (" + number + ")");
            //}

            //List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (int number in ints)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);

            //}

            int total = 0;
            int biggest = 0;
            int smallest = 100;
            Console.WriteLine("Öğrenci sayisini giriniz: ");
            Console.WriteLine("***************************");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Öğrenci isimlerini giriniz: ");
            Console.WriteLine("***************************");
            string[] students = new string[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine((i + 1) + ". öğrenci ismini giriniz: ");
                students[i] = Console.ReadLine();
                #endregion
            }
            Console.WriteLine("***************************");
            Console.WriteLine("Ogrencilerin notlarini sirasiyla giriniz: ");
            int[] grades = new int[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(students[i] + " isimli öğrencinin notunu giriniz: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("***************************");
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(students[i] + " isimli öğrencinin notu: " + grades[i]);
                total += grades[i];
                if (grades[i] > biggest)
                {
                    biggest = grades[i];
                }
                if (grades[i] < smallest)
                {
                    smallest = grades[i];
                }
            }
            Console.WriteLine("***************************");
            Console.WriteLine("Sınıf ortalaması : " + total / studentCount);
            Console.WriteLine("En başarılı öğrencinin notu ve ismi: " + biggest + " " + students[Array.IndexOf(grades, biggest)]);
            Console.WriteLine("En başarısız öğrencinin notu ve ismi : " + smallest + " " + students[Array.IndexOf(grades, smallest)]);
            Console.WriteLine("***************************");
            Console.WriteLine("Başarılı olan öğrenciler: ");
            for (int i = 0; i < studentCount; i++)
            {
                if (grades[i] > 50)
                {
                    Console.WriteLine(students[i] + " " + grades[i] + " puan ile başarılı oldu.");
                }
                
            }
            Console.WriteLine("***************************");
            Console.WriteLine("Başarısız olan öğrenciler: ");
            for (int i = 0; i < studentCount; i++)
            {
                if (grades[i] < 50)
                {
                    Console.WriteLine(students[i] + " " + grades[i] + " puan ile başarısız oldu.");
                }

            }
        }
    }
}
