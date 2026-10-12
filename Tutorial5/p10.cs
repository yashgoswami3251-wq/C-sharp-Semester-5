using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial5
{
    internal class p10
    {
        public static void program()
        {
            Console.WriteLine("Gauswami Yashgiri && 25SOEIT130");

            Console.WriteLine("Enter Row of matrix :");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter column of matrix :");
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[row,column];
            int[,] matrix2 = new int[row, column];
            int[,] sum = new int[row, column];

            Console.WriteLine("Enter elements of first matrix :");

            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements of second matrix :");

            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("Sum of two matrices :");

            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
