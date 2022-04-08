using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQues
{
    class PriorityQueueHandle<TElement, TPriority> : IPriorityQueueHandle<TElement, TPriority>
    {
        public TElement Element => throw new NotImplementedException();

        public TPriority Priority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
