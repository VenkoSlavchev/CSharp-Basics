using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14_DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Input a Decimal number : ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("The Binary representation is :  {0}", result);
        }
    }
}
