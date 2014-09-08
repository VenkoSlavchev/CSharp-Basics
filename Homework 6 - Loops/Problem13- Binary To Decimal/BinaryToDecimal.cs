using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13__Binary_To_Decimal
{
    class BinaryToDecimal
    {
        static void Main()
        {

            Console.WriteLine("Input a Binary Number : ");
            string binary = Console.ReadLine();
            long result = 0;
            int counter = 1;
            for (int i = binary.Length; i > 0; i--)
            {
                string lastdigit = binary.Substring(i - 1, 1);
                int digit = int.Parse(lastdigit);
                long firstDecimal = digit * counter;
                counter *= 2;
                result += firstDecimal;
            }
            Console.WriteLine("Decimal representation is : {0}", result);
            Console.Read();
        }
    }
}
