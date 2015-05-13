using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Maximal_Sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.Write("Number of rows = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Number of columns = ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            //Enter elements of matrix
            for (int i = 0; i < rows; i++)
            {
                string RowString = Console.ReadLine();
                string[] RowItems = RowString.Split(' ');
                int[] RowNumbers = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    RowNumbers[j] = int.Parse(RowItems[j]);
                    matrix[i, j] = RowNumbers[j];
                }
                Console.WriteLine();
            }
            ////print matrix
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j <cols; j++)
            //    {
            //        Console.Write(matrix[i,j]+"  ");
            //    }
            //    Console.WriteLine();
            //}


            // Find the maximal sum platform of size 3 x 3
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] 
                            + matrix[row + 1, col]+matrix[row + 1, col + 1] +matrix[row+1, col+2]
                            + matrix[row + 2, col] + matrix[row + 2, col+1] + matrix[row + 2, col+2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            // Print the result
            Console.WriteLine("The best platform is:");
            Console.WriteLine("  {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
            Console.WriteLine("The maximal sum is: {0}", bestSum);
        }
    }
}
