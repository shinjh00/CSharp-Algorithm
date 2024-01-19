namespace _080._DesignTechnique
{
    internal class Program
    {
        public static int Factorial(int x)  // 재귀함수 선언
        {
            if (x == 1)
            {
                Console.Write("1 = ");
                return 1;
            }
            else
            {
                Console.Write($"{x} * ");
                return x * Factorial(x - 1);  // 내부에서 재귀함수 사용
            }
        }

        static void Main(string[] args)
        {
            Console.Write("수를 입력 : ");
            int.TryParse(Console.ReadLine(), out int n);

            Console.Write($"{n}! = ");
            int result = Factorial(n);
            Console.WriteLine(result);
        }
    }
}