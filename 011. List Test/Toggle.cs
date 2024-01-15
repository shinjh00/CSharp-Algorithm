namespace _011._List_Test
{
    class Toggle
    {
        // Ctrl로 파일 다중 선택 하는 것과 같은 원리 (토글: 두 가지 상태만 가지는 스위치)
        // 선택X -> 선택O, 선택O -> 선택X 로 바뀜

        static void Main0(string[] args)
        {
            // 1. 숫자 입력 받기
            Console.Write("> 숫자를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out int num);

            List<int> list = new List<int>();


            // 2. 0부터 num까지 삽입
            for (int i = 0; i <= num; i++)
            {
                list.Add(i);
            }


            // 3. 0 요소 삭제
            list.Remove(0);


            // 4. list 출력
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");


            // 5. Toggle
            Console.WriteLine("(입력을 끝내려면 00 입력)\n");

            while (true)
            {
                Console.Write("> 추가하거나 삭제할 숫자를 입력하세요 : ");
                string input = Console.ReadLine();

                if (input != "00")
                {
                    int.TryParse(input, out int num2);

                    if (list.Contains(num2) == true)
                    {
                        // 삭제
                        list.Remove(num2);
                    }
                    else
                    {
                        // 삽입
                        list.Add(num2);
                    }

                    // list 출력
                    foreach (int i in list)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    break;
                }

            }

        }
    }
}
