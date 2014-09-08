using System;

namespace Problem3_CirclePerimeterArea
{
    class CirclePerimeterArea
    {
        static void Main()
        {
            float radius = float.Parse(Console.ReadLine());
            float pi = 3.14f;
            Console.WriteLine("The Perimeter is : {0:0.00}, and the Area is : {1:0.00}",2*pi*radius,2*pi*(radius*radius));
        }
    }
}
