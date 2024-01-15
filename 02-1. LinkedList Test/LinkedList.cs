namespace _02._LinkedList_Test
{
    internal class LinkedList
    {
        static void Main0(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            bool b = true;
            while (b)
            {
                // 입력
                Console.Write("추가할 숫자를 입력해주세요 : ");
                int.TryParse(Console.ReadLine(), out int input);

                if (linkedList.Find(input) != null)  // 숫자가 존재함
                {
                    Console.WriteLine("숫자가 이미 존재합니다.");
                }
                else  // 숫자가 존재하지 않음
                {
                    if (input < 0)  // 음수일 때
                    {
                        LinkedListNode<int> nodeFirst = linkedList.AddFirst(input);
                    }
                    else if (input > 0)  // 양수일 때
                    {
                        LinkedListNode<int> nodeLast = linkedList.AddLast(input);
                    }
                    else if (input == 0)  // 종료
                    {
                        Console.WriteLine("종료합니다.");
                        b = false;
                        break;
                    }
                    else  // 잘못된 입력
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }


                    // 출력
                    Console.WriteLine("연결 리스트 : ");
                    foreach (int value in linkedList)
                    {
                        Console.Write($"{value} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
