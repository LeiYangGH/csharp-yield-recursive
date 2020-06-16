using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static IList<string> baseChars = new List<string>() { "0", "1", "2", "3" };

        static void CharsRange1(string prefix, int pos)
        {
            if (pos == 1)
            {
                foreach (string s in baseChars)
                {
                    Console.WriteLine(prefix + s);
                }
            }
            else
            {
                foreach (string s in baseChars)
                {
                    CharsRange1(prefix + s, pos - 1);
                }
            }
        }

        static IEnumerable<string> CharsRange2(string prefix, int pos)
        {
            if (pos == 1)
            {
                foreach (string s in baseChars)
                {
                    yield return prefix + s;
                }
            }
            else
            {
                foreach (string s in baseChars)
                {
                    CharsRange2(prefix + s, pos - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            //CharsRange1("", 3);//working
            foreach (string s in CharsRange2("", 3))
            {
                Console.WriteLine(s);//nothing
            }
            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
