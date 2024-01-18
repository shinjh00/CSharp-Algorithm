namespace _061._Heap_Test
{
    internal class Test01
    {
        static void Main0(string[] args)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            pq.Enqueue(5, 5);
            pq.Enqueue(1, 1);
            pq.Enqueue(7, 7);
            pq.Enqueue(2, 2);
            pq.Enqueue(3, 3);
            // 1, 2, 3, 5, 7

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(pq.Dequeue());  // output : 1, 2, 3
            }
            // 5, 7

            pq.Enqueue(8, 8);
            pq.Enqueue(9, 9);
            pq.Enqueue(4, 4);
            // >> 4, 5, 7, 8, 9

            while (pq.Count > 0)  // output : 4, 5, 7, 8, 9
            {
                Console.WriteLine(pq.Dequeue());
            }

            // >> 1, 2, 3, 4, 5, 7, 8, 9
        }
    }
}
