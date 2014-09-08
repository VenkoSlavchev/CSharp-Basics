using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11_RandomNumbersInRange
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("min=");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("max=");
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            if (min < max)
            {
                for (int i = 0; i < n; i++)
                {
                    
                    int randomNumber = rnd.Next(min, max+1);
                    Console.Write(randomNumber+" ");
                }
            }
        }
    }
}
