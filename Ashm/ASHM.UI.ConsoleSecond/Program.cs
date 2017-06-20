using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASHM.Common.Entities;
using ASHM.Common.Entities.Linked;
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
            var srv = new FizzBuzzService();
            do
            {
                Menu.ShowMenuAdvance();
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Menu.ShowInvalidOption(true);
                }
                var adv = new Advance();
                var r = new BigList();
                var min = 0;
                var max = 0;
                switch (op)
                {
                    case 1:
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
                        r = srv.AdvanceByRange(adv);
                        Menu.ShowResults(r);
                        break;
                    case 2:
                        bool x;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Please type the numbers that you want to check separated by a comma e. 1,2,3:");
                            Console.WriteLine();
                            var toSplit = Console.ReadLine();
                            try
                            {
                                var d = new Dictionary<int, string>();
                                if (toSplit == null)
                                {
                                    throw new ApplicationException();
                                }
                                var nm = toSplit.Split(',');
                                foreach (var v in nm)
                                {
                                    var n = int.Parse(v);
                                    d.Add(n, n.ToString());
                                }
                                adv.Items = d;
                                r = srv.AdvanceByInputUser(adv);
                                Menu.ShowResults(r);
                                x = false;
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Your input has an error please check and try again.");
                                Console.ReadKey();
                                x = true;
                            }
                        } while (x);

                        break;
                    case 3:
                        bool o;
                        do
                        {
                            Console.Clear();
                            var c = "n";
                            var t = new Dictionary<int, string>();
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Please add your custom token:");
                                Console.WriteLine();
                                Console.Write("Your number: ");
                                try
                                {
                                    int rl = 0;
                                    if (!int.TryParse(Console.ReadLine(), out rl))
                                    {
                                        throw new ApplicationException();
                                    }
                                    Console.WriteLine();
                                    Console.Write("Your word: ");
                                    var w = Console.ReadLine();
                                    
                                    t.Add(rl, w);
                                    var f = false;
                                    do
                                    {
                                        Console.WriteLine("Do you want add other? ( y | n ): ");
                                        c = Console.ReadLine();
                                        if (c == null)
                                            f = true;
                                        else if (c.Length > 1)
                                            f = true;
                                        else if (c.ToLower() != "y" && c.ToLower() != "n")
                                            f = true;

                                        if (f)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Last option selected was invalid.");
                                        }

                                    } while (f);
                                }
                                catch (Exception)
                                {
                                    c = "y";
                                    Console.Clear();
                                    Console.WriteLine("Your input has an error please check and try again.");
                                    Console.ReadKey();
                                }
                            } while (c.ToLower() == "y");
                            if (t.Count > 0)
                            {
                                adv.Tokens = t;
                                Console.Clear();
                                Console.WriteLine("Calculating");
                                r = srv.AdvanceByCustomTokens(adv);
                                Menu.ShowResults(r);
                                o = false;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Please try again.");
                                Console.ReadKey();
                                o = true;
                            }
                        } while (o);
                        break;
                    case 4:
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
                        r = srv.AdvanceByPerfectSquare(adv);
                        Menu.ShowResults(r);
                        break;
                    case 5:
                        Console.Clear();
                        var toSearch = 0;
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
                        Console.Write("Set pattern to search by digit: ");
                        if (int.TryParse(Console.ReadLine(), out toSearch))
                        {
                            adv.DigitPattern = toSearch;
                        }
                        r = srv.AdvanceByInsideDigits(adv);
                        Menu.ShowResults(r);
                        break;
                    default:
                        Menu.ShowInvalidOption(false);
                        break;
                }
            } while (op != 6);
        }
    }
}
