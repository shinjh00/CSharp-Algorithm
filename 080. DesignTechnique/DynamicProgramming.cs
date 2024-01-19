using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080._DesignTechnique
{
    internal class DynamicProgramming
    {
        /* 동적 계획 법 */
        // 피보나치 수열 ( 1, 1, 2, 3, 5, 8, 13, 21 ...)

        int Fibonachi(int x)
        {
            int[] fibonachi = new int[x + 1];
            fibonachi[1] = 1;
            fibonachi[2] = 1;

            for (int i = 3; i <= x; i++)
            {
                fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
            }

            return fibonachi[x];
        }
    }
}