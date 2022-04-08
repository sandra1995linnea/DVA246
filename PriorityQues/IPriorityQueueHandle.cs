
namespace PriorityQues
{
    public interface IPriorityQueueHandle<TElement, TPriority>
    {
        // get the element
        TElement Element { get; }

        // gets or sets the priority
        // changing the priority should cause the associated priority queue to reprioritize
        TPriority Priority { get; set; }
    }
}
