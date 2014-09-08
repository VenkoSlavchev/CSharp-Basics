using System;
using System.Collections.Generic;

namespace Problem3_DivideBy7And5
{
    class DevidedBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Input a number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            bool result;
            result = ((number / 7 != 0 && number / 5 != 0) && (number / 7 != 1 && number / 5 != 1));
                     
                Console.WriteLine(result);
                Console.Read();
                    }

    }
}
