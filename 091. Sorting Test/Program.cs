namespace _091._Sorting_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int count = 10;
            List<int> selectionList = new List<int>(count);
            List<int> insertionList = new List<int>(count);
            List<int> bubbleList = new List<int>(count);
            List<int> mergeList = new List<int>(count);

            Console.Write("랜덤 데이터 : \t\t");
            for (int i = 0; i < count; i++)
            {
                int rand = random.Next(0, 100);
                Console.Write($"{rand,3}");

                selectionList.Add(rand);
                insertionList.Add(rand);
                bubbleList.Add(rand);
                mergeList.Add(rand);
            }
            Console.WriteLine();


            Console.Write("선택 정렬 결과 : \t");
            Sorting.SelectionSort(selectionList, 0, selectionList.Count - 1);
            foreach (int i in selectionList)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();


            Console.Write("삽입 정렬 결과 : \t");
            Sorting.InsertionSort(insertionList, 0, insertionList.Count - 1);
            foreach (int i in insertionList)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();


            Console.Write("버블 정렬 결과 : \t");
            Sorting.BubbleSort(bubbleList, 0, bubbleList.Count - 1);
            foreach (int i in bubbleList)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();


            Console.Write("합병 정렬 결과 : \t");
            Sorting.MergeSort(mergeList, 0, mergeList.Count - 1);
            foreach (int i in mergeList)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();


            Console.Write("퀵 정렬 결과 : \t");
            Console.WriteLine();


            Console.Write("힙 정렬 결과 : \t");
            Console.WriteLine();
        }
    }
}
