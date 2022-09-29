using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todelete {
    class Program {
        static void Main(string[] args) {
            int a = 0;
            for (int b = 55; b > 0; a++, b = b - a) {
                Console.WriteLine(a + " , " + b);
            }
            Console.WriteLine("Result: " + a);
            Console.ReadLine();
        }
    }
}
