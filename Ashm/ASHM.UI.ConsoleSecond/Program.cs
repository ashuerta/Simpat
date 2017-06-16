using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASHM.Common.Entities;
using ASHM.Service.App;

namespace ASHM.UI.ConsoleSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            var op = 0;
            //var f = 1000000000;
            //var big = new BigList();
            //for (int i = 1; i < f; i+=1000)
            //{
            //    big.AddLast(i);
            //    System.Console.WriteLine(i);
            //}
            do
            {
                Menu.ShowMenuAdvance();
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Menu.ShowInvalidOption(true);
                }
                var srv = new FizzBuzzService();
                switch (op)
                {
                    case 1:
                        var adv = new Advance();
                        var min = 0;
                        var max = 0;
                        Console.Clear();
                        Console.Write("Set initial number: ");
                        if (int.TryParse(Console.ReadLine(), out min))
                        {
                            adv.MinEdge = min;
                        }
                        Console.Write("Set last number: ");
                        if (int.TryParse(Console.ReadLine(), out max))
                        {
                            adv.MaxEdge = max;
                        }
                        var r = srv.AdvanceByRange(adv);
                        Menu.ShowResults(r);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Menu.ShowInvalidOption(false);
                        break;
                }
            } while (op != 6);
        }
    }
}
