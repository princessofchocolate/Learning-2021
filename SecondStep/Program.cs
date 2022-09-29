using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStep {
    class Program {
        static void Main(string[] args) {
            int num1 = 5, num2 = 7;
            Console.WriteLine("Before:  " + num1 + ", " + num2);

            int temp = num1;
            num1 = num2;
            num2 = temp;
           
            Console.WriteLine("After:  " + num1 + ", " + num2);

            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            int sum = 0;
            int[] numbers = { 1, 3, -5, 12, 80, 5647, 23444, -3452, 1, 545, -66543, 1,0};
            
            Console.WriteLine(numbers.Length + " items");
            for(int i = 0; i < numbers.Length; i++) {
                if ( numbers[i]< minNum) {
                    minNum = numbers[i];
                }
                if (numbers[i] > maxNum) {
                    maxNum = numbers[i];
                }
                sum += numbers[i];
            }

            double avg = (double)sum / (double)numbers.Length;
            
            Console.WriteLine("Min: " + minNum);
            Console.WriteLine("Max: " + maxNum);
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("avg: " + avg);


            Console.ReadLine();
        }
    
    }
}
