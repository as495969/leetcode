using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试

        }
        public static bool IsPalindrome(int x)
        {
            bool palindrome = true;
            string num = x.ToString();
            for (int i = 0; i < num.Length-1; i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;

        }
    }
}
