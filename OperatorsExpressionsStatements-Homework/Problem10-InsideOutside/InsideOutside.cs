using System;

namespace Problem10_InsideOutside
{
    class InsideOutside
    {
        static void Main()
        {
            


            Console.WriteLine("Input x:");
            string inputx = Console.ReadLine();
            double x = Convert.ToDouble(inputx);
            Console.WriteLine("Input y:");
            string inputy = Console.ReadLine();
            double y = Convert.ToDouble(inputy);
            int centerx = 1;
            int centery = 1;
            double radius = 1.5;
           bool circle;
           circle = (Math.Pow((x - centerx), 2) + Math.Pow((y - centery), 2)) <= Math.Pow(radius, 2);
           bool rectangle;
           rectangle = !(((x <= 5) && (x >= -1)) && ((y <= 1) && (y >= -1)));
            if (circle == true && rectangle == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }  
            
            
            Console.Read();
        }
    }
}
