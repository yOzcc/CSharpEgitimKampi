using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 1'den 5'e kadar artan, 5'ten 1'e kadar azalan yıldız oluşturma
            Console.WriteLine("1'den 5'e kadar artan, 5'ten 1'e kadar azalan yıldız oluşturma");
            for(int i = 1; i<=5; i++)
            {
                for(int j= 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int k = 5; k> 1; k--)
            {
                for(int l = 1; l<k; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}

