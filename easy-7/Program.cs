using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(-1020));
            Console.ReadKey();
        }
        public static int Reverse(int x)
        {
            bool end = false;
            bool positive = true;
            if (x < 0)
            {
                x = -x;
                positive = false;
            }
            string old_x = x.ToString();
            string new_x = string.Empty;
            for (int i = old_x.Length - 1; i >= 0; i--)
            {
                int temp = 0;
                int.TryParse(old_x[i].ToString(), out temp);
                if (temp != 0)
                {
                    end = true;
                }
                if (end) { new_x += old_x[i]; }
            }
            if (!positive)
            {
                new_x = '-' + new_x;
            }
            int int_x = 0;
            if (int.TryParse(new_x, out int_x))
            {
                return int_x;
            }
            else { return 0; }

        }
    }
}
