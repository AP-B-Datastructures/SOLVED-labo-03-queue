using System;
using Queue.library;

namespace Queue.tests
{
    [TestClass]
    public class QueueInt_oefening2_tests
    {
        private QueueInt queue;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the stack before each test
            queue = new QueueInt();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Dequeue_ThrowsExceptionWhenQueueIsEmpty()
        {
            // Act
            queue.Dequeue();
        }

        [TestMethod]
        public void IsEmpty_FilledQueueIsNotEmpty()
        {
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var result = queue.IsEmpty;

            Assert.AreEqual(false,result);
        }

        [TestMethod]
        public void IsFull_PartiallyFilledQueueIsNotFull()
        {
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var result = queue.IsFull;

            Assert.AreEqual(false,result);
        }

    }
}
