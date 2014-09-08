using System;

namespace Problem1_ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Write the first number : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Write the second number : ");
            float num2 = float.Parse(Console.ReadLine());
            float change;
            if(num1>num2)
            {
                change = num2;
                num2 = num1;
                num1=change;
            }
            Console.WriteLine("The numbers are : {0} {1}", num1, num2);
        }
    }
}
