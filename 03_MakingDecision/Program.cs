using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Password
            //Console.WriteLine("Please enter your password: ");
            //string password;
            //password = Console.ReadLine();

            //Console.WriteLine("Please enter your password again: ");
            //string password2;
            //password2 = Console.ReadLine();

            //if ((password == password2))
            //{
            //    Console.WriteLine("Welcome to the system!");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong password! Please try again.");

            //}
            #endregion

            #region Number
            //Console.WriteLine("Please enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please re-enter the number you selected: ");
            //int number2 = int.Parse(Console.ReadLine());

            //if (number == number2)
            //{
            //    Console.WriteLine("The numbers you entered are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("The numbers you entered are different.");
            //}
            #endregion

            #region Mod
            //Console.WriteLine("Please enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("The number you entered is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number you entered is odd.");
            //}
            #endregion

            #region Teams
            //Console.WriteLine("Klavyeden girilecek harfe göre 4 büyük takımın ismini yazdıran program");
            //Console.WriteLine("Lütfen aşağıdaki harflerden birini giriniz:");
            //Console.WriteLine("G-g, F-f, B-b, T,t");
            //Console.WriteLine("**************");
            //char c = char.Parse(Console.ReadLine().ToLower());

            //if (c == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (c == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (c == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (c == 't')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız.");
            //}
            #endregion

            #region Restaurant

            //int chickenPrice = 100; int meatPrice = 150; int fishPrice = 125; int pizzaPrice = 100;
            //int saladPrice = 20; int soupPrice = 15; int cheesePlatePrice = 25; int friedCalamariPrice = 30;
            //int baklavaPrice = 10; int ricePuddingPrice = 8; int iceCreamPrice = 5; int cakePrice = 15;
            //int colaPrice = 5; int fantaPrice = 5; int spritePrice = 5; int ayranPrice = 2;

            //Console.WriteLine("Welcome our restaurant, Menu is here!");
            //Console.WriteLine("**************");
            //Console.WriteLine("1. Main Course");
            //Console.WriteLine("2. Appetizer");
            //Console.WriteLine("3. Dessert");
            //Console.WriteLine("4. Drink");
            //Console.WriteLine("**************");
            //Console.WriteLine("Please select the product you want to buy: ");
            //int productNo = int.Parse(Console.ReadLine());
            //if (productNo == 1)
            //{
            //    Console.WriteLine("1. Chicken " + chickenPrice + " TL");
            //    Console.WriteLine("2. Meat " + meatPrice + " TL");
            //    Console.WriteLine("3. Fish " + fishPrice + " TL");
            //    Console.WriteLine("4. Pizza " + pizzaPrice + " TL");
            //    Console.WriteLine("**************");
            //    Console.WriteLine("Please select the product you want to buy: ");
            //    int productNo2 = int.Parse(Console.ReadLine());
            //}
            //else if (productNo == 2)
            //{
            //    Console.WriteLine("1. Salad " + chickenPrice + " TL");
            //    Console.WriteLine("2. Soup " + chickenPrice + " TL");
            //    Console.WriteLine("3. Cheese Plate " + chickenPrice + " TL");
            //    Console.WriteLine("4. Fried Calamari " + chickenPrice + " TL");
            //    Console.WriteLine("**************");
            //}
            //else if (productNo == 3)
            //{
            //    Console.WriteLine("1. Baklava " + chickenPrice + " TL");
            //    Console.WriteLine("2. Rice Pudding " + chickenPrice + " TL");
            //    Console.WriteLine("3. Ice Cream " + chickenPrice + " TL");
            //    Console.WriteLine("4. Cake " + chickenPrice + " TL");
            //    Console.WriteLine("**************");
            //}
            //else if (productNo == 4)
            //{
            //    Console.WriteLine("1. Cola" + chickenPrice + " TL");
            //    Console.WriteLine("2. Fanta" + chickenPrice + " TL");
            //    Console.WriteLine("3. Sprite" + chickenPrice + " TL");
            //    Console.WriteLine("4. Ayran" + chickenPrice + " TL");
            //    Console.WriteLine("**************");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid product number!");
            //}
            #endregion

            #region Switch
            //Console.WriteLine("Please enter a month number: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //    default: Console.WriteLine("Invalid month number!"); break;
            //}
            #endregion

            #region Calculator
            //Console.WriteLine("Yasin Hesap Makinesi");
            //Console.WriteLine("Please select your transaction");
            //Console.WriteLine("Toplama için : +");
            //Console.WriteLine("Çıkarma için : -");
            //Console.WriteLine("Çarpma için : *");
            //Console.WriteLine("Bölme için : /");

            //char selection = char.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen işleme sokmak istediğiniz sayıyı yazınız:");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen işleme sokmak istediğiniz 2.sayıyı yazınız:");
            //int num2 = int.Parse(Console.ReadLine());

            //switch (selection)
            //{
            //    case '+':
            //        Console.WriteLine(num + num2); break;
            //    case '-':
            //        Console.WriteLine(num - num2); break;
            //    case '*':
            //        Console.WriteLine(num * num2); break;
            //    case '/':
            //        Console.WriteLine(num / num2); break;
            //    default:
            //        Console.WriteLine("Hatalı işlem"); break;

            //}

            #endregion
        }
    }
}
