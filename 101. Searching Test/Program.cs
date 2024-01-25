namespace _101._Searching_Test
{
    internal class Program
    {

        /* 1. 양방향 연결 그래프 */

        bool[,] matrixGraph1 = new bool[8, 8]
        {
            //  0      1      2      3      4      5      6      7
            { false, false,  true, false,  true, false, false, false }, // 0
            { false, false,  true, false, false,  true, false, false }, // 1
            {  true,  true, false, false, false,  true,  true, false }, // 2
            { false, false, false, false, false, false, false,  true }, // 3
            {  true, false, false, false, false, false, false,  true }, // 4
            { false,  true,  true, false, false, false, false, false }, // 5
            { false, false,  true, false, false, false, false, false }, // 6
            { false, false, false,  true,  true, false, false, false }  // 7
        };


        /* 2. 단방향 연결 그래프 */

        bool[,] matrixGraph2 = new bool[8, 8]
        {
            //  0      1      2      3      4      5      6      7
            { false, false, false, false, false, false, false, false }, // 0
            { false, false, false, false, false, false, false, false }, // 1
            { false, false, false, false,  true,  true, false, false }, // 2
            { false,  true, false, false, false,  true, false,  true }, // 3
            { false, false, false, false, false, false, false, false }, // 4
            { false,  true, false, false, false, false, false, false }, // 5
            { false, false,  true, false, false,  true, false, false }, // 6
            { false, false, false, false, false, false,  true, false }  // 7
        };


        /* 3. 양방향 가중치 그래프 */

        const int INF = int.MaxValue;
        int[,] matrixGraph3 = new int[8, 8]
        {
            // 0    1    2    3    4    5    6    7
            {  0 ,  4 , INF, INF,  6 , INF, INF, INF }, // 0
            {  4 ,  0 ,  5 ,  4 , INF,  8 ,  2 , INF }, // 1
            { INF,  5 ,  0 , INF,  9 , INF, INF, INF }, // 2
            { INF,  4 , INF,  0 , INF, INF, INF, INF }, // 3
            {  6 , INF,  9 , INF,  0 , INF,  5 , INF }, // 4
            { INF,  8 , INF, INF, INF,  0 , INF,  1  }, // 5
            { INF,  2 , INF, INF,  5 , INF,  0 , INF }, // 6
            { INF, INF, INF, INF, INF,  1 , INF,  0  }  // 7
        };

    }
}
