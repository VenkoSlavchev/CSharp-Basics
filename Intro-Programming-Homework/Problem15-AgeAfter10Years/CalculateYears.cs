using System;

namespace Problem15_AgeAfter10Years
{
    class Age
    {
        static void Main()
        {
            Console.WriteLine("Write your age");
            string line = Console.ReadLine();
            int value;
            int.TryParse(line,out value);
            value = value + 10;
            Console.WriteLine("After 10 years you will be:");
            Console.WriteLine(value);
        }
    }
}
