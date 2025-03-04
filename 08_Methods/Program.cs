using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //void PrintCustomerList()
            //{
            //    Console.WriteLine("Yasin Ozc");
            //    Console.WriteLine("Sumiya Ozc");
            //    Console.WriteLine("Minisumi Ozc");
            //}

            //PrintCustomerList();

            //void Sum(int a, int b)
            //{
            //    Console.WriteLine(a + b);
            //}

            //Sum(5, 10);

            #endregion

            #region Değer döndürmeyen parametreli metotlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //WriteMethod("Yasin");

            //void CustomerCard(string name, string surname, int age)
            //{
            //    Console.WriteLine("Name: " + name);
            //    Console.WriteLine("Surname: " + surname);
            //    Console.WriteLine("Age: " + age);
            //}

            //CustomerCard("Yasin", "Ozc", 27);

            #endregion

            #region Değer döndürmeyen int parametreli metotlar

            //void Sum(int a, int b, int c)
            //{
            //    Console.WriteLine(a + b + c);
            //}

            //Sum(5, 10, 15);
            #endregion

            #region Değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Yasin Ozcelik";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Yasin";
            //    string surname = "Ozcelik";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());


            #endregion

            #region değer döndüren string parametreli metotlar

            //string StudentInfo(string name, string surname, int age, int studentNumber)
            //{
            //    string info = "name: " + name + " surname: " + surname + " age: " + age + " student number: " + studentNumber;
            //    return info;
            //}

            //Console.WriteLine("Öğrencinin adını giriniz: ");
            //string nameX = Console.ReadLine();
            //Console.WriteLine("Öğrencinin soyadını giriniz: ");
            //string surnameX = Console.ReadLine();
            //Console.WriteLine("Öğrencinin yaşını giriniz: ");
            //int ageX = int.Parse(Console.ReadLine());
            //Console.WriteLine("Öğrencinin numarasını giriniz: ");
            //int studentNumberX = int.Parse(Console.ReadLine());

            //Console.WriteLine(StudentInfo(nameX,surnameX,ageX,studentNumberX));

            #endregion

            #region değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine("Birinci sayıyı giriniz: ");
            //int number1x = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz: ");
            //int number2x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sonuç : " + Sum(number1x, number2x));
            //Console.WriteLine(Sum(5, 10));
            #endregion

            #region örnek uygulama
            string ExamResult(String studentName, int midterm, int final, int project)
            {
                int result = midterm * 30 / 100 + final * 50 / 100 + project * 20 / 100;
                if(result >= 50)
                {
                    
                    return studentName + " passed the exam." + " Average: " + result.ToString();
                }
                else
                {
                    return studentName + " failed the exam." + " Average: " + result.ToString();
                }
            }

            Console.WriteLine(ExamResult("Yasin", 50, 60, 70));
            #endregion
        }
    }
}
