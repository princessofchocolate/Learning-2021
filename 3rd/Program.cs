using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd {
    class Program {
        static void Main(string[] args) {
            int[] numbers = { 1, 3, 5, 7 };
            int[] numbers2 = { 10, 30, 50, 70, 90 };
            int[] numbers3 = { 100, 300, 500, 700, 900 };

            sumAndPrint(numbers);
            sumAndPrint(numbers2);
            sumAndPrint(numbers3);

            Console.WriteLine(mult(3, 6));
            Console.ReadLine();

           
            int sumArray(int[] nums) {
                int r = 0;
                for (int i = 0; i < nums.Length; i++) {
                    r = incrementBy(r, numbers[i]);
                }
                return r;
            }

            int incrementBy(int item, int increment) {
                return item + increment;
            }
            void printResult(int r) {
                Console.WriteLine("*******" + r);
            }

            void sumAndPrint(int[] num) {
                printResult(sumArray(num));
            }

            int mult(int x, int y) {
                return x * y;
            }

        }

        





    }
}
