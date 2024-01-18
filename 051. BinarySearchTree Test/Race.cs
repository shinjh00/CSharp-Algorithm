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

            //string[] callings = { "kai", "kai", "mine", "mine" };
            string[] callings = { "kai", "kai" };

            SortedDictionary<string, int> sortedByPlayer = new SortedDictionary<string, int>();
            SortedDictionary<int, string> sortedByRank = new SortedDictionary<int, string>();

            for (int i = 0; i < players.Length; i++)
            {
                sortedByPlayer.Add(players[i], i + 1);
                sortedByRank.Add(i + 1, players[i]);
            }

            /*foreach (KeyValuePair<string, int> kvp in sortedByPlayer)
            {
                Console.WriteLine($"{{{kvp.Key}, {kvp.Value}}}");
            }
            foreach (KeyValuePair<int, string> kvp in sortedByRank)
            {
                Console.WriteLine($"{{{kvp.Key}, {kvp.Value}}}");
            }*/

            for (int i = 0; i < callings.Length; i++)
            {
                int callingsRank = sortedByPlayer[callings[i]];  // 불린 사람의 랭크 =4

                string frontPlayer = sortedByRank[callingsRank - 1];  // 불린 사람의 앞 사람=poe

                sortedByPlayer.Remove(callings[i]); //kai
                sortedByPlayer.Add(callings[i], callingsRank-1); //kai,3

                sortedByRank.Remove(callingsRank - 1); //3
                sortedByRank.Add(callingsRank - 1, callings[i]); //3,kai

                sortedByPlayer.Remove(frontPlayer); //poe
                sortedByPlayer.Add(frontPlayer, callingsRank); //poe,4
                
                sortedByRank.Remove(callingsRank); //4
                sortedByRank.Add(callingsRank, frontPlayer); //4,poe

                foreach (KeyValuePair<string, int> kvp in sortedByPlayer)
                {
                    Console.WriteLine($"{{{kvp.Key}, {kvp.Value}}}");
                }
                foreach (KeyValuePair<int, string> kvp in sortedByRank)
                {
                    Console.WriteLine($"{{{kvp.Key}, {kvp.Value}}}");
                }
                Console.WriteLine();
            }

            

            









        }
    }
}

