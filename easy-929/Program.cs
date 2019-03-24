using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_929
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEmails = Solution.NumUniqueEmails(
                new string[]
                {
                    "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com",
                    "testemail+david@lee.tcode.com"
                });
            ;

            Console.WriteLine(countEmails);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public static int NumUniqueEmails(string[] emails)
        {
            List<string> EamilList = new List<string>();
            for (int i = 0; i < emails.Length; i++)
            {
                string emailLeftNode = emails[i].Split('@')[0].Split('+')[0].Replace(".", "");
                string emailRightNode = emails[i].Split('@')[1];
                if (!EamilList.Contains(emailLeftNode + emailRightNode))
                {
                    EamilList.Add(emailLeftNode + emailRightNode);
                }
            }
            return EamilList.Count;
        }
    }
}
