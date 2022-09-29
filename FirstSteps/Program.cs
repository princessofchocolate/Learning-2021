using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps {
    class Program {
        static void Main(string[] args) {
            int num1, num2, result;
            Console.WriteLine("select operation ( + , - , *, S, P): ");
            string opType = Console.ReadLine();
            Console.WriteLine("enter first number");
            string num1AsString = Console.ReadLine();
            bool firstConverted = Int32.TryParse(num1AsString, out num1);
            if (!firstConverted) {
                Console.WriteLine("Malformed entry");
                return;
            }


            Console.WriteLine("enter second number");
            string num2AsString = Console.ReadLine();

            bool secondConverted = Int32.TryParse(num2AsString, out num2);
            if (!secondConverted) {
                Console.WriteLine("Malformed entry");
                return;
            }
            if (opType == "+") {
                result = num1 + num2;
            } else if (opType == "-") {
                result = num1 - num2;
            } else if (opType == "*") {
                result = num1 * num2;
            } else if (opType == "S") {
                result = 0;
                int start = num1;
                while (start <= num2) {
                    result += start;
                    start++;
                }
            } else if (opType == "P") {
                result = 1;
                
                for(int start= num1;start <= num2; start++) {
                    result *= start;
                    if(result == 0) {
                        //Console.WriteLine("0 reached, will break");
                        break;
                    }
                }
            } else {
                Console.WriteLine("unknown operation");
                return;
            }

            Console.WriteLine("result is: " + result);

            Console.ReadLine();
        }

    }
}
