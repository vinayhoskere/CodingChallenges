using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Microsoft.SqlServer.Server;

namespace CodingChallenges
{
    internal class Stack
    {
        private class Item
        {
            public  string name;
            public string value;
            public Item prev;
        }

        private Item stackPointer;

        public Stack()
        {
            stackPointer = null;
        }

        private void Push(string name, string value)
        {
            Item newItem = new Item {name = name, value = value};
            
            if (stackPointer == null)
            {
                stackPointer = newItem;
                stackPointer.prev = null;
            }
            else
            {
                newItem.prev = stackPointer;
                stackPointer = newItem;
            }
        }

        private void ReadItem(Item item)
        {
            Console.WriteLine(string.Format("Name: {0} Value {1}", item.name, item.value));
        }

        private void Pop()
        {
            if (stackPointer == null)
            {
                return;
            }
            Item next = stackPointer;
            stackPointer = stackPointer.prev;

            next.prev = null;
            //delete next;
        }
    }
}
