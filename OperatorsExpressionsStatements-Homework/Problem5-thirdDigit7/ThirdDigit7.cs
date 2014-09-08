using System;

namespace Problem5_thirdDigit7
{
    class ThirdDigit7
    {
        static void Main()
        {
            Console.WriteLine("Input a number");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int check =0;
            for (int i = 0; i < 3; i++)
            {
                check = number % 10;
                number = number / 10;
            }   
                                               
 			 if (check==7)
             {
                 Console.WriteLine("True");
             }
             else
             {
                 Console.WriteLine("false");
             }
            
              Console.Read();
        }
    }
}
