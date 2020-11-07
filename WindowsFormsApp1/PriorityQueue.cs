using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priority_Queue
{
    // class Priority Queue
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
            arr = new string[max_size];
        }

        public bool isFull()
        {
            if (counter == max_size) return true;
            return false;
        }

        public bool isEmpty()
        {
            if (counter == 0) return true;
            return false;
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
        
        // method to copy entire priority queue to a array
        public string[] copyQueue()
        {
            // if queue is empty
            if (counter == 0)
            {
                Console.WriteLine("Underflow");
                return null;
            }
            int temp = 0;
            foreach (Queue<string> q in Dict.Values)
            {
                // copying individual queue to the array with starting index temp
                if (q.Count>0) q.CopyTo(arr, temp);
                // incrementing starting index for next queue
                temp = temp + q.Count;
            }
            // returning the array
            return arr;
        }
    }
}
