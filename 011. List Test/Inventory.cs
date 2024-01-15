using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011._List_Test
{
    internal class Inventory
    {
        class Items
        {
            private List<string> items;

            public Items()
            {
                items = new List<string>();
            }

            /* 아이템 조회 */
            public void Inquiry()
            {
                Console.WriteLine("아이템 조회 실행");

                int count = items.Count;
                Console.WriteLine(count);




            }

            /* 아이템 얻기 */
            public void Gain()
            {
                Console.WriteLine("아이템 얻기 실행");
            }

            /* 아이템 버리기 */
            public void Lose()
            {
                Console.WriteLine("아이템 버리기 실행");
            }
        }


        static void Main(string[] args)
        {
            List<string> shop = new List<string>();
            shop.Add("Item01");
            shop.Add("Item02");
            shop.Add("Item03");
            shop.Add("Item04");

            Items items = new Items();

            bool b = true;
            while (b)
            {
                Console.WriteLine("1. 아이템 조회 / 2. 아이템 얻기 / 3. 아이템 버리기 / 0. 종료");
                Console.Write("메뉴를 선택하세요 : ");
                int.TryParse(Console.ReadLine(), out int input);

                switch (input)
                {
                    case 1:
                        Console.WriteLine("= 아이템 조회 =");
                        items.Inquiry();
                        break;
                    case 2:
                        Console.WriteLine("= 아이템 얻기 =");
                        items.Gain();
                        break;
                    case 3:
                        Console.WriteLine("= 아이템 버리기 =");
                        items.Lose();
                        break;
                    case 0:
                        Console.WriteLine("= 종료합니다 =");
                        b = false;
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
