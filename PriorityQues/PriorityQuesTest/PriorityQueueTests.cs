using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriorityQues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQues.Tests
{
    [TestClass]
    public class PriorityQueueTests
    {
        [TestMethod]
        public void Count_Test_0args()
        {
            PriorityQueue<int, int> priorityqueue = new PriorityQueue<int, int>();
            Assert.AreEqual(0, priorityqueue.Count);
        }

        [TestMethod]
        public void Count_args()
        {
            PriorityQueue<int, int> priorityqueue = new PriorityQueue<int, int>(null);
            Assert.AreEqual(0, priorityqueue.Count);
        }

        [TestMethod]
        public void EnqueueShallReturnHandle()
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            IPriorityQueueHandle<int, int> handle = queue.Enqueue(3, 1);

            Assert.AreEqual(3, handle.Element);
            Assert.AreEqual(1, handle.Priority);
        }

        [TestMethod]
        public void EnqueShallIncreaseCount()
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            IPriorityQueueHandle<int, int> handle = queue.Enqueue(3, 1);
            Assert.AreEqual(1, queue.Count);
            handle = queue.Enqueue(5, 3);
            handle = queue.Enqueue(8, 2);
            Assert.AreEqual(3, queue.Count);
        }

    }
}