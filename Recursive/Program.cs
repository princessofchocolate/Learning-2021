using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive {
    class Program {
        static void Main(string[] args) {
            /*
            Factorial f = new Factorial();
            int result= f.F(5);
            Console.WriteLine(result);
            Console.ReadLine();
            */
            Fibonacci ff = new Fibonacci();
            int resultf = ff.F(7);
            Console.WriteLine(resultf);
            Console.ReadLine();
        }
    }
}
