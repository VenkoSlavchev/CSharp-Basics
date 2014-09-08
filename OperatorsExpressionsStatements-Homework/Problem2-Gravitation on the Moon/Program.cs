using System;

namespace Problem2_Gravitation_on_the_Moon
{
    class Program
    {
        static void Main()
        {
            string input =Console.ReadLine();
            double weight =Convert.ToDouble(input);
            float gravityMoon = 0.17f;
            Console.WriteLine("The weight on the moon is {0}", (weight*gravityMoon));
            Console.Read();
        }
    }
}
