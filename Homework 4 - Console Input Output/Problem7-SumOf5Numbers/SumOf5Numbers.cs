using System;
using System.Linq;

namespace Problem7_SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Console.Write("Enter numbers in a single line : ");
            string number = Console.ReadLine();
            string[] elements = number.Split(' ');
            int sum =0;
            for (int i = 0; i < elements.Length; i++)
            {
               int check = int.Parse(elements[i]);
               sum = sum + check;
            }
            Console.WriteLine("The Sum is: {0}", sum);
        }
    }
}
