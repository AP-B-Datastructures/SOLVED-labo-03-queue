using System;
using Queue.library;

namespace Queue.tests
{
    [TestClass]
    public class QueueInt_oefening3_tests
    {
        private QueueInt queue;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            queue = new QueueInt();
        }

        [TestMethod]
        public void Enqueue_QueueIncreasesSize()
        {
            // Arrange
            for (int i = 0; i < 1000; i++)
            {
                queue.Enqueue(i);
            }

            // Assert
            Assert.AreEqual(queue.Length, 1000);
        }

    }
}
