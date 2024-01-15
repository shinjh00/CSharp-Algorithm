using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1._Stack_Queue_Test
{
    internal class FileName
    {

        public const int WorkTime = 8;

        public static int[] ProcessJob(int[] jobList)
        {
            Queue<int> queue = new Queue<int>();
            int remainTime = 8;
            int day = 1;
            List<int> days = new List<int>();

            for (int i = 0; i < jobList.Length; i++)
            {
                queue.Enqueue(jobList[i]);
            }

            while (queue.Count > 0)  // 작업이 남아있으면 계속 작업
            {
                int workTime = queue.Dequeue(); // 다음 작업 몇시간 짜리인지

                while (true)
                {
                    if (workTime <= remainTime)  // 잔여작업시간이 오늘남은시간보다 작거나 같은 경우
                    {
                        remainTime -= workTime;
                        // 작업 완료
                        days.Add(day);  // 작업 끝날때마다 days에 1일차 3일차 ... 들어감 (List에 작업끝낸날 들어감)
                        break;
                    }
                    else  // 잔여작업시간이 남은시간보다 큰 경우 (다음날까지 작업해야 됨)
                    {
                        workTime -= remainTime;  // 작업시간만큼 남은시간 깎아주고
                        day++;  // 하루 더해주고 (다음날로)
                        remainTime = 8;  // 남은시간 8로
                    }
                }
            }
            return days.ToArray();
        }


        static void Main0()
        {
            int[] result = ProcessJob(new int[] { 4, 2, 3, 5, 20, 3 });

            foreach (int day in result)
            {
                Console.WriteLine(day);
            }

            // 4, 4, 12, 10, 2, 10
            // 결과 : 1 1 3 4 4 6

            // 4, 2, 3, 5, 20, 3
            // 결과 : 1 1 2 2 5 5

        }

    }
}
