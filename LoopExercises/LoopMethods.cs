using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExercises {
    public class LoopMethods {
        public int SumNNumbers(int n) {

            int result = 0;
            for (int i = 1; i < n + 1; i++) {
                result += i;
                Console.Write(i + ", ");
            }
            return result;
        }

        public int SumAndAvarage() {

            int result = 0;
            for (int i = 0; i < 10; i++) {
                result += Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
            Console.WriteLine(result / 10f);
            return 0;
        }

        public void TriangleWithAsterisk() {
            string temp = "";

            for (int i = 0; i < 4; i++) {
                temp += "*";
                Console.WriteLine(temp);
            }
        }

        public void TriangleWithNumbers() {
            for (int i = 1; i < 5; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write(j + 1);
                }
                Console.WriteLine();
            }
        }

        public void TriangleWithNumberOfRows(int n) {
            for (int i = 1; i < n + 1; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void TriangleWithAscendingNumbers(int n) {
            int j = 1;
            for (int i = 1; i < n + 1; i++) {
                for (int k = 1; k <= i; j++, k++) {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        /*
         |  *  |
         | * * |
         |* * *|

        |   *   |
        |  * *  |
        | * * * |
        |* * * *|

        __*_
        _*_*_
        *_*_*_

        
         */
        public void PyramidWithAsteriks(int n) {
            int countPerLine = 2 * n - 1;
            for (int i = 1; i <= n; i++) {
                int countOfLine = 2 * i - 1;
                int padding = (countPerLine - countOfLine) / 2;
                for (int j = 1; j < padding; j++) {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++) {
                    if (i == n && j == 1) {
                        Console.Write("*");
                    } else {
                        Console.Write(" *");
                    }
                }


                for (int j = 1; j <= padding; j++) {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            /*
            for (int i = 5;i> 0; i--) {
                for (int j = 0; j<4;j++) {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
            */
        }

        public void PyramidWithNumbers(int n) {
            int currentChar = 1;
            int countPerLine = 2 * n - 1;
            for (int i = 1; i <= n; i++) {
                int countOfLine = 2 * i - 1;
                int padding = (countPerLine - countOfLine) / 2;
                for (int j = 1; j < padding; j++) {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++, currentChar++) {
                    if (i == n && j == 1) {
                        Console.Write(currentChar);
                    } else {
                        Console.Write(" " + currentChar);
                    }
                }


                for (int j = 1; j <= padding; j++) {
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
            /*
            for (int i = 5;i> 0; i--) {
                for (int j = 0; j<4;j++) {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
            */
        }

        public void PyramidWithAsteriksOfOddNumber(int n) {
            //last line width. it's also the width for all lines.
            int countPerLine = 2 * n - 1;
            for (int i = 1; i <= n; i++) {
                int countOfAsterix = 2 * i - 1;
                int padding = (countPerLine - countOfAsterix) / 2;
                for (int j = 1; j <= padding; j++) {
                    Console.Write(" ");
                }
                for (int j = 1; j <= countOfAsterix; j++) {
                    Console.Write("*");
                }
                for (int j = 1; j <= padding; j++) {
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        private double NDigit9(int n) {
            double result = 0;
            for (int i = 0; i <= n; i++) {

                result += 9 * Math.Pow(10, i);
            }
            return result;
        }

        public double SumOfSeries(int n) {
            double result = 0;
            for (int i = 0; i < n; i++) {
                result += NDigit9(i);
            }

            return result;
        }

        public double DiffrentSumOfSeries(int n) {
            double result = 0;
            for (int i = 0; i < n; i++) {
                result += (n - i) * 9 * Math.Pow(10, i);
            }
            return result;
        }

        public void FloydsTriangle(int n) {
            int temp = 1;
            bool numVal = true;
            bool lineStart = true;
            for (int i = 0; i < n; i++, temp++) {
                numVal = lineStart;
                for (int j = 0; j < temp; j++) {
                    if (numVal) {
                        Console.Write(1);
                        numVal = !numVal;
                    } else {
                        Console.Write(0);
                        numVal = !numVal;
                    }
                }
                Console.WriteLine();
                lineStart = !lineStart;

            }
        }

        public void SquareOfNumsAndTheirSums(int n) {
            int result = 0;
            for (int i = 1; i <= n; i++) {
                int temp = i * i;
                Console.Write(temp + " ");
                result += temp;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(result);
        }

        public double SumOfSeriesWith1(int n) {
            double result = 0;
            for (int i = 1; i <= n; i++) {
                for (int j = 0; j < i; j++) {
                    result += Math.Pow(10, j);
                }
            }
            return result;
        }

        public bool PerfectNumber(int n) {
            int result = 0;
            for (int i = 1; i < n; i++) {
                if (n % i == 0) {
                    result += i;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(result);
            if (result == n) {
                return true;
            } else {
                return false;
            }
        }

        public bool ArmstrongNumber(int n) {
            int devision = n;
            int remainder = 0;
            double result = 0;

            while (devision > 10) {
                remainder = devision % 10;
                devision = devision / 10;
                result += Math.Pow(remainder, 3);
            }
            result += Math.Pow(devision, 3);
            return result == n;
        }

        public void DiamondWithAsteriks() {

            for (int i = 1; i <= 5; i++) {
                LineWithAsteriks(i);
            }
            for (int i = 4; i >= 1; i--) {
                LineWithAsteriks(i);

            }
        }

        private void LineWithAsteriks(int i) {
            int padding = 5 - i;
            int numOfAsteriks = 2 * i - 1;
            for (int j = 0; j < padding; j++) {
                Console.Write(" ");
            }
            for (int j = 0; j < numOfAsteriks; j++) {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        public bool PrimeNumber(int x) {
            for(int i = 2; i <= x / 2; i++) {
                if (x%i==0) {
                    return false;
                }
            }
            return true;
        }

        public void PascalsTriangle(int n) {
            //TODO: write this func next
        }

        public void PrimeNumberInARange(int n) {
            bool[] nums = new bool[n + 1];

            for(int i = 2; i<nums.Length;i++) {
                nums[i] = true;
            }
            for(int i = 2; i <= n; i++) {
                if (!nums[i]) {
                    continue;
                }
                
                for(int j = i; j + i< nums.Length &&j< nums.Length; j += i) {
                    nums[j + i] = false;
                }
                
                if (nums[i]) {
                    Console.WriteLine(i);
                }
            }
        }

        public void FibonacciNumbers(int n) {
            int[] nums = new int[n];
            nums[0] = 0;
            nums[1] = 1;
            for (int i = 2; i<nums.Length;i++) {
                nums[i] = nums[i - 1] + nums[i - 2];
            }
            for (int i = 0;i< nums.Length;i++) {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
