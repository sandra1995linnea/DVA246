﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void DequeueShallCrashOnEmptyQueue()
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

            Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
        }

        [TestMethod]
        public void DequeueShallReturnHandle()
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            queue.Enqueue(5, 1);
            IPriorityQueueHandle<int, int> handle = queue.Dequeue();

            Assert.AreEqual(5, handle.Element);
            Assert.AreEqual(1, handle.Priority);
        }

        [TestMethod]
        public void DequeueShallDecreaseCout()
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            queue.Enqueue(5, 1);
            queue.Dequeue();

            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void EnqueShallAdd_DequeueShallRemove_SamePriorities()
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            queue.Enqueue(5, 1);
            queue.Enqueue(6, 1);
            Assert.AreEqual(2, queue.Count);

            IPriorityQueueHandle<int, int> handle = queue.Dequeue();
            Assert.AreEqual(5, handle.Element);
            Assert.AreEqual(1, handle.Priority);
            Assert.AreEqual(1, queue.Count);

            handle = queue.Dequeue();
            Assert.AreEqual(6, handle.Element);
            Assert.AreEqual(1, handle.Priority);
            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void EnqueShallAdd_DequeueShallRemove_DifferentPriorities()
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
            queue.Enqueue(5, 1);
            queue.Enqueue(6, 2);
            queue.Enqueue(7, 3);
            queue.Enqueue(2, 3);
            queue.Enqueue(7, 1);
            queue.Enqueue(10, 3);

            IPriorityQueueHandle<int, int> handle = queue.Dequeue();
            Assert.AreEqual(7, handle.Element);
            Assert.AreEqual(3, handle.Priority);
            Assert.AreEqual(5, queue.Count);
        }
    }
}