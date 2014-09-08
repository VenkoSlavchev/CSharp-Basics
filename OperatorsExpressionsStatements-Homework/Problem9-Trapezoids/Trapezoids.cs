using System;


namespace Problem9_Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Input a:");
            string inputa = Console.ReadLine();
            double a = Convert.ToDouble(inputa);
            Console.WriteLine("Input b:");
            string inputb = Console.ReadLine();
            double b = Convert.ToDouble(inputb);
            Console.WriteLine("Input h:");
            string inputh = Console.ReadLine();
            double h = Convert.ToDouble(inputh);
            Console.WriteLine("The area is: {0}", ((a+b)/2)*h);
            Console.Read();
                }
    }
}
