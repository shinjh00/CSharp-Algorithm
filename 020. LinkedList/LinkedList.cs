using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
namespace DataStructure
{
    
    public class LinkedList<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        private int count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public LinkedListNode<T> AddFirst(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            InsertNodeBefore(head, newNode);
            return newNode;
        }


        public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            InsertNodeBefore(node, newNode);
            return newNode;
        }

        private void InsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            LinkedListNode<T> prevNode = node.prev;

            // 1. newNode의 prev를 node의 prev로
            newNode.prev = prevNode;

            // 2. newNode의 next를 node로
            newNode.next = node;

            // 3. node의 prev의 next를 newNode로
            if (node == head)  // node가 head면 그 앞에 아무것도 없음
            {
                head = newNode;  // 3-1. head를 newNode로
            }
            else
            {
                prevNode.next = newNode;  // 3-2. node의 prev의 next를 newNode로
            }
            prevNode.next = newNode;

            // 4. node의 prev를 newNode로
            node.prev = newNode;

            count++;
        }


        public LinkedListNode<T> AddFirst(T value)
        {
        }

        public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value)
        {

        }

        public void Remove(T value)
        {
            LinkedListNode<T> findNode = Find(value);
            if (findNode != null)
            {
                RemoveNode(findNode);
                return true;
            }
        }

        public void Remove(LinkedListNode<T> node)
        {
            RemoveNode(node);
        }

        public void RemoveFirst()
        {
            RemoveNode(head);
        }

        public void RemoveLast()
        {
            RemoveNode(tail);
        }

        public










        private void InsertNodeAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            newNode.prev = node;
            newNode.next = node.Next;

            if (node == tail)  // node가 head면 그 앞에 아무것도 없음
            {
                tail = newNode;  // 3-1. head를 newNode로
            }
            else
            {
                prevNode.next = newNode;  // 3-2. node의 prev의 next를 newNode로
            }
        }





        private void RemoveNode(LinkedListNode<T> node)
        {

        }




    }













    public class LinkedListNode<T>
    {
        private T value;
        
        public LinkedListNode<T> prev;
        public LinkedListNode<T> next;  // 어디랑 연결되어있는지 참조하는 값

        public LinkedListNode(T value)
        {
            this.value = value;
            this.prev = null;
            this.next = null;
        }

        public LinkedListNode(T value, LinkedListNode<T> prev, LinkedListNode<T> next)
        {
            this.value = value;
            this.prev = prev;
            this.next = next;
        }


    }
}
*/