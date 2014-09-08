using System;
using System.Text;

namespace Problem8
{
    class IsoscelesTriangle
    {

        static void Main()
        {
            //This is different triangle,made with for loops and i like it much more than those in the problem.
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = '\u00A9';
            int row = 3;
            int col = 5;
            double counter = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < (col - counter) / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < counter; j++)
                {
                    Console.Write(symbol);
                }
                counter += 2;
			    Console.WriteLine();
			} 
       /*This is the triangle from the Problem
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = '\u00A9';
            Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", symbol);
            */
            }

            
        
        }

    }

 
    

