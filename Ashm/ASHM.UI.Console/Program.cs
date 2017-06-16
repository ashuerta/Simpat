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

    public class Node
    {
        public Node Next;
        public int Value;
    }

    public class BigList
    {
        private Node _head;

        //public void printAllNodes()
        //{
        //    Node current = _head;
        //    while (current != null)
        //    {
        //        Console.WriteLine(current.data);
        //        current = current.next;
        //    }
        //}

        //public void AddFirst(Object data)
        //{
        //    Node toAdd = new Node();

        //    toAdd.data = data;
        //    toAdd.next = _head;

        //    _head = toAdd;
        //}

        public void AddLast(int value)
        {
            if (_head == null)
            {
                _head = new Node();
                _head.Value = value;
                _head.Next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.Value = value;

                Node current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = toAdd;
            }
        }
    }
}
