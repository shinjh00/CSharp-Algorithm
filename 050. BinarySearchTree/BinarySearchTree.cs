using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructure
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        // 삽입
        public bool Add(T item)
        {
            Node<T> newNode = new Node<T>(item, null, null, null);  // 값, 부모, 왼쪽, 오른쪽

            if (root == null)
            {
                root = newNode;
                return true;
            }

            Node<T> current = root;  // 현재 비교하고 있는 노드
            while (current != null)  // 빈자리가 아닐때까지
            {
                if (item.CompareTo(current.item) < 0)  // 지금 값이 비교 대상보다 작은 경우 왼쪽으로
                {
                    if (current.left != null)  // 왼쪽 자식이 있으면
                    {
                        current = current.left;  // 왼쪽으로 가서 계속 내려가기 반복
                    }
                    else  // 왼쪽 자식이 없으면
                    {
                        current.left = newNode;  // 현재 노드의 왼쪽에 값 추가
                        newNode.parent = current;  // 추가한 노드의 부모를 현재 노드로
                        break;
                    }
                }
                else if (item.CompareTo(current.item) > 0)  // 지금 값이 비교 대상보다 큰 경우 오른쪽으로
                {
                    if (current.right != null)  // 오른쪽 자식이 있으면
                    {
                        current = current.right;  // 오른쪽으로 가서 계속 내려가기 반복
                    }
                    else  // 왼쪽 자식이 없으면
                    {
                        current.right = newNode;  // 현재 노드의 오른쪽에 값 추가
                        newNode.parent = current;  // 추가한 노드의 무보를 현재 노드로
                        break;
                    }
                }
                else // if (item.CompareTo(current.item) == 0)  // 똑같은 값인 경우
                {
                    return false;  // 중복 무시
                }
            }
            return true;
        }

        // 삭제
        public bool Remove(T item)
        {
            Node<T> findNode = FindNode(item);
            if (findNode != null)  // 찾은게 null이 아니면
            {
                EraseNode(findNode);  // 지우고
                return true;
            }
            else  // null이면
            {
                return false;  // 못 지움
            }
        }

        // 포함 확인
        public bool Contains(T item)
        {
            Node<T> findNode = FindNode(item);  // 탐색해보고
            return findNode != null ? true : false;  // 찾은게 null이 아니면 있다. null이면 없다.
        }

        // 비우기
        public void Clear()
        {
            root = null;
        }

        // 찾기
        private Node<T> FindNode(T item)
        {
            if (root == null)  // 루트가 null이면 찾을 수 없는 것
                return null;

            Node<T> current = root;
            while (current != null)
            {
                if (item.CompareTo(current.item) < 0)  // 현재 값과 비교해서 작으면
                {
                    current = current.left;  // 왼쪽으로 가고
                }
                else if (item.CompareTo(current.item) > 0)  // 크면
                {
                    current = current.right;  // 오른쪽으로 가고
                }
                else // if (item.CompareTo(current.item) == 0)  // 같으면
                {
                    return current;  // 찾음
                }
            }
            return null;  // 못 찾으면 없다는 것
        }

        // 지우기
        private void EraseNode(Node<T> node)
        {
            if (node.HasNoChild)  // 1. 자식이 0개인 때
            {
                if (node.IsLeftChild)  // 내가 왼쪽 자식이었다면
                    node.parent.left = null;  // 부모의 왼쪽 자식이 없다라고 하고
                else if (node.IsRightChild)  // 내가 오른쪽 자식이었다면
                    node.parent.right = null;  // 부모의 오른쪽 자식이 없다라고 하고
                else  // 내가 루트 노드였다면
                    root = null;  // 루트는 없다로
            }
            else if (node.HasLeftChild || node.HasRightChild)  // 2. 자식이 1개인 경우
            {
                Node<T> parent = node.parent;
                Node<T> child = node.HasLeftChild ? node.left : node.right;  // 자식이 1개니까 왼쪽 아님 오른쪽

                // 부모와 자식을 연결해주고 삭제
                if (node.IsLeftChild)  // 내가 왼쪽 자식이었다면
                {
                    parent.left = child;  // parent의 왼쪽 자식을 child로 설정
                    child.parent = parent;  // child의 부모를 parent로
                }
                else if (node.IsRightChild)  // -
                {
                    parent.right = child;  // -
                    child.parent = parent;  // -
                }
                else // if (node.IsRootNode)  // 내가 루트노드였다면
                {
                    root = child;  // child가 루트가 됨
                    child.parent = null;
                }
            }
            else // if (node.HasBothChild)  // 3. 자식이 2개인 경우
            {
                // 오른쪽 자식 중 가장 작은 값과 교체하고 삭제
                Node<T> nextNode = node.right;  // 오
                while (nextNode.left != null)
                {
                    nextNode = nextNode.left;
                }
                node.item = nextNode.item;  // 찾은 next 노드랑 지금 노드랑 교체해주고
                EraseNode(nextNode);  // 대신 얘를 지워
            }
        }
    }

    public class Node<T>
    {
        public T item;

        public Node<T> parent;
        public Node<T> left;
        public Node<T> right;

        public Node(T item, Node<T> parent, Node<T> left, Node<T> right)
        {
            this.item = item;
            this.parent = parent;
            this.left = left;
            this.right = right;
        }

        public bool IsRootNode      { get { return parent == null; } }
        public bool IsLeftChild     { get { return parent != null && parent.left == this; } }
        public bool IsRightChild    { get { return parent != null && parent.right == this; } }

        public bool HasNoChild      { get { return left == null && right == null; } }
        public bool HasLeftChild    { get { return left != null && right == null; } }
        public bool HasRightChild   { get { return left == null && right != null; } }
        public bool HasBothChild    { get { return left != null && right != null; } }
    }
}