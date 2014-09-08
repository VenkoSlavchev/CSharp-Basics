using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12_RandomizeTheNumbers
{
    class RandomizeTheNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" n=");
            int n = int.Parse(Console.ReadLine());
            int max = n;
            Random rnd = new Random();
            List<int> printedList = new List<int>();
            int x = rnd.Next(1, max + 1);
            printedList.Add(x);
            n--;

            while (n > 0)
            {
                x = rnd.Next(1, max + 1);
             
                int pos = printedList.IndexOf(x);
                if (pos < 0)
                {
                    printedList.Add(x); 
                    n--;
                }
            }
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(printedList[i]);    
            }
            
        }

    }
}






                    
                
                    
            
        
    

