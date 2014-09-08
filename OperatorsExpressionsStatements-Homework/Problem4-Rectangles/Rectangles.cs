using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a width: ");
            string inputwidth = Console.ReadLine();
            Console.WriteLine("Input a high: ");
            string inputhigh = Console.ReadLine();
            double width=Convert.ToDouble(inputwidth);
            int high = Convert.ToInt32(inputhigh);
            double perimeter = (2 * width + 2 * high);
            double area = (width * high);
            Console.WriteLine("The Perimeter is: {0}", perimeter);
            Console.WriteLine("The Area is: {0}", area);
            Console.Read();
        }
    }
}
