using System;

namespace Problem_11_ExtractBit3
{
    class ExtractBin
    {
        static void Main()
        {
            Console.WriteLine("Input a number:");
            string input= Console.ReadLine();
            int number = Convert.ToInt32(input);
            int basic = 2;
            string changetobin = Convert.ToString(number ,basic);          
            long bin = Convert.ToInt64(changetobin);
            long rest = 0;
            for (int i=0; i < 4; i++)
            {
                rest = bin % 10;
                bin = bin / 10;
            }
            
            Console.WriteLine("Bit at index 3 is: {0}", rest);
        }
        
    }
}
