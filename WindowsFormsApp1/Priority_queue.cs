using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Priority_queue
    {
        List<Aircraft> list;
        private int max_size;   // maximum size of priority queue
        private int counter;    // to count no of elements in queue
        SortedDictionary<int, List<Aircraft>> Dict = new SortedDictionary<int, List<Aircraft>>();
        Aircraft[] arr;
        int priority;
        // constructor to initialize size and counter
        public Priority_queue(int size)
        {
            max_size = size;
            counter = 0;
            list = new List<Aircraft>();
            arr = new Aircraft[max_size];
            priority = 0;
        }

        // method to check if the priority queue is full
        public bool isFull()
        {
            if (counter == max_size) return true;
            return false;
        }

        // method to check if the priority queue is empty
        public bool isEmpty()
        {
            if (counter == 0) return true;
            return false;
        }

        // method to return size
        public int getCount()
        {
            return counter;
        }
        // method to add item into priority queue
        public void enQueue(Aircraft flight)
        {
            priority = flight.E_level;  // priority is according to the aircraft emergency level;
            // if priority queue is full
            if (counter == max_size)
            {
                Console.WriteLine("OverFlow!");
                return;
            }
            // else adding the element with its priority
            if (!Dict.ContainsKey(priority)) Dict.Add(priority, new List<Aircraft>());
            Dict[priority].Add(flight);
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
            foreach (List<Aircraft> q in Dict.Values)
            {
                // we use a sorted dictionary
                int l = q.Count;
                Aircraft temp;
                if (l > 0)
                {
                    counter--;
                    temp = q.ElementAt(l - 1);
                    q.RemoveAt(l - 1);
                    return temp;
                }
            }
            return null;
        }

        // method to move the element at the front of it's priority values
        public void changePriority(Aircraft flt)
        {
            List<Aircraft> temp = Dict[flt.E_level];
          //  KeyValuePair<int, List<Aircraft>> temp = Dict.ElementAt(flt.E_level-1);
            temp.Remove(flt);
            temp.Insert(0, flt);
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
            foreach (List<Aircraft> q in Dict.Values)
            {
                // copying individual queue to the array with starting index temp
                if (q.Count > 0) q.CopyTo(arr, temp);
                // incrementing starting index for next queue
                temp = temp + q.Count;
            }
            // returning the array
            return arr;
        }
    }
}
