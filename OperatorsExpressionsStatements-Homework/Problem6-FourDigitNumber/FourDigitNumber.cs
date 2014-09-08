using System;

namespace Problem6_FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Input a number");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            while (number < 1000 || number > 9999) Console.WriteLine("Incorrect Number!");

            int firstnumber;
            int secondnumber;
            int thirdnumber;
            int fourthnumber;
            int sum;

            
                fourthnumber = number % 10;
                number = number / 10;
                thirdnumber = number % 10;
                number = number / 10;
                secondnumber = number % 10;
                number = number / 10;
                firstnumber = number % 10;
                number = number / 10;
                while (firstnumber == 0) Console.WriteLine("Incorrect Number!");
                    
                sum = (firstnumber + secondnumber + thirdnumber + fourthnumber);
                Console.WriteLine("Sum of the digits is: {0}", sum);
                Console.WriteLine("Reverse : {0}{1}{2}{3}", fourthnumber, thirdnumber, secondnumber, firstnumber);
                Console.WriteLine("The last digit goes first : {0}{1}{2}{3}", fourthnumber, firstnumber, secondnumber, thirdnumber);
                Console.WriteLine("Exchange the second and the third digit : {0}{1}{2}{3}", firstnumber, thirdnumber, secondnumber, fourthnumber);
                Console.Read();
            
        }
    }
}
