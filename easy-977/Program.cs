using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_977
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Solution
        {
            public int[] SortedSquares(int[] A)
            {
                for (int i= 0; i < A.Length; i++)
                {
                    A[i] = Math.Abs(A[i]);
                    A[i] *= A[i];
                }
                Array.Sort(A);
                return A;
            }
        }
    }
}
