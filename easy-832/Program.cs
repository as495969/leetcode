using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_832
{
    class Program
    {
        static void Main(string[] args)
        {
            //[[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
            int[][] A = new int[4][];
            A[0] = new int[4] { 1, 1, 0, 0 };
            A[1] = new int[4] { 1, 0, 0, 1 };
            A[2] = new int[4] { 0, 1, 1, 1 };
            A[3] = new int[4] { 1, 0, 1, 0 };
            FlipAndInvertImage(A);
            Console.ReadKey();
        }



        public static int[][] FlipAndInvertImage(int[][] A)
        {
            for (int i = 0; i <= A.Length - 1; i++)
            {
                for (int j = 0; j < A[i].Length / 2; j++)
                {
                    int temp = A[i][j];
                    A[i][j] = A[i][A[i].Length - j - 1];
                    A[i][A[i].Length - j - 1] = temp;
                }
            }
            for (int i = 0; i <= A.Length - 1; i++)
            {
                for (int j = 0; j <= A[i].Length - 1; j++)
                {
                    if (A[i][j] == 0)
                    {
                        A[i][j] = 1;
                    }
                    else
                    {
                        A[i][j] = 0;
                    }
                }
            }
            return A;
        }
    }
}
