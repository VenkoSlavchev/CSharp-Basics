using System;

namespace Problem1_SumOfThreeIntegers
{
    class SumOf3Integers
    {
        static void Main()
        {
            Console.Write("The first number :");
            int first = int.Parse(Console.ReadLine());
            Console.Write("The second number :");
            int second = int.Parse(Console.ReadLine());
            Console.Write("The third number :");
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine("The Sum is : {0}",first+second+third);
        }
    }
}
