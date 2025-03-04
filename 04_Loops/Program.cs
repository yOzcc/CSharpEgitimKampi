using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For ile string yazdırma
            //Console.WriteLine("Yazdırmak istediğin yazıyı yaz kanzi.");
            //string text = Console.ReadLine();
            //Console.WriteLine("Bu yazı kaç kez tekrar edilsin kanzi.");
            //int repeatNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("************************************");


            //for (int i = 0; i < repeatNum; i++)
            //{
            //    Console.WriteLine(text);
            //}
            #endregion
            #region For ile karar yapıları
            //Console.WriteLine("Girilen iki sayı arasında 3'e tam bölünebilen sayıları ekrana yazdıran program");
            //Console.WriteLine("Küçük olan sayıyı giriniz");
            //int smallNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Büyük olan sayıyı giriniz");
            //int bigNum = int.Parse(Console.ReadLine());

            //if(smallNum >= bigNum)
            //{
            //    Console.WriteLine("Matematiğini s....");
            //}
            //else
            //{
            //    Console.WriteLine("************************************");
            //    Console.WriteLine(smallNum + " ile " + bigNum + " arasında 3'e tam bölünebilen sayılar");
            //    for (int i = smallNum; i <= bigNum; i++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //Console.Read();
            #endregion

            #region Sums of numbers between two numbers
            //Console.WriteLine("Peki girilen iki sayı arasındaki ardışık sayıları toplamak istesek?");
            //Console.WriteLine("Küçük olan sayıyı giriniz");
            //int smallNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Büyük olan sayıyı giriniz");
            //int bigNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz sayılar = " + smallNum + " ve " + bigNum);
            //Console.WriteLine("************************************");

            //int sum = 0;

            //for (int i = smallNum;  i < bigNum; i++)
            //{
            //    sum += i;
            //    Console.WriteLine("Şu anki toplam = " + sum + " + " + (i + 1) + " = " + (( sum+i)+1));

            //}


            #endregion
            #region sums of odd and even numbers between two numbers
            //Console.WriteLine("Peki girilen iki sayı arasındaki çift ve tek sayıları toplamak istesek?");
            //Console.WriteLine("Küçük olan sayıyı giriniz");
            //int smallNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Büyük olan sayıyı giriniz");
            //int bigNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("*** Seçtiğiniz sayılar = " + smallNum + " ve " + bigNum + " ***");
            //Console.WriteLine("************************************");

            //int evenSum = 0;
            //int oddSum = 0;

            //for(int i = smallNum; i<= bigNum; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        oddSum+= i;
            //        Console.WriteLine(i + " çift sayıdır.");
            //        Console.WriteLine("Şu anki mevcut çift sayı toplamı = " + oddSum);
            //    }
            //    else
            //    {
            //        evenSum+= i;
            //        Console.WriteLine(i + " tek sayıdır.");
            //        Console.WriteLine("Şu anki mevcut tek sayı toplamı = " + evenSum);
            //    }
            //}
            #endregion

            #region Bakteri Sorusu
            //Console.WriteLine("Bakteri hesabı yapan program");
            //Console.WriteLine("*******************");
            //int bacteriaNum = 1;

            //Console.WriteLine("Bu bakteri ve kendinden sonra bölünecek bakteriler her seferinde 2'ye bölünecek");

            //for(int i = bacteriaNum; i< 24; i++)
            //{
            //    bacteriaNum *= 2;
            //    Console.WriteLine(i + ". saat " + "mevcut bakteri sayısı = " + bacteriaNum);

            //}
            #endregion

            #region While

            //int age = 0;
            //int deathAge = 70;
            //for (int i = age; i < deathAge; i++)
            //{
            //    while (age < 18)
            //    {
            //        Console.WriteLine(i + ". yaşında ehliyet alamazsın.");
            //        age++;
            //        i++;
            //    }
            //    Console.WriteLine(i + ". yaşında ehliyet alabilirsin.");
            //    age++;
            //}
            #endregion

            #region While ile toplama
            //Console.WriteLine("While ile kullanıcının verdiği iki sayı arasındaki toplam");
            //Console.WriteLine("Lütfen küçük sayıyı giriniz");
            //int smallNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen büyük sayıyı giriniz");
            //int bigNum = int.Parse(Console.ReadLine());

            //int sum = 0;
            //while (smallNum <= bigNum)
            //{
            //    sum = sum + smallNum;
            //    smallNum++;
            //    Console.WriteLine("Şu anki sayıların toplamı = " + sum);
            //}
            #endregion

            #region Sınav sorusu
            //Console.WriteLine("Klavyeden girilen 3 basamaklı bir sayının rakamları toplamını bulan program");
            //Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int firstNum = 0;
            //int secondNum=0;
            //int thirdNum = 0;
            

            //firstNum = number % 10;
            //thirdNum = number / 100;
            //secondNum = (number / 10) % 10;
            //int totalSum = firstNum + secondNum + thirdNum;

            //Console.WriteLine(number + " sayısının birler basamağı = " + firstNum);
            //Console.WriteLine(number + " sayısının onlar basamağı = " + secondNum);
            //Console.WriteLine(number + " sayısının yüzler basamağı = " + thirdNum);

            //Console.WriteLine("*****************");
            //Console.WriteLine(number + " sayısının basamakları toplamı = " + firstNum + " + " + secondNum + " + " + thirdNum + " = " + totalSum);
            #endregion
        }
    }
}
