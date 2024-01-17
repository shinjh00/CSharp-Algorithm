using System;

namespace _000._Algorithm
{
    class Program
    {
        /* Big-O 표기법 */

        // 연산 횟수
        int Case1(int n)
        {
            int sum = 0;
            sum = n * n;  // 1번 연산
            return sum;
        }
        int Case2(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)  // n번 연산
                sum += n;
            return sum;
        }
        int Case3(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)  // n번 연산
                for (int j = 0; j < n; j++)  // n번 연산    => n²번 연산
                    sum++;
            return sum;
        }

        // 입력값       Case1	    Case2   	   Case3
        // n = 1            1           1              1
        // n = 10           1          10            100
        // n = 100          1         100         10,000
        // n = 1000         1        1000      1,000,000
        // Big-O		 O(1)	     O(n)   	   O(n²)


        /* 수행 시간 분석 */

        int FindIndex(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }
        // 최선   [ 평균 ]    최악
        // O(1)   [ O(n) ]    O(n)

    }
}