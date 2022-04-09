using System;
using System.Collections.Generic;

namespace PriorityQues
{
    public class PriorityQueue<TElement, TPriority> : IPriorityQueue<TElement, TPriority>
    {
        private readonly List<TPriority> priorities = new List<TPriority>();
        private readonly List<List<TElement>> elements = new List<List<TElement>>();
        private readonly IComparer<TPriority> comparer;

        public PriorityQueue()
        {
            comparer = System.Collections.Generic.Comparer<TPriority>.Default;
        }

        public PriorityQueue(IComparer<TPriority> comparer)
        {
            this.comparer = comparer;
        }

        public int Count { get; private set; }

        public IPriorityQueueHandle<TElement, TPriority> Dequeue()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            TPriority prio = priorities[0];
            TElement element = elements[0][0];

            IPriorityQueueHandle<TElement, TPriority> handle = new PriorityQueueHandle<TElement, TPriority>(element, prio);

            elements[0].RemoveAt(0);
            if(elements[0].Count == 0)
            {
                elements.RemoveAt(0);
                priorities.RemoveAt(0);
            }

            Count--;
            return handle;
        }

        public IPriorityQueueHandle<TElement, TPriority> Enqueue(TElement element, TPriority priority)
        {
            int index;
            bool priorityExists = priorities.Contains(priority);

            if(priorityExists)
            {
                index = priorities.IndexOf(priority);

                // if the priority already existed, add the element to the correct queue
                elements[index].Add(element);
            }
            else
            {
                for (index = 0; index < priorities.Count; index++)
                {
                    if (0 < comparer.Compare(priority, priorities[index]))
                    {
                        break;
                    }
                }

                // if the priority did not yet exist, create a new queue for this priority
                var newQueue = new List<TElement>() { element };
                elements.Insert(index, newQueue);

                priorities.Insert(index, priority);
            }

            Count++;
            return new PriorityQueueHandle<TElement, TPriority>(element, priority);
        }

        public bool TryDequeue(out TElement element, out TPriority priority)
        {
            throw new NotImplementedException();
        }

        public bool TryPeek(out TElement element, out TPriority priority)
        {
            throw new NotImplementedException();
        }
    }
}
