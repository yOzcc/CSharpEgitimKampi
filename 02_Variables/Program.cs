using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double
            //double applePrice, tomatoPrice, carrotPrice, potatoPrice, strawberryPrice;
            //applePrice = 7.89;
            //tomatoPrice = 6.78;
            //carrotPrice = 5.67;
            //potatoPrice = 4.56;
            //strawberryPrice = 8.99;


            //Console.WriteLine("Bazaar Prices");
            //Console.WriteLine("*************");
            //Console.WriteLine("Apple Price: " + applePrice + " TL");
            //Console.WriteLine("Tomato Price: " + tomatoPrice + " TL");
            //Console.WriteLine("Carrot Price: " + carrotPrice + " TL");
            //Console.WriteLine("Potato Price: " + potatoPrice + " TL");
            //Console.WriteLine("Strawberry Price: " + strawberryPrice + " TL");
            //Console.WriteLine("*************");
            //Console.WriteLine("");

            //double appleGram, tomatoGram, carrotGram, potatoGram, strawberryGram;
            //appleGram = 1.245;
            //tomatoGram = 1.450;
            //carrotGram = 1.089;
            //potatoGram = 1.221;
            //strawberryGram = 0.780;


            //Console.WriteLine("Your basket: ");
            //Console.WriteLine("Apple - Price: " + applePrice + " TL - " + "Gram: " + appleGram);
            //Console.WriteLine("Tomato - Price: " + tomatoPrice + " TL - " + "Gram: " + tomatoGram);
            //Console.WriteLine("Carrot - Price: " + carrotPrice + " TL - " + "Gram: " + carrotGram);
            //Console.WriteLine("Potato - Price: " + potatoPrice + " TL - " + "Gram: " + potatoGram);
            //Console.WriteLine("Strawberry - Price: " + strawberryPrice + " TL - " + "Gram: " + strawberryGram);
            //double totalPrice = (applePrice * appleGram) + (tomatoPrice * tomatoGram) + (carrotPrice * carrotGram) + (potatoPrice * potatoGram) + (strawberryPrice * strawberryGram);
            //Console.WriteLine("Total price: " + totalPrice);
            #endregion

            #region Data enter
            //Console.WriteLine("Yasin Airline Passenger Information System");
            //Console.WriteLine("******************************************");
            //string passengerName, passengerSurname, passengerNationality, passengerPassportNo;
            //int passengerAge;
            //Console.Write("Please enter your name: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Please enter your surname: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Please enter your Nationality: ");
            //passengerNationality = Console.ReadLine();
            //Console.Write("Please enter your Passport No: ");
            //passengerPassportNo = Console.ReadLine();
            //Console.Write("Please enter your Age: ");
            //passengerAge = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Welcome " + passengerName + " " + passengerSurname + "!");
            #endregion

            #region Shopping
            //bool isShopping = true;
            //double grandTotalPrice = 0;
            //while ((isShopping))
            //{
            //    Console.WriteLine("Yasin Market");
            //    Console.WriteLine("*************");
            //    Console.WriteLine("1. Computer");
            //    Console.WriteLine("2. Phone");
            //    Console.WriteLine("3. Tablet");
            //    Console.WriteLine("4. Headphone");
            //    Console.WriteLine("5. Keyboard");
            //    Console.WriteLine("*************");

            //    Console.WriteLine("Please select the product you want to buy: ");
            //    int productNo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Please enter the quantity: ");
            //    int quantity = Convert.ToInt32(Console.ReadLine());

            //    double price = 0;
            //    string productName = "";
            //    switch (productNo)
            //    {
            //        case 1:
            //            price = 20000;
            //            productName = "Computer";
            //            break;
            //        case 2:
            //            price = 10000;
            //            productName = "Phone";
            //            break;
            //        case 3:
            //            price = 5000;
            //            productName = "Tablet";
            //            break;
            //        case 4:
            //            price = 1000;
            //            productName = "Headphone";
            //            break;
            //        case 5:
            //            price = 500;
            //            productName = "Keyboard";
            //            break;
            //        default:
            //            Console.WriteLine("Invalid product number!");
            //            break;
            //    }
            //    double totalPrice = price * quantity;
            //    grandTotalPrice += totalPrice;
            //    Console.WriteLine("Product Name: " + productName);
            //    Console.WriteLine("Product Price: " + price + " TL");
            //    Console.WriteLine("Quantity: " + quantity);
            //    Console.WriteLine("Total Price: " + totalPrice + " TL");
            //    Console.WriteLine("Do you want to continue shopping? (Yes/No)");
            //    string answer = Console.ReadLine().ToLower();
            //    if (answer == "no")
            //    {
            //        isShopping = false;

            //    }

            //}
            //Console.WriteLine("Grand Total Price: " + grandTotalPrice + " TL");
            #endregion

            #region Exam
            double firstExamGrade, secondExamGrade, finalExamGrade;
            Console.WriteLine("Plase enter your first exam grade: ");
            firstExamGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Plase enter your second exam grade: ");
            secondExamGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Plase enter your final exam grade: ");
            finalExamGrade = double.Parse(Console.ReadLine());
            double average = (firstExamGrade * 0.3) + (secondExamGrade * 0.3) + (finalExamGrade * 0.4);
            Console.WriteLine("Your average: " + average);
            #endregion
        }
    }
}
