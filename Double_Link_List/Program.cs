using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Link_List {
    class Program {
        static void Main(string[] args) {

            DLList dLList = new DLList();
            dLList.AddToStart(3);
            dLList.AddToStart(6);
            dLList.AddToStart(22);
            dLList.AddToStart(0);
            dLList.AddToStart(12);
            dLList.AddToTail(9);
            dLList.AddToTail(10);
            dLList.AddToTail(89);
            //Console.WriteLine("Deleted: " + dLList.RemoveFromStart());
            //Console.WriteLine("Deleted: " + dLList.RemoveFromTail());

            dLList.PrintList();
            Console.WriteLine("IEnumerator");
            foreach(DLListNode node in dLList) {
                Console.WriteLine(node.data);
            }
            
            //dLList.PrintListBackwards();
            Console.ReadLine();
        }
    }
}
