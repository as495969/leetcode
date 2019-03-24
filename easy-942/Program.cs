using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_942
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Solution.DiStringMatch("IDID");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(i + " "+ints[i]);
            }
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public static int[] DiStringMatch(string S)
        {
            int Count = S.Length;
            int ICount = 0;
            int DCount = Count;
            int[] ReArray = new int[Count + 1];
            for (int i = 0; i < Count ; i++)
            {
                
                    if (S[i] == 'I')
                    {
                        ReArray[i] = ICount;
                        ICount++;
                    }
                    else if(S[i]=='D')
                    {
                        ReArray[i] = DCount;
                        DCount--;
                    }
            }

            ReArray[Count] = ICount;

            return ReArray;
        }
    }
}
