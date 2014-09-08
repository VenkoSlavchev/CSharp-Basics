using System;

namespace Problem12_NullAritmetics
{
    class NullAritmetics
    {
        static void Main()
        {
            int? nullInteger = null;
            double? floatNumber = null;
            Console.WriteLine("Null Value: {0} ", nullInteger);
            Console.WriteLine("Null Value: {0} ", floatNumber);

            nullInteger += 9;
            floatNumber += 3.1;
            Console.WriteLine("Null Value: {0} ", nullInteger);
            Console.WriteLine("Null Value: {0} ", floatNumber);

            nullInteger = 9;
            floatNumber = 3.1;
            Console.WriteLine("Null Value: {0} ", nullInteger);
            Console.WriteLine("Null Value: {0} ", floatNumber);
        }
    }
}
