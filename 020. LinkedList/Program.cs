namespace _020._LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            // 삽입
            LinkedListNode<string> node0 = linkedList.AddFirst("0번 데이터");
            LinkedListNode<string> node1 = linkedList.AddFirst("1번 데이터");
            LinkedListNode<string> node2 = linkedList.AddLast("2번 데이터");
            LinkedListNode<string> node3 = linkedList.AddLast("3번 데이터");
            LinkedListNode<string> node4 = linkedList.AddBefore(node0, "4번 데이터");
            LinkedListNode<string> node5 = linkedList.AddAfter(node0, "5번 데이터");

            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // 삭제
            bool success = linkedList.Remove("1번 데이터");  // O(n) : 웬만하면 지양
            bool fail = linkedList.Remove("1번 데이터");  // O(n)
            linkedList.Remove(node3);  // O(1)
            linkedList.RemoveFirst();  // O(1)
            linkedList.RemoveLast();  // O(1)

            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // 접근
            LinkedListNode<string> firstNode = linkedList.First;
            LinkedListNode<string> lastNode = linkedList.Last;
            LinkedListNode<string> prevNode = node0.Previous;
            LinkedListNode<string> nextNode = node0.Next;


            // 탐색
            LinkedListNode<string> findNode = linkedList.Find("5번 데이터");
        }
    }
}
