using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonPrefix("aca", "cba"));
            Console.ReadKey();
        }
        public static string LongestCommonPrefix(params string[] strs)
        {
            string minString = string.Empty;
            if (strs.Length == 1)
            {
                return strs[0];
            }
            if (strs.Length > 1)
            {
               minString  = strs[0];
            }
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < minString.Length)
                {
                    minString = strs[i];
                }
            }
            string maxLong = "";

            for (int i = 0; i < minString.Length ; i++)
            {
                bool same = true;
                foreach (string item in strs)
                {
                    if (item[i] != minString[i])
                    {
                        same = false;
                        break;
                    }
                }
                if (same)
                {
                    maxLong += minString[i];
                }
                else
                {
                    break;
                }
            }
            return maxLong;
        }
    }
}
