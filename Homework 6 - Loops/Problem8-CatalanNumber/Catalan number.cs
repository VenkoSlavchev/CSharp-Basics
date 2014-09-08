using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_CatalanNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int factorialn = 1;
            int factorial2n = 1;
            int factorial3n = 1;
            int result = 0;
            int n2 = 2 * n;
            int n3 = n + 1;
            if ((1 < n) && (n > 100))
            {
                for (int i = 1, j = n; i <= n2; j--, i++)
                {
                    factorial2n *= i;
                    if (j > 0)
                    {
                        factorialn *= j;
                    }
                }
                for (int k = 1; k <= n3; k++)
                {
                    factorial3n *= k;
                }
                result = factorial2n / (factorial3n * factorialn);
                Console.WriteLine("Catalan Number is {0}", result);
                Console.ReadLine();
            }
        }
         
    }
}
