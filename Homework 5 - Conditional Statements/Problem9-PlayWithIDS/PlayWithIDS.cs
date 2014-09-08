using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9_PlayWithIDS
{
    class PlayWithIDS
    {
        static void Main()
        {
            Console.Write("Chose a type : ");
            string type = Console.ReadLine();
            switch (type)
            {
                case "1": Console.WriteLine("Input int number : ");
                    int number = int.Parse(Console.ReadLine());
                    number = number + 1;
                    Console.WriteLine("Result is : {0}", number);
                    break;
                case "2": Console.WriteLine("Input double number : ");
                    double numbertwo = double.Parse(Console.ReadLine());
                    numbertwo = numbertwo + 1;
                    Console.WriteLine("Result is : {0}", numbertwo);
                    break;
                case "3": Console.WriteLine("Input string : ");
                    string str = (Console.ReadLine());
                    Console.WriteLine("Result is : {0}*", str);
                    break;
                default: Console.WriteLine("Invalid Input!");
                    break;
                    Console.Read();
            }
        }
    }
}
