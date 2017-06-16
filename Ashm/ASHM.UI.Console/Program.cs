using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ASHM.Common.Entities;
using ASHM.Service.App;

namespace ASHM.UI.ConsoleFirst
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
                Menu.ShowMenu();
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Menu.ShowInvalidOption(false);
                }
                switch (op)
                {
                    case 1:
                        var srv = new FizzBuzzService();
                        var r = srv.BasicFizzBuzz(new Normal());
                        Menu.ShowResults(r);
                        break;
                    default:
                        Menu.ShowInvalidOption(false);
                        break;
                }
            } while (op != 2);
        }
    }
}
