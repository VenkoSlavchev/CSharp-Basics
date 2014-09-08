using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12_ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter Fourth Number : ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Enter Fifth Number : ");
            int num5 = int.Parse(Console.ReadLine());
            bool check = false;
            List<int> mas =new List<int> { num1, num2, num3, num4, num5 };
            int sum = num1+num2+num3+num4+num5;
            if (sum == 0)
            {
                check = true;
                Console.WriteLine("Zero Subset is {0}{1}{2}{3}{4}", num1,num2,num3,num4,num5 );
            }
            foreach (var first in mas)
            {
                if (first == sum)
                {
                    check = true;
                    Console.WriteLine("Zero Subset is ");
                    foreach (var second in mas)
                    {
                        if (first != second)
                        {
                            Console.Write(second + " ");
                        }
                    }
                    Console.Write(").");
                    Console.WriteLine();  
                  }
            }
            foreach (var number in mas)
                
	            {
		              foreach (var nextnumber in mas)
	                    {
	                        if ((number!= nextnumber) && (number + nextnumber == 0))
	                            {
                                       check= true;
                                       Console.WriteLine("Zero Subset is {0} {1}", number, nextnumber);
                                   
	                            }	 
	                    
                if ((number!=nextnumber)&&(number+nextnumber == sum))
                          {
                              check = true;
                              foreach (var afternextnumber in mas)
                              {
                                  if(afternextnumber!=number && afternextnumber!=nextnumber)
                                  {
                                      check = true;
                                      
                                      Console.Write(afternextnumber + " ");
                                  }
                              }
                              Console.Write(").");
                              Console.WriteLine();
	                      }

                      }
	            }
            if (check == false)

	{
		 Console.WriteLine("No Zero Subset");
	}
         Console.ReadLine();


        }




    }
}
