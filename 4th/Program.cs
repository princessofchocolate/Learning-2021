using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4th {
    class Program {
        static void Main(string[] args) {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 10, 20, 30 };
            int[] numbers3 = { 100, 200, 300, 400, 500 };
            int[] numbers4 = { 100, 20, 3, 400, -5, -2, -9 };
            ops(numbers1);
            ops(numbers2);
            ops(numbers3);
            ops(numbers4);
            Console.ReadLine();

            //write methods to:
            //1. sum array
            //2. average
            //3. multiply array
            //print these above in that order for each array. And then proceed to the next array
            //DIVIDE AND CONQUER

            //int sum().....
            
            int sumArray(int[] nums) {
                int result = 0;
                for (int i = 0;i < nums.Length; i++) {
                    result = nums[i] + result;
                }
                return result;
            }

            float avarage(int[] nums) {
                float result = 0;
                result = (float)sumArray(nums) / (float)nums.Length;
                return result;
            }

            int mult(int[] nums) {
                int result = 1;
                for (int i = 0; i < nums.Length; i++) {
                    result = nums[i] * result;
                }
                return result;
            }
            void ops(int[] nums) {
                Console.WriteLine(sumArray(nums));
                Console.WriteLine(avarage(nums));
                Console.WriteLine(mult(nums));
                Console.WriteLine();

            }
             

            
        }
    }
}
