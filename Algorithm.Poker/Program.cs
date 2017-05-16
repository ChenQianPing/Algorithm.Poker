using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            Poker.Init(list);
            Poker.XiPai(list);
            Poker.Print(list);
            Poker.DiPai(list);
            list.Clear();
        }
    }
}
