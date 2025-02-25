using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Customer
            //String customerName, customerSurname, customerPhone, customerMail, customerGender;
            //customerName = "Yasin";
            //customerSurname = "Ozcelik";
            //customerMail = "kanzi@xyz";
            //customerGender = "M";
            //customerPhone = "123";


            //Console.WriteLine("*** Customer Service ***");
            //Console.WriteLine();
            //Console.WriteLine("Welcome " + customerName + " " + customerSurname);
            //Console.WriteLine("Your informations: ");
            //Console.WriteLine();
            //Console.WriteLine("Mail : " + customerMail);
            //Console.WriteLine("Phone: " + customerPhone);
            //Console.WriteLine("Gender: " + customerGender);

            //Console.Read();
            #endregion          

            Console.WriteLine("***Menu***");
            Console.WriteLine("******************");
            int pizzaPrice, cokePrice, hamburgerPrice, waterPrice, friesPrice;
            pizzaPrice = 250;
            hamburgerPrice = 300;
            waterPrice = 10;
            friesPrice = 75;
            cokePrice = 30;
            Console.WriteLine("Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Fries: " + friesPrice + " TL");
            Console.WriteLine("Coke: " + cokePrice + " TL");
            Console.WriteLine("Water: " + waterPrice + " TL");

        }
    }
}
