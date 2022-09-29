using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Link_List {
    public class DLList:IEnumerable {

        DLListNode head = null;
        public DLListNode Head {
            get {
                return head;
            }
        }
        DLListNode tail = null;
        int count = 0;
        public int Count {
            get {
                return this.count;
            }
        }

        
        public void AddToStart(int data) {
            DLListNode newNode = new DLListNode(data);
            if (count == 0) {
                head = newNode;
                tail = newNode;
                count++;
            }else if(count == 1) {
                head.prev = newNode;
                newNode.next = head;
                head = newNode;
                count++;
            } else {
                head.prev = newNode;
                newNode.next = head;
                head = newNode;
                count++;
            }
        
        }
        public void AddToTail(int data) {
            DLListNode newNode = new DLListNode(data);
            if (count == 0) {
                head = newNode;
                tail = newNode;
                count++;
            } else if (count == 1) {
                tail.next = newNode;
                newNode.prev = head;
                tail = newNode;
                count++;
            } else {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
                count++;
            }

        }

        public int RemoveFromStart() {
            if (count == 0) {
                Console.WriteLine("nothing to remove");
                return int.MinValue;
            }else if(count == 1) {
                int data = head.data;
                head = null;
                tail = null;
                count = 0;
                return data;
            } else {
                int data = head.data;
                head = head.next;
                head.prev = null;
                count--;
                return data;
            }
        }

        public int RemoveFromTail() {

            if (count == 0) {
                Console.WriteLine("nothing to remove");
                return int.MinValue;
            } else if (count == 1) {
                int data = tail.data;
                tail = null;
                head = null;
                count = 0;
                return data;
            } else {
                int data = tail.data;
                tail = tail.prev;
                tail.next = null;
                count--;
                return data;
            }

        }
        public void PrintList() {
            Console.WriteLine("PrintList()");
            if (count==0) {
                Console.WriteLine("List is empty.");
            }
            DLListNode current = head;

            while (current != null) {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void PrintListBackwards() {
            Console.WriteLine("PrintListBackwards()");
            if (count == 0) {
                Console.WriteLine("List is empty.");
            }
            DLListNode current = tail;

            while (current != null) {
                Console.WriteLine(current.data);
                current = current.prev;
            }
        }

        public IEnumerator GetEnumerator() {
            return new DLListEnumerator(this);
        }
    }

    public class DLListNode {
        public int data;
        public DLListNode prev;
        public DLListNode next;

        public DLListNode(int data) {
            this.data = data;
            this.prev = null;
            this.next = null;
        }

        public DLListNode(float number) { }
        public DLListNode(int data, float number) { }
    }
    public class DLListEnumerator : IEnumerator {
        DLListNode head;
        DLListNode current;
        public DLListEnumerator(DLList list) {
            head = list.Head;
            
        }
        public object Current => current;

        public bool MoveNext() {
            if (current == null) {
                if (head == null) {
                    return false;
                } else {
                    current = head;
                    return true;
                }
            }
            if (current.next != null) {
                current = current.next;
                return true;
            } else {
                return false;
            }
        }

        public void Reset() {
            current = head;
        }
    }
}
