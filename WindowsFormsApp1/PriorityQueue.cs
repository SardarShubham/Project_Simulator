using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priority_Queue
{
    
    class PriorityQueue
    {
        private int max_size;   // maximum size of priority queue
        private int counter;    // to count no of elements in queue
        SortedDictionary<int, Queue<string>> Dict = new SortedDictionary<int, Queue<string>>();
        string[] arr;
        // constructor to initialize size and counter
        public PriorityQueue()   
        {
            max_size = 5;
            counter = 0;
        }

        // method to add item into priority queue
        public void enQueue(string item, int priority)
        {
            // if priority queue is full
            if (counter == max_size)
            {
                Console.WriteLine("OverFlow!");
                return;
            }
            // else adding the element with its priority
            if (!Dict.ContainsKey(priority)) Dict.Add(priority, new Queue<string>());
            Dict[priority].Enqueue(item);
            counter++;
        }

        // method to pop element with highest priority
        public string deQueue()
        {
            // if queue is Empty
            if (counter == 0)
            {
                Console.WriteLine("Underflow");
                return null;
            }
            // else returning the item with highest priority
            foreach (Queue<string> q in Dict.Values)
            {
                // we use a sorted dictionary
                if (q.Count > 0)
                {
                    counter--;
                    return q.Dequeue();
                }
            }
            return null;
        }
        
        public string[] getQueue()
        {
            int i = 0;
            if (counter == 0)
            {
                Console.WriteLine("Underflow");
                return null;
            }
            // else returning the item with highest priority
            foreach (Queue<string> q in Dict.Values)
            {
                // we use a sorted dictionary
                if (q.Count > 0)
                {
                    counter--;
                    arr[i] = q.Dequeue();
                    i++;
                }
            }
            return arr;
        }
    }
}
