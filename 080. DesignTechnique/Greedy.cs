using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080._DesignTechnique
{
    internal class Greedy
    {
        /* 탐욕 알고리즘 */
        // 자판기 거스름돈

        void CoinMachine(int money)
        {
            int[] coinType = { 500, 100, 50, 10, 5, 1 };

            foreach (int coin in coinType)
            {
                while (money <= coin)
                {
                    Console.WriteLine($"{coin} 코인 배출");
                    money -= coin;
                }
            }
        }
    }
}