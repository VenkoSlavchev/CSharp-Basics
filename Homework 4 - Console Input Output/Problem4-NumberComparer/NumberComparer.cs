using System;


namespace Problem4_NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("First number: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Max is: {0}", Math.Max(num1,num2));
        }
    }
}
