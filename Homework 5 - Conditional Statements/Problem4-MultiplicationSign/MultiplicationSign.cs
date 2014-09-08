using System;


namespace Problem4_MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            float num3 = float.Parse(Console.ReadLine());
            float check = num1 * num2 * num3;
            if (check==0)
            {
                Console.WriteLine("0");
            }
            else if (check<0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
