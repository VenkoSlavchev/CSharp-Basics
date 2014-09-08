using System;

namespace Problem13_CheckABit
{
    class CheckABin
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
            bool check = false;
            if (rest==1)
            {
                check = true;
            }
          	Console.WriteLine(check);
        }
    }
}
