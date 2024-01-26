namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool[,] matrixGraph1 = new bool[8, 8]
            {
                { false, false,  true, false,  true, false, false, false },
                { false, false,  true,  true, false, false,  true, false },
                {  true,  true, false, false,  true, false, false, false },
                { false,  true, false, false, false,  true, false, false },
                {  true, false,  true, false, false, false, false, false },
                { false, false, false,  true, false, false, false, false },
                { false,  true, false, false, false, false, false, false },
                { false, false, false, false, false, false, false, false }
            };



            const int INF = int.MaxValue;
            int[,] matrixGraph2 = new int[8, 8]
            {
                {  0 ,  3 , INF,  7 , INF, INF, INF, INF },
                {  3 ,  0 , INF,  1 , INF,  8 ,  4 , INF },
                { INF, INF,  0 , INF,  7 ,  4 , INF, INF },
                {  7 ,  1 , INF,  0 , INF, INF, INF,  4  },
                { INF, INF,  7 , INF,  0 , INF, INF, INF },
                { INF,  8 ,  4 , INF, INF,  0 , INF,  9  },
                { INF,  4 , INF, INF, INF, INF,  0 , INF },
                { INF, INF, INF,  4 , INF,  9 , INF,  0  }
            };














        }
}
