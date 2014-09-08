using System;

namespace Problem10_FibonacciNumbers
{
    class FibunacciNumbers
    {
        static void Main()
        {

            Console.Write("Enter number N : ");
            int number = int.Parse(Console.ReadLine());
            int num1=0;
            int num2=1;
            int sum = 0;
            Console.Write(num1);
            Console.Write(num2);
            for (int i = 2; i < number; i++)
            {
                sum = num2 + num1;
                Console.Write(sum);
                num1 = num2;
                num2 = sum;

            }
            Console.ReadLine();
           
                }
        
       
        }

    }

