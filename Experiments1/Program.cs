using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments1 {
    class Program {
        static void Main(string[] args) {
            
            Student[] students = new Student[4];
            students[0] = new Student("Alice", 15, 1.60f); 
            students[3] = new Student("Bob", 13, 1.50f);
            students[1] = new Student("Claire", 18, 1.80f);
            students[2] = new Student("David", 9, 1.20f);


            for(int i = 0; i < students.Length; i++) {
                Console.WriteLine(students[i]);
            }

            int[] numbers = { 20, 12, 30, -5 };
            foreach (int i in numbers) Console.Write(i+", ");
            Console.WriteLine();
            Array.Sort(numbers);
            foreach (int i in numbers) Console.Write(i+", ");
            Console.WriteLine("********");
            Array.Sort(students);
            for (int i = 0; i < students.Length; i++) {
                Console.WriteLine(students[i]);
            }
            Console.ReadLine();
        }
    }
}
