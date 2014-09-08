using System;

namespace SumOfnNumbers
{
    class SumOfNumbers
    {
        static void Main()
        {
              Console.Write("Enter number N : ");
            int number =int.Parse(Console.ReadLine());
            float sum = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.Write("Enter numbers : ");
                float num =float.Parse(Console.ReadLine());
                sum = sum+num;
            }
            Console.WriteLine("The Sum is : {0}", sum);
        }
    }
}
