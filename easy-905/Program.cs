using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_905
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Solution.SortArrayByParity(new int[] { 3, 1, 2, 4 });
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public static int[] SortArrayByParity(int[] A)
        {
            int[] ReArray = new int[A.Length];
            int LeftCount = 0;
            int RightCount = A.Length - 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    ReArray[LeftCount] = A[i];
                    LeftCount++;
                }
                else
                {
                    ReArray[RightCount] = A[i];
                    RightCount--;
                }
            }

            return ReArray;

        }
    }
}
