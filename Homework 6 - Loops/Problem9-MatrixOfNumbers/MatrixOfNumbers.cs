using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9_MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                 Console.WriteLine();
                 Console.Write(i);
                for (int j =i+1; j <= n+(i-1); j++)
                {
                    Console.Write(j);                                     
                }
            } 
            Console.Read();
        }
    }
}
