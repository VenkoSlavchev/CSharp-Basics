using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double  x1, x2;
            Console.Write("Enter Value in a");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value in b");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value in c");
            float c = float.Parse(Console.ReadLine());
            if ((b * b - 4 * a * c) < 0)
            {
                Console.WriteLine("There are no real roots!");
            }
            else
            {
                
                x1 = ((-1) * b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                x2 = ((-1) * b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
                             
                Console.WriteLine("x1= {0}, x2= {1}", x1, x2);
                Console.ReadLine();
            }
        }
    }
}
