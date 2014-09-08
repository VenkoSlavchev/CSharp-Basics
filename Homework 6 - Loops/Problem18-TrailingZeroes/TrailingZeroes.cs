using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem18_TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main()
        {
            Console.WriteLine("Input a number n ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int count=0;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial is {0}",factorial);
            for (int j = 0; j < n; j++)
            {
                if(factorial%10==0)
                {
                    count++;
                    factorial = factorial / 10;
                }
            }
            Console.WriteLine("It has {0} zeroes",count);
            Console.ReadLine();
        }
    }
}
