using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _080._DesignTechnique
{
    internal class DivideAndConquer
    {
        /* 분할 정복 */
        // 거듭 제곱 xⁿ

        static int Pow(int x, int n)
        {
            if (n == 1)
            {
                return x;
            }

            if (n % 2 == 0)
            {
                return Pow(x * x, n / 2);  // 2⁴ => 4²
            }
            else
            {
                return Pow(x * x, n / 2) * x;  // 2³ => 4¹ * 2
            }
        }
    }
}