namespace _060._Heap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 오름차순 : 기본 int 우선순위
            PriorityQueue<string, int> pq1 = new PriorityQueue<string, int>();

            pq1.Enqueue("Data1", 1);
            pq1.Enqueue("Data7", 7);
            pq1.Enqueue("Data5", 5);
            pq1.Enqueue("Data3", 3);
            pq1.Enqueue("Data9", 9);

            // pq1 : { 1, 3, 5, 7, 9 }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(pq1.Dequeue());   // output : Data1, Data3, Data5
            }

            pq1.Enqueue("Data4", 4);
            pq1.Enqueue("Data2", 2);
            pq1.Enqueue("Data6", 6);
            pq1.Enqueue("Data8", 8);

            while (pq1.Count > 0)
            {
                Console.WriteLine(pq1.Dequeue());   // output : Data2, Data4, Data6, Data7, Data8, Data9
            }


            // 내림차순 : int 우선순위에 * -1을 적용하여 사용
            PriorityQueue<string, int> pq2 = new PriorityQueue<string, int>();

            pq2.Enqueue("Data1", -1);
            pq2.Enqueue("Data7", -7);
            pq2.Enqueue("Data5", -5);
            pq2.Enqueue("Data3", -3);
            pq2.Enqueue("Data9", -9);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(pq2.Dequeue());   // output : Data9, Data7, Data5
            }

            pq2.Enqueue("Data4", -4);
            pq2.Enqueue("Data2", -2);
            pq2.Enqueue("Data6", -6);
            pq2.Enqueue("Data8", -8);

            while (pq2.Count > 0)
            {
                Console.WriteLine(pq2.Dequeue());   // output : Data8, Data6, Data4, Data3, Data2, Data1
            }
        }
    }
}