using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EficcientSwap {
    class Program {
        static void Main(string[] args) {
            int a = -1;
            int b = 1;
            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine (a + ", " + b);
            Console.ReadLine();
              
        }
    }
}
