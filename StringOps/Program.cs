using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOps {
    class Program {
        static void Main(string[] args) {

            StrOps s = new StrOps();
            /*
            Console.WriteLine(s.WordCount(null));
            Console.WriteLine(s.WordCount(""));
            Console.WriteLine(s.WordCount(" "));
            Console.WriteLine(s.WordCount("     "));
            Console.WriteLine(s.WordCount("     a"));
            Console.WriteLine(s.WordCount("     a   "));
            Console.WriteLine(s.WordCount("a     a"));
            Console.WriteLine(s.WordCount("a"));
            Console.WriteLine(s.WordCount("abc"));
            Console.WriteLine(s.WordCount("abc d"));
            Console.WriteLine(s.WordCount("abc d e"));
            Console.WriteLine(s.WordCount("abc def "));
            Console.WriteLine(s.WordCount("abc def hhd"));
            Console.WriteLine(s.WordCount("  abc def  hhd "));
            Console.WriteLine(s.WordCount("abc, d "));
            */
            /*
            string a = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            for(int i = 0; i < 1000; i++)
                Console.WriteLine(s.Reverse(a));
            */
            //Console.WriteLine(s.SubString("abc defg", 3, 5));
            //Console.WriteLine(s.IndexOf(null, "aaa"));
            Console.WriteLine(s.IsPalindromIgnorePuncs("Madam, I'm Adam."));
            Console.ReadLine();
        }
    }
}
