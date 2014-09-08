using System;

namespace Problem14_ModifyABit
{
    class ModifyABit
    {
        static void Main()
        {
            Console.WriteLine("Input a number:");
            string input = Console.ReadLine();
            Console.WriteLine("Input a pointer:");
            string inputp = Console.ReadLine();
            Console.WriteLine("Input a value:");
            string inputv = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int pointer = Convert.ToInt32(inputp);
            int value = Convert.ToInt32(inputv);
            int basic = 2;

            Console.WriteLine(Convert.ToString(number, basic).PadLeft(16, '0'));

            if (value == 1)
            {
                int one = 1 << pointer;
                int checkOne = number | one;
                Console.WriteLine(Convert.ToString(checkOne, basic).PadLeft(16, '0'));
                Console.WriteLine(checkOne);
            }
            else
            {
                int zero = ~(1 << pointer);
                int checkZero = number & zero;
                Console.WriteLine(Convert.ToString(checkZero, basic).PadLeft(16, '0'));
                Console.WriteLine(checkZero);
            }


            
           
            
        }
    }
}
