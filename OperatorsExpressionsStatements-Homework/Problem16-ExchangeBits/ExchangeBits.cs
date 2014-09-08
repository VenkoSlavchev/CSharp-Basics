using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16_ExchangeBits
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a number");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("Write k:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Write p:");
            int nachaloBitfirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Write q:");
            int nachaloBitsecond = int.Parse(Console.ReadLine());


            for (int i = 0; i < k; i++)
            {

                long maskone = (1 << nachaloBitfirst);
                long getbitfirst = (number & maskone);
                long movebitfirst = getbitfirst << nachaloBitsecond - nachaloBitfirst;

                long masktwo = (1 << nachaloBitsecond);
                long getbitsecond = (number & masktwo);
                long movebitsecond = getbitsecond >> nachaloBitsecond - nachaloBitfirst;

                long nuLLbitfirst = ~(1 << nachaloBitfirst);
                number = (number & nuLLbitfirst);
                long nuLLbitsecond = ~(1 << nachaloBitsecond);
                number = (number & nuLLbitsecond);

                number = number | movebitfirst;
                number = number | movebitsecond;

                nachaloBitfirst++;
                nachaloBitsecond++;

            }
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);
  
        }
    }
}
