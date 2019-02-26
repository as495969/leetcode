using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_961
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 2, 5, 3, 2 };
            Console.WriteLine(Solution.RepeatedNTimes(a));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public static int RepeatedNTimes(int[] A)
        {
            Array.Sort(A);
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (dic.ContainsKey(A[i]))
                {
                    dic[A[i]]++;
                }
                else
                {
                    dic.Add(A[i], 1);
                }
            }
            int key = 0;
            int value = 0;
            foreach (KeyValuePair<int, int> item in dic)
            {
                if (item.Value > value)
                {
                    key = item.Key;
                    value = item.Value;
                }
            }
            return key;
        }
    }
}
