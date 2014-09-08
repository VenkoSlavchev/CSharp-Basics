using System;

namespace Problem12_ExtractBit
{
    class ExtractBit
    {
        static void Main()
        {
            Console.WriteLine("Input a number:");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine("Input a pointer:");
            string inputp = Console.ReadLine();
            int pointer = Convert.ToInt32(inputp);
            int basic = 2;
            string changetobin = Convert.ToString(number, basic);
            long bin = Convert.ToInt64(changetobin);
            long rest = 0;
            for (int i = 0; i < pointer + 1; i++)
            {
                rest = bin % 10;
                bin = bin / 10;
            }

            Console.WriteLine("Bit at index P is: {0}", rest);
        }
    }
}
