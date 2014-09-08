using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_CalculateSomething
{
    class CalculateSomething
    {
        static void Main()
        {
            Console.Write("n = ");
            double n =double.Parse(Console.ReadLine());
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            double factorial = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                
                    factorial *= i;
                   
                
               sum =sum + (factorial / Math.Pow(x, i));

            }
           
            Console.WriteLine("The S= {0:0.00000}", sum);
      }
    }
}
