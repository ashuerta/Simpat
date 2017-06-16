using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASHM.Common.Entities.Linked
{
    public class BigList
    {
        private Node _head;

        public void PrintAll()
        {
            var current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Value.Label);
                current = current.Next;
            }
        }

        //public void AddFirst(Object data)
        //{
        //    Node toAdd = new Node();

        //    toAdd.data = data;
        //    toAdd.next = _head;

        //    _head = toAdd;
        //}

        public void AddLast(int index, string value)
        {
            var v = new Item(index, value);
            if (_head == null)
            {
                _head = new Node();
                _head.Value = v;
                _head.Next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.Value = v;

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
