using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            float num3 = float.Parse(Console.ReadLine());


            if ((num1 > num2) && (num1 > num3))
            {
                if (num2 > num3)
                {
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", num1, num3, num2);
                }
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                if (num1 > num3)
                {
                    Console.WriteLine("{0} {1} {2}", num2, num1, num3);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", num2, num3, num1);
                }
            }
            else if ((num3 > num1) && (num3 > num2))
            {
                if (num1 > num2)
                {
                    Console.WriteLine("{0} {1} {2}", num3, num1, num2);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", num3, num2, num1);
                }


            }
        }
    }
}
