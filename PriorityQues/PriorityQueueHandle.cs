using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQues
{
    public class PriorityQueueHandle<TElement, TPriority> : IPriorityQueueHandle<TElement, TPriority>
    {
        public PriorityQueueHandle(TElement element, TPriority priority)
        {
            Element = element;
            Priority = priority;
        }

        public TElement Element { get; }

        public TPriority Priority { get; set; }
    }
}
