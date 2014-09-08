using System;

namespace Problem3_ComparingFloats
{
    class Program
    {
        static void Main()
        {
            decimal Num1 = 5.3m;
            decimal Num2 = 6.01m;
            decimal Num3 = 5.00000001m;
            decimal Num4 = 5.00000003m;
            decimal Num5 = -0.0000007m;
            decimal Num6 = 0.00000007m;
            decimal Num7 = -4.999999m;
            decimal Num8 = -4.999998m;
            decimal eps = 0.0000001m;
            bool equalNum12 = Math.Abs(Num1 - Num2) <= eps;
            bool equalNum34 = Math.Abs(Num3 - Num4) <= eps;
            bool equalNum56 = Math.Abs(Num5 - Num6) <= eps;
            bool equalNum78 = Math.Abs(Num7 - Num8) <= eps;

            Console.WriteLine("Are number {0} and {1} equal? {2}", Num1, Num2, equalNum12);
            Console.WriteLine("Are number {0} and {1} equal? {2}", Num3, Num4, equalNum34);
            Console.WriteLine("Are number {0} and {1} equal? {2}", Num5, Num6, equalNum56);
            Console.WriteLine("Are number {0} and {1} equal? {2}", Num7, Num8, equalNum78);
        }

    }
}