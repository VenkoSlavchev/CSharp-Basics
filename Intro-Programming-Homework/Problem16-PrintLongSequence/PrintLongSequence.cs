using System;

namespace Problem16_PrintLongSequence
{
    class LongSequence
    {
        static void Main()
        {
            const int firstnumber = 2;
            for (int i = 0; i < 1001; i++)
            {
                int number = i + firstnumber;
                if (number % 2 != 0)
                    number = number * -1;
                Console.Write(number);
                Console.Write(",");
            }
        }
    }
}
