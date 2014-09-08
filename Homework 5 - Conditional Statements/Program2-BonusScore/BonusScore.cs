using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2_BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.Write("Enter a score : ");

            int score = int.Parse(Console.ReadLine());
            switch (score)
            {
                case 1:                 
                case 2:
                case 3:
                    score = score * 10;
                    Console.WriteLine("The score is : {0}", score);
                    break;
                case 4:
                case 5:
                case 6:
                    score = score * 100;
                    Console.WriteLine("The score is : {0}", score);
                    break;
                case 7:
                case 8:
                case 9:
                    score = score * 1000;
                    Console.WriteLine("The score is : {0}", score);
                    break;
                default:
                    Console.WriteLine("Invalid score!");
                    break;
            }

        }
    }
}
