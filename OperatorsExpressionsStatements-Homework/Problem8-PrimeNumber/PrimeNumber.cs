using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            bool prime= false;
            while (number < 1 && number > 100) Console.WriteLine("Incorrect number!");
            if (number == 1 || number == 0)
            {
                Console.WriteLine(prime);
            }
            else if (number == 2 || number == 3 || number == 5 || number == 7)
            {
                prime = true;
                Console.WriteLine(prime); 
            }
            else if (number % 2 == 0 || number % 3 == 0  || number % 5 == 0  || number % 7 == 0)
            {
                prime = false;
                Console.WriteLine(prime);
            }   
            else
            {
                prime = true;
                Console.WriteLine(prime);
            }

        }
    }
}