using System;

namespace Problem10_ExchangeVariableValues
{
    class ExchangeValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Chisloto a e{0}", a);
            Console.WriteLine("Chisloto b e{0}", b);
            int c = b;
            b = a;
            a = c;
            Console.WriteLine("Chisloto a e{0}", a);
            Console.WriteLine("Chisloto b e{0}", b);
        }
    }
}
