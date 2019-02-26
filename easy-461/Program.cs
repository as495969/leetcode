using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_461
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HammingDistance(1,4));
            Console.ReadKey();
        }
        public static int HammingDistance(int x, int y)
        {
            int number = 0;

            if (x < y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            while (x != 0)
            {
                if (x % 2 != y % 2) { number++; }
                x = x / 2;
                y = y / 2;
            }

            return number;
        }
    }
}
