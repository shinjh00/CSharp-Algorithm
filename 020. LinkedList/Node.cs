using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020._LinkedList
{
    internal class Node
    {
        /* 연결 리스트 */
        public class LinkedListNode<T>
        {
            public T value;

            public LinkedListNode<T> prev;
            public LinkedListNode<T> next;
        }

        /* 이진 트리 */
        public class BinaryTreeNode<T>
        {
            public T value;

            public BinaryTreeNode<T> parent;
            public BinaryTreeNode<T> left;
            public BinaryTreeNode<T> right;
        }

        /* 8진 트리 */
        public class OctTreeNode<T>
        {
            public T value;

            public OctTreeNode<T> parent;
            public OctTreeNode<T>[] children = new OctTreeNode<T>[8];
        }

        /* 인접 리스트 */
        public class AdjacentNode<T>
        {
            public T value;

            public List<AdjacentNode<T>> connect = new List<AdjacentNode<T>>();
        }
    }
}
