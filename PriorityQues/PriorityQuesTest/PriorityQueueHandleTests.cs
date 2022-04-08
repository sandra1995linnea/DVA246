using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriorityQues;

namespace PriorityQuesTest
{
    [TestClass]
    public class PriorityQueueHandleTests
    {
        [TestMethod]
        public void GetElement()
        {
            PriorityQueueHandle<int, int> handle = new PriorityQueueHandle<int, int>(1, 1);
            Assert.AreEqual(1, handle.Element);
        }

        [TestMethod]
        public void GetPriority()
        {
            PriorityQueueHandle<int, int> handle = new PriorityQueueHandle<int, int>(1, 2);
            Assert.AreEqual(2, handle.Priority);
        }

        [TestMethod]
        public void SetPriority()
        {
            PriorityQueueHandle<int, int> handle = new PriorityQueueHandle<int, int>(1, 3);
            handle.Priority = 2;
            Assert.AreEqual(2, handle.Priority);
        }

        // TODO:
        // Test that:
        // Changing the priority should cause the associated priority queue to reprioritize


    }
}
