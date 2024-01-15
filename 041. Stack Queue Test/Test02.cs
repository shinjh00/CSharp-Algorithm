using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _041._Stack_Queue_Test
{
    internal class Test02
    {

        public static bool IsOk(string text)  // 괄호 짝 맞는지 확인하는 함수
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in text)  // 입력받은 문자 차례대로 돌리기
            {
                if (c == '{' || c == '[' || c == '(')  // 1. 여는 괄호일 때
                {
                    stack.Push(c);  // 스택에 넣기
                }
                else if (c == '}' && stack.Count > 0)  // 2-1. 닫는 괄호일 때
                {
                    if (stack.Peek() == '{')  // 가장 최신의 괄호가 c의 짝이 맞다면
                    {
                        stack.Pop();  // 스택에서 c의 짝 삭제
                    }
                }
                else if (c == ']' && stack.Count > 0)  // 2-2. 닫는 괄호일 때
                {
                    if (stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                }
                else if (c == ')' && stack.Count > 0)  // 2-3. 닫는 괄호일 때
                {
                    if (stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                }
                else if (stack.Count == 0)  // 스택이 빈 상태에서 닫는 괄호가 들어왔을 때를 대비
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("잘못입력");
                    break;
                }

                // == 확인용 ==
                Console.Write($"> c: {c}\t\t");  // 검사한 문자
                Console.Write("> stack: ");  // 스택 요소 확인
                foreach (char c2 in stack)
                {
                    Console.Write(c2);
                }
                Console.Write("\t");
                Console.WriteLine($"count: {stack.Count}");  // 스택 요소 개수 확인
            }

            if (stack.Count == 0)  // 스택에 아무것도 없으면 true
            {
                return true;
            }
            else  // 남아있으면 false
            {
                return false;
            }
        }


        static void Main0()
        {
            do
            {
                Console.WriteLine("*** 괄호를 자유롭게 입력하세요. ***");
                string text = Console.ReadLine();

                bool isOk = IsOk(text);

                if (isOk == true)
                {
                    Console.WriteLine(">> 괄호의 짝이 맞습니다.\n");
                }
                else
                {
                    Console.WriteLine(">> 괄호의 짝이 맞지 않습니다.\n");
                }
            } while (true);
        }

    }
}
