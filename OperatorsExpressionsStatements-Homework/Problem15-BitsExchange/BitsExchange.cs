using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15_BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            
            
            uint mask3=(7<<3);
            long getbits3=(number & mask3);
            long movebits3 = getbits3 << 21;

            uint mask24 = (7 << 24);
            long getbits24 = (number & mask24);
            long movebits24 = getbits24 >> 21;

            int nuLL3bits = ~(7 << 3);
             number =(number & nuLL3bits);
            int nuLL24bits = ~(7 << 24);
             number =(number & nuLL24bits);

            number= number | movebits3;
            number = number | movebits24;
            Console.WriteLine("After exchange:\n{0}\n{1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));

            
            


            /* 
             {
                 int one = 1 << pointer;
                 int checkOne = number | one;
                 Console.WriteLine(Convert.ToString(checkOne, basic).PadLeft(16, '0'));
                 Console.WriteLine(checkOne);
             }
             else
             {
                 int zero = ~(1 << pointer);
                 int checkZero = number & zero;
                 Console.WriteLine(Convert.ToString(checkZero, basic).PadLeft(16, '0'));
                 Console.WriteLine(checkZero);
             }
         */
        }
    }
}
