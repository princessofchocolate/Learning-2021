using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListOfInt {
    public class LList<T>  {
        class Node<T> {
            internal T data;
            internal Node<T> next = null;

            internal Node(T data) {
                this.data = data;
                this.next = null;
            }
        }

        Node<T> head = null;
        public void Add(T n) {
            Node<T> node = new Node<T>(n);
            if (head == null) {
                head = node;
            } else {
                Node<T> lastNode = GetLastNode();
                lastNode.next = node;
            }
        }

        private Node<T> GetLastNode() {
            if(head== null) {
                return null;
            }
            if(head.next== null) {
                return head;
            }
            Node<T> current = head;
            while(current.next != null) {
                current = current.next;
            }
            return current;
        }

        public void PrintList() {
            if (head == null) {
                Console.WriteLine("List is empty.");
            }
            Node<T> current = head;
            
            while (current != null) {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void RemoveNode(T n) {
            if(head == null) {
                return;
            }
            if (head.data.Equals(n)) {
                head = head.next;
                return;
            }
            Node<T> previousNode = null;
            Node<T> currentNode = head;

            while(currentNode!=null && !currentNode.data.Equals(n)) {
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
            if (currentNode == null) {
                Console.WriteLine("data not found");
                return;
            }
            previousNode.next = currentNode.next;
            currentNode.next = null;
        }
    }
}
