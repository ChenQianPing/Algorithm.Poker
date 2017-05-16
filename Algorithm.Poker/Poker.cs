using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Poker
{
    public class Poker
    {
        public static void Init(List<string> list)
        {
            list.Add("大王");
            list.Add("小王");
            var color = new string[4] { "红桃", "黑桃", "方块", "梅花" };
            var cate = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", };
            for (var i = 0; i < color.Length; i++)
            {
                for (var j = 0; j < cate.Length; j++)
                {
                    list.Add(color[i] + cate[j]);
                }
            }
        }

        public static void Print(List<string> list)
        {
            var card = list.ToArray();
            for (var i = 0; i < card.Length; i++)
            {
                Console.WriteLine(card[i]);
            }
            Console.ReadKey();
        }

        public static void XiPai(List<string> list)
        {
            var i = list.Count;
            int j;
            if (i == 0)
            {
                return;
            }
            while (--i != 0)
            {
                var ran = new Random();
                j = ran.Next() % (i + 1);
                var tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }
        }

        public static void DiPai(List<string> list)
        {
            Console.WriteLine("以下是底牌");
            Console.WriteLine("*************************");
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(list[list.Count - 1]);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}


/*
 * 洗牌算法，果然仅仅执行了54次.
 * 可用于集合元素打乱顺序，随机抽奖，游戏算法等.
 */
