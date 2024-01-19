using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081._DesignTechnique_Test
{
    internal class DivideAndConquer
    {
        /* https://www.acmicpc.net/problem/2630 */

        static void Main(string[] args)
        {
            int whitePaper;  // 0
            int bluePaper;  // 1

            Console.Write("size 입력 : ");
            int size = int.Parse(Console.ReadLine());

            int[,] paper = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine(); // 1 2 3 4
                string[] str = row.Split(" "); // str = {1, 2, 3, 4} str[0] str[1] str[2] str[3]

                for (int j = 0; j < size; j++)
                {
                    paper[i, j] = int.Parse(str[j]);
                }
            }

            Console.WriteLine("=====");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{paper[i, j]} ");
                }
                Console.WriteLine();
            }




        }
    }
}
