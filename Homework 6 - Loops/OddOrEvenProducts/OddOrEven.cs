using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenProducts
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("numbers are :");
            string numbers = Console.ReadLine();
            string[] number = numbers.Split(' ');
            int productodd = 1;
            int producteven = 1;
            for (int i = 0; i < number.Length; i++)
            {
                int Number = int.Parse(number[i]);
                if (i % 2 == 0)
                {
                    productodd *= Number;

                }
                else
                {
                    producteven *= Number;
                }
            }
            if (productodd == producteven)
            {
                Console.WriteLine("yes");
                Console.WriteLine("Product is = {0}", productodd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("Product Odd is = {0}", productodd);
                Console.WriteLine("Product Even is = {0}", producteven);
            }


        }

    }
}
