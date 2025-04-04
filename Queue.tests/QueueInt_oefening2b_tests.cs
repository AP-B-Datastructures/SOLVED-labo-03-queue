using System;
using Queue.library;

namespace Queue.tests
{
    [TestClass]
    public class QueueInt_oefening2b_tests
    {
        private QueueInt queue;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the queue before each test
            queue = new QueueInt();
        }

        [TestMethod]
        public void IsEmpty_EmptyQueueIsEmpty()
        {
            // Arrange

            // Act
            bool result = queue.IsEmpty;

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsFull_FullQueueIsFull()
        {
            // Arrange
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            // Act
            bool result = queue.IsFull;

            // Assert
            Assert.AreEqual(true, result);
        }
    }
}
