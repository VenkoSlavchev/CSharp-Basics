using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_TheBiggestOf3
{
    class TheBiggestOf3
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            float num3 = float.Parse(Console.ReadLine());
            float firstmax = Math.Max(num1, num2);
            float max = Math.Max(firstmax, num3);
            Console.WriteLine("The biggest number is {0}", max);
        }
    }
}
