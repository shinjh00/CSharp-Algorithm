using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _041._Stack_Queue_Test
{
    internal class Test03
    {

        public const int WorkTime = 8;

        public static int[] ProcessJob(int[] jobList)
        {
            Queue<int> queue = new Queue<int>();  // jobList 담을 queue
            List<int> days = new List<int>();  // 작업 별 완료한 날 (0일차)
            int remainTime = WorkTime;  // 하루 중 남은 시간
            int day = 1;  // 1일차부터 세기

            for (int i = 0; i < jobList.Length; i++)
            {
                queue.Enqueue(jobList[i]);  // queue에 jobList 담기
            }

            while(queue.Count > 0)  // 작업할 것이 남아있는 동안 반복
            {
                int workTime = queue.Dequeue();  // 현재 작업 소요 시간 반환하고 queue에서 삭제
                //Console.WriteLine($"작업: workTime: {workTime}, remainTime: {remainTime}");

                while(true)
                {
                    if (workTime <= remainTime)
                    {
                        remainTime -= workTime;
                        days.Add(day);
                        //Console.WriteLine($"workTime: {workTime}, remainTime: {remainTime}, day: {day}일차");
                        break;
                    }
                    else  // (workTime > remainTime)
                    {
                        workTime -= remainTime;
                        day++;
                        remainTime = 8;
                        //Console.WriteLine($"workTime: {workTime}, remainTime: {remainTime}, day: {day}일차");
                    }
                }
                //Console.WriteLine();
            }

            return days.ToArray();
        }


        static void Main()
        {
            int[] jobList = { 4, 4, 12, 10, 2, 10 };
            //int[] jobList = { 5, 11, 20, 2, 6, 15 };

            int[] takeDays = ProcessJob(jobList);


            // 각 작업 시간 출력
            Console.Write("jobList : { ");
            foreach (int i in jobList)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("}");


            // 작업 별 끝나는 날짜 출력
            Console.Write("days : { ");
            foreach (int i in takeDays)
            {
                Console.Write($"{i}일차 ");
            }
            Console.WriteLine("}");
        }

    }
}
