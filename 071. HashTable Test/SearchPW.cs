using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _071._HashTable_Test
{
    internal class SearchPW
    {
        static void Main0(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            Console.WriteLine($"{n}, {m}");

            Dictionary<string, string> dic = new Dictionary<string, string>();

            Console.WriteLine("== 사이트 목록 ==");
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(" ");
                dic.Add(input[0], input[1]);
            }

            Console.WriteLine("== 찾을 사이트 ==");
            string siteAddr;
            for (int i = 0; i < m; i++)
            {
                siteAddr = Console.ReadLine();
                dic.TryGetValue(siteAddr, out string password);
                Console.WriteLine(password);
            }
        }
    }
}
