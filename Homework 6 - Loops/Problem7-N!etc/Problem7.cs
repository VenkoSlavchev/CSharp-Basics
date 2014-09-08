using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_N_etc
{
    class Problem7
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int factorialn = 1;
            int factorialk = 1;
            int difference = n - k; 
            int factorialDifference = 1;
            int result = 0;
             
            if ((1 < k) && (n < 100) && (k < n))
            {
                    for (int i = 1, j = k; i <= n; i++, j--)
                    {
                        factorialn *= i;
                        if (j > 0)
                        {
                            factorialk *= j;
                        }

                    }
                for (int l = 1; l <= difference; l++)
                {

                    factorialDifference *= l;
                }
                    result = factorialn / (factorialk * factorialDifference);
                } Console.WriteLine("The Result is {0}", result);
                Console.Read();
            }
        }
    }
