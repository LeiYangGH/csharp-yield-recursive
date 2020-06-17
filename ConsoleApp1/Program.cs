using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static IList<char> baseChars = new List<char>() { '0', '1', '2', '3' };

        static void CharsRange1(string prefix, int pos)
        {
            if (pos == 1)
            {
                foreach (char s in baseChars)
                {
                    Console.WriteLine(prefix + s);
                }
            }
            else
            {
                foreach (char s in baseChars)
                {
                    CharsRange1(prefix + s, pos - 1);
                }
            }
        }

        static IEnumerable<string> CharsRange2(string prefix, int pos)
        {
            foreach (char c in baseChars)
            {
                if (pos == 1)
                {
                    yield return prefix + c;
                }
                else
                {
                    foreach (string s in CharsRange2(prefix + c, pos - 1))
                    {
                        yield return s;
                    }
                }
            }
        }

        static IEnumerable<string> CharsRange3(char[] strChars, int pos)
        {
            foreach (char c in baseChars)
            {
                strChars[pos - 1] = c;
                if (pos == 1)
                {
                    yield return new string(strChars);
                }
                else
                {
                    foreach (string s in CharsRange3(strChars, pos - 1))
                    {
                        yield return s;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //CharsRange1("", 3);//working
            //foreach (string s in CharsRange2("", 3))
            //{
            //    Console.WriteLine(s);//nothing
            //}
            foreach (string s in CharsRange3(new char[] { ' ', ' ', ' ' }, 3))
            {
                Console.WriteLine(s);//nothing
            }
            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
