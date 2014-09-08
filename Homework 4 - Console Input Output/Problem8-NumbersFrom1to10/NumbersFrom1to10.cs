using System;

namespace Problem8_NumbersFrom1to10
{
    class NumbersFrom1to10
    {
        static void Main()
        {
            Console.Write("Enter number : ");
            int number =int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
