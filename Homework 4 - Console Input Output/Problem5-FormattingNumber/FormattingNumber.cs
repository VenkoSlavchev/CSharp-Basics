using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_FormattingNumber
{
    class FormattingNumber
    {
        static void Main(string[] args)
        {
            
            
            
            
                Console.WriteLine("a=");
                int num1 = int.Parse(Console.ReadLine());
            if ((num1<=500) && (0<=num1))
            { Console.WriteLine("b=");
                float num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("c=");
                float num3 = float.Parse(Console.ReadLine());
                string bin = Convert.ToString(num1, 2).PadLeft(10, '0');
                Console.WriteLine("{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10:0.000}|", num1, bin, num2, num3);
            }
            else
            {
                Console.Write("invalid number 'a'-");
                Console.WriteLine("0<= a<=500");
            }                            
            


          }

        }
    }     

