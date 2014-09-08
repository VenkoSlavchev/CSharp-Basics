using System;

namespace Problem1_OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Input a number");
            int number;
            string input;
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            if (number % 2 == 0) 
            {
                Console.WriteLine("It is Even: ");
            }
                else 
            {
                Console.WriteLine("It is Odd:");
            }
            Console.Read();
        }
    }
}
