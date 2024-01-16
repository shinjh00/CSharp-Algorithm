using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051._BinarySearchTree_Test
{
    /* https://school.programmers.co.kr/learn/courses/30/lessons/178871?language=csharp */

    internal class Race
    {
        /*
 
         public class Solution {
            public string[] solution(string[] players, string[] callings) {
                string[] answer = new string[] {};
                return answer;
            }
        }

         */

        static void Main(string[] args)
        {
            string[] players = { "mumu", "soe", "poe", "kai", "mine" };

            string[] callings = { "kai", "kai", "mine", "mine" };

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < players.Length; i++)
            {
                dictionary.Add(players[i], i);
            }
            
            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                Console.WriteLine($"{{{kvp.Key}, {kvp.Value}}}");
            }

            string call = callings[0];
            int rank = dictionary[call];
            Console.WriteLine(call);
            Console.WriteLine(rank);

            rank -= 1;
            Console.WriteLine(rank);








        }
    }
}

