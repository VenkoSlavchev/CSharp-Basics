using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_NotDivisableby3and7
{
    class NotDivisableBy3and7
    {
        static void Main()
        {
            Console.WriteLine("Input a number N : ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if ((i % 3 == 0) || (i % 7 == 0))
                    continue;
                Console.Write(" " + i);
            }
            Console.ReadLine();
        }
    }
}
