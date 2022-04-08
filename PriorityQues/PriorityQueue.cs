using System;
using System.Collections.Generic;

namespace PriorityQues
{
    class PriorityQueue<TElement, TPriority> : IPriorityQueue<TElement, TPriority>
    {
        public PriorityQueue()
        {

        }

        public PriorityQueue(IComparer<TPriority> comparer)
        {

        }

        public int Count => throw new NotImplementedException();

        public IPriorityQueueHandle<TElement, TPriority> Dequeue()
        {
            throw new NotImplementedException();
        }

        public IPriorityQueueHandle<TElement, TPriority> Enqueue(TElement element, TPriority priority)
        {
            throw new NotImplementedException();
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
