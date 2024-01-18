namespace _071._HashTable_Test
{
    internal class CheatKey
    {
        /* 치트키 문자열을 통해서 바로 함수를 탐색하여 발동시키는 치트키 머신 구현 */

        private Dictionary<string, Action> cheatDic;

        public CheatKey()
        {
            cheatDic = new Dictionary<string, Action>();
            cheatDic.Add("showmethemoney", ShowMeTheMoney);
            cheatDic.Add("thereisnocowlevel", ThereIsNoCowLevel);
            cheatDic.Add("harrypottersuperjump", HarryPotterSuperJump);
        }

        public void Run(string cheatKey)
        {
            // 조건문 없이 바로 탐색하여 치트키 발동
            cheatDic.TryGetValue(cheatKey, out Action action);
            action?.Invoke();

            /*
            if (cheatDic.ContainsKey(cheatKey))
            {
                cheatDic[cheatKey]();
            }
            */
        }

        public void ShowMeTheMoney()
        {
            Console.WriteLine("골드를 늘려주는 치트키 발동!");
        }

        public void ThereIsNoCowLevel()
        {
            Console.WriteLine("바로 승리합니다 치트키 발동!");
        }

        public void HarryPotterSuperJump()
        {
            Console.WriteLine("해리포터가 슈퍼점프를 한다!");
        }

        static void Main(string[] args)
        {
            CheatKey cheatKey = new CheatKey();
            cheatKey.Run("showmethemoney");
            cheatKey.Run("showmethe");
            cheatKey.Run("thereisnocowlevel");
            cheatKey.Run("harrypottersuperjump");
        }
    }
}
