using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15_HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {

            Console.Write("Input a Hexadecimal value : ");
            string hex = Console.ReadLine();
            long hexa =  Convert.ToInt64(hex, 16);

            Console.WriteLine("The Decimal representation is :  {0}",hexa);
            Console.ReadLine();
        }
    }
}
