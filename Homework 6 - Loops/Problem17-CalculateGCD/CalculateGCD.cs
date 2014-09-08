using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17_CalculateGCD
{
    class CalculateGCD
    {
        static int FindBiggerNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static int FindSmallerNumber(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main()
        {
            Console.WriteLine("Input a number a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a number b ");
            int b = int.Parse(Console.ReadLine());
            int max = Math.Max(a,b);
            int min = Math.Min(a,b);
            do
            {

                int difference = max - min;
                max = FindBiggerNumber(difference, min);
                min = FindSmallerNumber(difference, min);

            }
            while (max != min);
            Console.WriteLine(min);
        }

    }
    
}


