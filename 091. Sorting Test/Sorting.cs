using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091._Sorting_Test
{
    internal class Sorting
    {

        /* 선택 정렬 */

        public static void SelectionSort(IList<int> list, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j <= end; j++)
                {
                    if (list[minIndex] > list[j])
                    {
                        minIndex = j;
                    }
                }
                Swap(list, i, minIndex);
            }
        }


        /* 삽입 정렬 */

        public static void InsertionSort(IList<int> list, int start, int end)
        {
            for (int i = start + 1; i <= end; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (list[i] < list[j])
                    {
                        Swap(list, i, j);
                        i--;
                    }
                }
            }
        }


        /* 버블 정렬 */

        public static void BubbleSort(IList<int> list, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                for (int j = 0; j < end - start; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        Swap(list, j, j + 1);
                    }
                }
            }

        }


        /* 병합 정렬 */

        public static void MergeSort(IList<int> list, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSort(list, start, mid);
                MergeSort(list, mid + 1, end);
                Merge(list, start, mid, end);
            }
        }

        private static void Merge(IList<int> list, int start, int mid, int end)
        {
            List<int> sortedList = new List<int>();
            int leftIndex = start;
            int rightIndex = mid + 1;

            while (leftIndex <= mid && rightIndex <= end)
            {
                if (list[leftIndex] < list[rightIndex])
                {
                    sortedList.Add(list[leftIndex]);
                    leftIndex++;
                }
                else  // ( list[leftIndex] >= list[rightIndex] )
                {
                    sortedList.Add(list[rightIndex]);
                    rightIndex++;
                }
            }

            if (leftIndex > mid)
            {
                for (int i = rightIndex; i <= end; i++)
                {
                    sortedList.Add(list[i]);
                }
            }
            else  // ( rightIndex > end )
            {
                for (int i = leftIndex; i <= mid; i++)
                {
                    sortedList.Add(list[i]);
                }
            }

            for (int i = 0; i < sortedList.Count; i++)
            {
                list[start + i] = sortedList[i];
            }
        }

        /*
        void MergeSort(list, start, end)    // 7 3 6 1 3 2 4 8
        {
            MergeSort(list, start, mid);        // 7 3 6 1
            {
                MergeSort(list, start, mid);        // 7 3
                {
                    MergeSort(list, start, mid);        // 7
                    MergeSort(list, mid + 1, end);      // 3
                    Merge();                            //-> 3 7
                }
                MergeSort(list, mid + 1, end);      // 6 1
                {
                    MergeSort(list, start, mid);        // 6
                    MergeSort(list, mid + 1, end);      // 1
                    Merge();                            //-> 1 6
                }
                Merge();                            //-> 1 3 6 7
            }
            MergeSort(list, mid + 1, end);      // 3 2 4 8
            {
                MergeSort(list, start, mid);        // 3 2
                {
                    MergeSort(list, start, mid);        // 3
                    MergeSort(list, mid + 1, end);      // 2
                    Merge();                            //-> 2 3
                }
                MergeSort(list, mid + 1, end);      // 4 8
                {
                    MergeSort(list, start, mid);        // 4
                    MergeSort(list, mid + 1, end);      // 8
                    Merge();                            //-> 4 8
                }
                Merge();                            //-> 2 3 4 8
            }
            Merge();                            //-> 1 2 3 3 4 6 7 8
        }*/


        // Swap 함수
        private static void Swap(IList<int> list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }
    }
}
