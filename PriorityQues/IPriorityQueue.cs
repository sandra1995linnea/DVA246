
namespace PriorityQues
{
    public interface IPriorityQueue<TElement, TPriority>
    {
        // returns the number of elements in the queue
        int Count { get; }

        // inserts element with the given priority
        // returns a priority queue element that can be used to 
        IPriorityQueueHandle<TElement, TPriority> Enqueue(TElement element, TPriority priority);

        // removes and returns the smallest element in the queue
        // throws an InvalidOperationException if the queue is empty
        IPriorityQueueHandle<TElement, TPriority> Dequeue();

        // removes the smallest element in the queue passing out the element and the priority using the out parameters
        // returns true if the queue is not empty and false otherwise
        // in case the queue is empty element and priority are given default values
        bool TryDequeue(out TElement element, out TPriority priority);

        // returns the smallest element in the queue without removing it passing out the element and the priority using the out parameters
        // returns true if the queue is not empty and false otherwise
        // in case the queue us empty element and priority are given default values
        bool TryPeek(out TElement element, out TPriority priority);
    }
}
