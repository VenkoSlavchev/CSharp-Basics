using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19_SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            string direction = "right";
            for (int i = 1; i <= n*n; i++)
            {
                matrix[row, col] = i;
                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }

                if(direction == "right" && (col>n-1 || matrix[row,col]!=0))
                {
                    direction = "down";
                    col--;
                    row++;
                }                
                if(direction == "down" && (row>n-1 || matrix[row,col]!=0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if(direction == "left" && (col<0 || matrix[row,col]!=0))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,4}",matrix[r,c]);
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();






        }
    }
}
