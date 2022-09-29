using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable {
    class Program {

        //***
        //*** Multiplications of 2 ***
        //***
        //
        //2 x 3 = 6

        static void Main(string[] args) {

            //for (int i = 2;i < 12; i++) {
            //    MultOfN(i);
            //}
            MultOfN(23);
            MultOfN(37);
            Console.ReadLine();
        }
        
        private static void MultOfN(int n) {
            Console.WriteLine("***");
            Console.WriteLine("*** Multiplications of " + n + " ***");
            Console.WriteLine("***");


            for (int i = 1; i <= 10; i++) {
                int result = i * n;
                //Console.WriteLine("{0} x {1} = {2}", n, i, result);
                Console.WriteLine($"{n,3} x {i,3} = {result,3}");
                //Console.WriteLine(n + " x " + i  + " = " + result);

            }

            Console.WriteLine();
        }
    }
}
