using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_852
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = Solution.PeakIndexInMountainArray(new int[] {0, 2, 1, 0});
            Console.WriteLine(key);
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public static int PeakIndexInMountainArray(int[] A)
        {
            int Key = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > A[i + 1])
                {
                    Key = i;
                    break;
                }
            }

            return Key;
        }
    }
}
