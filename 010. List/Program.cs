using System;
using System.Collections.Generic;

namespace _010._List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            /* 리스트 삽입*/

            list.Add("0번째 데이터");
            list.Add("1번째 데이터");
            list.Add("2번째 데이터");
            list.Add("3번째 데이터");
            list.Add("4번째 데이터");                // 평균 시간 복잡도 O(1) => 좀 더 빠름
            list.Insert(1, "중간 데이터 1에 추가");
            list.Insert(3, "중간 데이터 3에 추가");  // 평균 시간 복잡도 O(n)

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            /* 리스트 삭제 */

            bool success = list.Remove("중간 데이터 1에 추가");  // Remove()는 bool형
            bool fail = list.Remove("중간 데이터 1에 추가");  // 없으면 무시하고 false 반환
            list.RemoveAt(2);
            list.RemoveAt(list.Count - 1);  // 맨 마지막 데이터 삭제하기

            Console.WriteLine($"> success: {success}, fail: {fail}");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            /* 리스트 접근 */

            list[0] = "수정된 0번째 데이터";

            string value = list[2];  // 2번째 데이터

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"> value: {value}\n");


            /* 리스트 탐색 */

            int indexOf = list.IndexOf("3번째 데이터");  // 있으면 index 반환, 없으면 -1 반환
            int indexOf2 = list.IndexOf("4번째 데이터");
            int findIndex = list.FindIndex(x => x.Contains("수정"));

            Console.WriteLine($"> indexOf: {indexOf}, indexOf2: {indexOf2}, findIndex: {findIndex}\n");


            /* 요소의 수 */

            int count = list.Count();
            Console.WriteLine($"> count: {count}\n");


            /* 비우기 */

            list.Clear();

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
    }
}