using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApp1;

namespace Priority_Queue
{
    // class Priority Queue
    class PriorityQueue
    {
        private int max_size;   // maximum size of priority queue
        private int counter;    // to count no of elements in queue
        SortedDictionary<int, Queue<Aircraft>> Dict = new SortedDictionary<int, Queue<Aircraft>>();
        Aircraft[] arr;
        int priority;
        // constructor to initialize size and counter
        public PriorityQueue(int size)   
        {
            max_size = size;
            counter = 0;
            arr = new Aircraft[max_size];
            priority = 0;
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

        public int getCount()
        {
            return counter;
        }
        // method to add item into priority queue
        public void enQueue(Aircraft flight)
        {
            priority = flight.E_level;
            // if priority queue is full
            if (counter == max_size)
            {
                Console.WriteLine("OverFlow!");
                return;
            }
            // else adding the element with its priority
            if (!Dict.ContainsKey(priority)) Dict.Add(priority, new Queue<Aircraft>());
            Dict[priority].Enqueue(flight);
            counter++;
        }

        // method to pop element with highest priority
        public Aircraft deQueue()
        {
            // if queue is Empty
            if (counter == 0)
            {
                Console.WriteLine("Underflow");
                return null;
            }
            // else returning the item with highest priority
            foreach (Queue<Aircraft> q in Dict.Values)
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
        public Aircraft[] copyQueue()
        {
            // if queue is empty
            if (counter == 0)
            {
                Console.WriteLine("Underflow");
                return null;
            }
            int temp = 0;
            foreach (Queue<Aircraft> q in Dict.Values)
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
