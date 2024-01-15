using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02._LinkedList_Test
{
    internal class Josephus
    {
        static void Main(string[] args)
        {
            /*
         [3] 6 2 7 5 1 4
        3 6 [7] 5 1 4
        3 6 7 5 [4]
        3 [7] 5 4
        [3] 7 5
        [3] 7
        7

        예를 들어 (7,3) 요세푸스 순열은 {3,6,2,7,5,1,4}이며
        4번째 위치한 사람이 마지막으로 제외되게 된다.
         */

            LinkedList<int> list = new LinkedList<int>();

            // 입력
            Console.Write("N : ");
            int.TryParse(Console.ReadLine(), out int n);

            Console.Write("K : ");
            int.TryParse(Console.ReadLine(), out int k);

            Console.WriteLine($"{{N, K}} = {{{n}, {k}}}");

            for (int i = 0; i < n; i++)
            {
                LinkedListNode<int> node = list.AddLast(i + 1);
            }

            // 출력
            Console.Write(">> ");
            foreach (int value in list)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            LinkedListNode<int> firstNode = list.First;
            Console.WriteLine($"firstNode: {firstNode}");








        }
    }
}
