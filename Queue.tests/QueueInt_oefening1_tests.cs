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

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(101)]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(7291)]
        public void Enqueue_AddsElementToQueue(int element)
        {
            // Arrange

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
