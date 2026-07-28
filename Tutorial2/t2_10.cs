using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial2
{
    internal class t2_10
    {
        public static void matrix()
        {
            static int MatSearch(int[,] mat,int n, int m , int x)
            {
                int row = 0;
                int col = m-1;

                while(row<n && col >= 0)
                {
                    if (mat[row, col] == x)
                        return 1;

                    else if (mat[row, col] > x)
                        col--;

                    else
                        row++;
                }
                return 0;
            }

            static void Main(string[] args)
            {
                int[,] mat =
                {
                    {20,56,12 },
                    {34,51,76 },
                    {98,23,43 }
                };

                int result = MatSearch(mat, 3, 3, 12);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
