using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_TheBiggestOf5
{
    class TheBiggestOf5
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            float num3 = float.Parse(Console.ReadLine());
            Console.Write("Enter Fourth Number : ");
            float num4 = float.Parse(Console.ReadLine());
            Console.Write("Enter Fifth Number : ");
            float num5 = float.Parse(Console.ReadLine());
            float max;
            float max1;
            float max2;

            if ((num1 == num2)||(num1>num2))
            {
                max1 = num1;
            }
            else
            {
                max1=num2;
            }
             if ((num3==num4)||num3>num4)
            {
                max2 = num3;
            }
            else
             {
                 max2 = num4;
             }
            if ((max1==max2)||(max1>max2))
            {
                max = max1;
            }
            else
            {
                max = max2;
            }
            if (max > num5)
            {
                Console.WriteLine("The biggest is : {0}", max);
            }
            else
            {
                Console.WriteLine("The biggest is : {0}", num5);
            }
        } 

 

    }
}
