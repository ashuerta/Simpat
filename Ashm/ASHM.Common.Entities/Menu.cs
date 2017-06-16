using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASHM.Common.Entities.Linked;

namespace ASHM.Common.Entities
{
    public class Menu
    {
        public static void ShowMenuAdvance()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================== M E N U ====================");
            Console.WriteLine("Super FizzBuzz");
            Console.WriteLine();
            Console.WriteLine("Please select your favorite option: ");
            Console.WriteLine("     1) Normal for specific range");
            Console.WriteLine("     2) Set of numbers split by ','.");
            Console.WriteLine("     3) Custom tokens");
            Console.WriteLine("     4) Perfect Square");
            Console.WriteLine("     5) Specific digit in number");
            Console.WriteLine("     6) Exit ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("What do yo want to do? ");
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("=================================== M E N U ===================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Super FizzBuzz");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please select your favorite option: ");
            Console.WriteLine("     1) Show basic demo");
            Console.WriteLine("     2) Exit");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("What do yo want to do? ");
        }

        public static void ShowInvalidOption(bool isAdvance)
        {
            ShowMenu();
            if (isAdvance)
            {
                ShowMenuAdvance();
            }
            Console.WriteLine("Last option selected was invalid please use another one!");
        }

        public static void ShowResults(List<string> r)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("================================= R E S U L T S ================================");
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        public static void ShowResults(BigList r)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("================================= R E S U L T S ================================");
            r.PrintAll();
            Console.ReadKey();
        }
    }
}
