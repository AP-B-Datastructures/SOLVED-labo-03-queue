using System;
using Queue.library;

namespace Queue.tests
{
    [TestClass]
    public class QueueInt_oefening3b_tests
    {
        private QueueInt queue;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            queue = new QueueInt();
        }

        [DataTestMethod]
        public void Enqueue_FirstInFirstOut()
        {
            // Arrange
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            // Act
            int firstOut = queue.Dequeue();

            // Assert
            Assert.AreEqual(1, firstOut);
        }

        [DataTestMethod]
        public void Enqueue_EnqueueAllValuesKeepsInputOrder()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4 };
            for (var i = 0; i < input.Length; ++i)
            {
                queue.Enqueue(input[i]);
            }

            // Act
            int[] output = new int[4];
            for (var i = 0; i < input.Length; ++i)
            {
                output[i] = queue.Dequeue();
            }

            // Assert
            CollectionAssert.AreEqual(input, output);
        }
    }
}
