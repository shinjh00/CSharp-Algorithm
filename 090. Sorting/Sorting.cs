using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _090._Sorting
{
    internal class Sorting
    {

        /* 선택 정렬 */

        public static void SelectionSort(IList<int> list, int start, int end)  // array, List 모두 IList. 특징은 index 사용
        {
            for (int i = start; i <= end; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j <= end; j++)
                {
                    if (list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(list, i, minIndex);  // List에서 i(맨앞값)와 minIndex(최소값) 자리 바꾸기
            }
        }


        /* 삽입 정렬 */

        public static void InsertionSort(IList<int> list, int start, int end)
        {
            for (int i = start + 1; i <= end; i++)
            {
                for (int j = i; j >= 1; j--)  // 뒤에서부터 비교하면서 기준 숫자가 더 작으면 비교대상 뒤로 밀면서 앞으로 이동
                {
                    if (list[j - 1] < list[j])
                    {
                        break;
                    }
                    Swap(list, j - 1, j);
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
            if (start == end)
            {
                return;
            }

            int mid = (start + end) / 2;
            MergeSort(list, start, mid);
            MergeSort(list, mid + 1, end);
            Merge(list, start, mid, end);
        }

        private static void Merge(IList<int> list, int start, int mid, int end)
        {
            List<int> sortedList = new List<int>();
            int leftIndex = start;
            int rightIndex = mid + 1;

            // 분할 정렬된 List를 병합
            while (leftIndex <= mid && rightIndex <= end)
            {
                if (list[leftIndex] < list[rightIndex])
                {
                    sortedList.Add(list[leftIndex++]);
                }
                else
                {
                    sortedList.Add(list[rightIndex++]);
                }
            }

            if (leftIndex > mid)
            {
                for (int i = rightIndex; i <= end; i++)
                {
                    sortedList.Add(list[i]);
                }
            }
            else
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


        /* 퀵 정렬 */

        public static void QuickSort(IList<int> list, int start, int end)
        {
            if (start >= end) return;

            int pivot = start;
            int left = pivot + 1;
            int right = end;

            while (left <= right)
            {
                while (list[left] <= list[pivot] && left < right)
                {
                    left++;
                }
                while (list[right] > list[pivot] && left <= right)
                {
                    right--;
                }

                if (left < right)
                {
                    Swap(list, left, right);
                }
                else
                {
                    Swap(list, pivot, right);
                    break;
                }
            }

            QuickSort(list, start, right - 1);
            QuickSort(list, right + 1, end);
        }


        /* 힙 정렬 */

        public static void HeapSort(IList<int> list)
        {
            for (int i = list.Count / 2 - 1; i >= 0; i--)
            {
                Heapify(list, i, list.Count);
            }

            for (int i = list.Count - 1; i > 0; i--)
            {
                Swap(list, 0, i);
                Heapify(list, 0, i);
            }
        }

        private static void Heapify(IList<int> list, int index, int size)
        {
            int left = index * 2 + 1;
            int right = index * 2 + 2;
            int max = index;
            if (left < size && list[left] > list[max])
            {
                max = left;
            }
            if (right < size && list[right] > list[max])
            {
                max = right;
            }

            if (max != index)
            {
                Swap(list, index, max);
                Heapify(list, max, size);
            }
        }


        // Swap 함수
        private static void Swap(IList<int> list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }
    }
}