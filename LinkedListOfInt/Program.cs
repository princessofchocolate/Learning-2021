using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListOfInt {
    class Program {
        static void Main(string[] args) {
            LList<int> lList = new LList<int>();
            lList.Add(7);
            lList.Add(1);
            lList.Add(70);
            lList.Add(10);
            lList.Add(5);
            //
            lList.Add(12);
            
            //lList.Add(17);
            lList.RemoveNode(7);
            lList.PrintList();

            LList<string> stringList = new LList<string>();
            stringList.Add("hello");
            stringList.Add("world");
            stringList.PrintList();
            Console.ReadLine();
            
        }
    }
}
