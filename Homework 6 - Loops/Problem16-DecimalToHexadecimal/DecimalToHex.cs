using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16_DecimalToHexadecimal
{
    class DecimalToHex
    {
        static void Main()
        {
            Console.WriteLine("Input a Decimal number :  ");
            int n = int.Parse(Console.ReadLine());
          
            string hex = n.ToString("X");
            
                Console.WriteLine("Hexadecimal representation is  {0}", hex);
                Console.Read();
            }
            
        }
    }

