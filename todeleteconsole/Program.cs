using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDeleteSomeFeatures;

namespace todeleteconsole {
    class Program {
        static void Main(string[] args) {
            //MoveX();
            //PrintPoint();
            Zottirik z = new Zottirik();
            z.PrintMessage();
            Console.ReadLine();
        }
        private static void PrintPoint() {
            Console.Clear();
            Console.SetCursorPosition(0, 1);
            Console.Write("X");
            Console.SetCursorPosition(0, 0);
            Console.Write("Y");
            Console.SetCursorPosition(3, 0);
            Console.WriteLine("Z");
            Console.ReadLine();
        }
            private static void MoveX() {
            int count = 0;
            while (true) {
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'e') break;
                count++;
                Console.Clear();
                for (int i = 0; i < count; i++) {
                    Console.Write(' ');
                }
                Console.WriteLine('x');
            }
        }
    }
}
