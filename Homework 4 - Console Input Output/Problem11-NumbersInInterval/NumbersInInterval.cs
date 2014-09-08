using System;

namespace Problem11_NumbersInInterval
{
    class NumbersInInterval
    {
        static void Main()
        {

            Console.Write("Enter the begin of interval  : ");
            int begin = int.Parse(Console.ReadLine());
            Console.Write("Enter the end of interval  : ");
            int end = int.Parse(Console.ReadLine());
            int count=0;
            for (int i = begin; i <= end; i++)
            {
                if(begin%5==0)
                {
                    Console.WriteLine("The Numbers are {0} ", begin);
                    begin++;
                    count++;
                }
                else
                {
                    begin++;
                }

                
           }
            Console.WriteLine("The numbers p : {0}", count);
            
        }

    }
}
