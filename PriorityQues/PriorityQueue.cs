using System;
using System.Collections.Generic;

namespace PriorityQues
{
    public class PriorityQueue<TElement, TPriority> : IPriorityQueue<TElement, TPriority>
    {
        public PriorityQueue()
        {

        }

        public PriorityQueue(IComparer<TPriority> comparer)
        {

        }

        public int Count  { get; private set; }

        public IPriorityQueueHandle<TElement, TPriority> Dequeue()
        {
            throw new NotImplementedException();
        }

        public IPriorityQueueHandle<TElement, TPriority> Enqueue(TElement element, TPriority priority)
        {
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
