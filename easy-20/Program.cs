using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            Console.WriteLine(IsValid("(])"));
            Console.ReadKey();
        }
        public static bool IsValid(string s)
        {
            if (s.Length < 2) { return false; }
            if (s[0] == ')' || s[0] == ']' || s[0] == '}') return false;
            bool valid = true;
            List<char> valids = new List<char>();
            foreach (char item in s)
            {
                switch (item)
                {
                    case '(':
                    case '[':
                    case '{': valids.Add(item); break;
                    case ')':
                        if (valids.Count == 0) return false;
                        if (valids[valids.Count - 1].Equals('('))
                        {
                            valids.RemoveAt(valids.Count - 1);
                        }
                        else { return false; }
                        break;
                    case ']':
                        if (valids.Count == 0) return false;
                        if (valids[valids.Count - 1].Equals('['))
                        {
                            valids.RemoveAt(valids.Count - 1);
                        }
                        else { return false; }
                        break;
                    case '}':
                        if (valids.Count == 0) return false;
                        if (valids[valids.Count - 1].Equals('{'))
                        {
                            valids.RemoveAt(valids.Count - 1);
                        }
                        else { return false; }
                        break;
                }
            }
            if (valids.Count == 0) valid = true;
            return valid;
        }
    }
}
