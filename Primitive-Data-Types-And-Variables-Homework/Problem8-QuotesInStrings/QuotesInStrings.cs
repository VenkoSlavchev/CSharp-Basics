using System;
namespace Problem7
{
    class QuotesInStrings
    {
        static void Main()
        {
            string a = "The \"use\" of the quotations causes difficulties";
            string b = @"The""use"" of the quotations causes difficulties";
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
