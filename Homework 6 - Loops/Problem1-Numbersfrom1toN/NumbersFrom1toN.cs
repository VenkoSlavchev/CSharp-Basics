using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_Numbersfrom1toN
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            Console.WriteLine("Input a number N : ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write(" " + i); 
            }
            Console.Read();
        }
    }
}
