using System;
using System.Text;

namespace Problem14_ASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
        //    Console.OutputEncoding = Encoding.UTF8;
                for (int i = 0; i < 256; i++)
            {
                char symbol = Convert.ToChar(i);
                Console.Write(symbol);
            }
            
        }
    }
}
