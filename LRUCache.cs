using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    /// <summary>
    /// Least Recently used Cache
    /// </summary>
    class LRUCache<TKey, TValue>
    {
        public readonly Dictionary<TKey, Node> entries;
        private readonly int capacity;
        private Node head;
        private Node tail;

        public class Node
        {
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public TKey key;
            public TValue value;
        }

        public LRUCache(int capacity)
        {
            if (capacity <= 0)
            {
                return;
            }
            this.capacity = capacity;
            entries = new Dictionary<TKey, Node>(capacity);
            head = null;
        }

        public Node Add(TKey key, TValue value)
        {
            Node entry;

            entry = new Node {key = key, value = value};

            if (head == null)
            {
                head = entry;
                tail = entry;
                return entry;
            }
            Node currNode = head;
            
            while (currNode.Next != null)
            {
                currNode = currNode.Next;
            }

            currNode.Next = entry;
            entry.Previous = currNode;
            entry.Next = null;

            return entry;
            //if (!entries.TryGetValue(key, out entry))
            //{
            //    entry = new Node {key = key, value = value};
            //    if (entries.Count == capacity)
            //    {
            //        entries.Remove(tail.key);
            //        tail = tail.Previous;
            //        if (tail != null) tail.Next = null;
            //    }
            //    entries.Add(key, entry);
            //}

            //entry.value = value;
            //MoveToHead(entry);
            //if (tail == null) tail = head;
        }

        private void Remove()
        {
            if(tail == null)
                return;

            Node temp = tail.Next;
            entries.Remove(tail.key);

            temp.Previous = null;

            head = temp;
            tail = temp;
        }

        private void UpdateCache(TKey key, TValue value)
        {
            
        }

        private bool TryGetValue(TKey key, out TValue value)
        {
            value = default(TValue);
            Node entry;
            if(!entries.TryGetValue(key, out entry))
                return false;

            MoveToHead(entry);
            value = entry.value;

            return true;
        }

        private void MoveToHead(Node entry)
        {
            if(entry == head || entry == null)
                return;
           
            var next = entry.Next;
            var previous = entry.Previous;

            if (next != null) next.Previous = entry.Previous;
            if (previous != null) previous.Next = entry.Next;

            entry.Previous = null;
            entry.Next = head;

            if (head != null) head.Previous = entry;
            head = entry;

            if (tail == entry) tail = previous;

        }

        public void LRU_Cache(Dictionary<TKey, Node> entries, TKey key, TValue value)
        {
            //If page is not added in the cache and if the size is still less, then add it to dictionary
            if (!entries.ContainsKey(key) && entries.Count < capacity)
            {
                entries[key] = Add(key, value);
            }

            //If cache miss and we cannot add to dictionary then remove the least used and add new one
            else if (!entries.ContainsKey(key) && entries.Count == capacity)
            {
                Remove();
                entries[key] = Add(key, value);
            }

            //If hit
            else if (entries[key] != null)
            {
                UpdateCache(key, value);
            }

            Console.Write("Current Cache contains :");
            foreach (var entry in entries)
            {
                Console.Write(" " + entry.Value.value);
            }
        }

    }

    public class LeastRecentlyUsedCache
    {
        //private static void Main(string[] args)
        //{
        //    int[] pageOrder = {1, 2, 3, 5, 4, 2, 3, 2, 5, 6};
        //    int i = 0;
        //    LRUCache<int, int> lru = new LRUCache<int, int>(4);

        //    while (i < 10)
        //    {
        //        Console.WriteLine("Page requested " + pageOrder[i]);
        //        lru.LRU_Cache(lru.entries, pageOrder[i], pageOrder[i]);
        //        i++;
        //    }
        //}
    }
}
