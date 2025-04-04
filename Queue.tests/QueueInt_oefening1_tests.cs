using System;
using Queue.library;

namespace Queue.tests
{
    [TestClass]
    public class QueueInt_oefening1_tests
    {
        private QueueInt queue;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            queue = new QueueInt();
        }

        [TestMethod]
        public void Enqueue_AddsElementToQueue()
        {
            // Arrange
            int element = 10;

            //Act
            queue.Enqueue(element);

            // Assert
            Assert.AreEqual(element, queue.Dequeue());
        }

        [TestMethod]
        public void Dequeue_RemovesElementFromQueue()
        {
            // Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Arrange
            int firstElement = queue.Dequeue();

            // Assert
            Assert.AreEqual(firstElement, 1);
        }
    }
}
