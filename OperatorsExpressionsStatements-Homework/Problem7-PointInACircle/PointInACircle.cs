using System;

namespace Problem7_PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Input x:");
            string inputx = Console.ReadLine();
            double x = Convert.ToDouble(inputx);
            Console.WriteLine("Input y:");
            string inputy = Console.ReadLine();
            double y = Convert.ToDouble(inputy);
            Console.WriteLine(((x*x)+(y*y)<=(2*2)));
            Console.Read();


        }
    }
}
