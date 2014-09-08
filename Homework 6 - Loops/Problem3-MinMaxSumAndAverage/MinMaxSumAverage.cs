using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_MinMaxSumAndAverage
{
    class MinMaxSumAverage
    {
        static void Main()
        {
            Console.WriteLine("Input a number N : ");
            int number = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            float sum = 0;
            float avg=0;
            for (int i = 0; i < number; i++)
            {
                
                Console.Write("Input a number : ");
                int n = int.Parse(Console.ReadLine());
                if(n>max)
                {
                    max = n;
                }
                if (n < min)
                {
                    min = n;
                }
                sum = sum + n;
                avg = sum / number;
            }
            Console.WriteLine("max : {0}", max);
            Console.WriteLine("min : {0}", min);
            Console.WriteLine("sum : {0}", sum);
            Console.WriteLine("avg : {0:0.00}", avg);
            Console.ReadLine();
        }
    }
}
