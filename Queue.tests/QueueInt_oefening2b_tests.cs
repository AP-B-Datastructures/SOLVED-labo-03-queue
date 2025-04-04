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
            throw new NotImplementedException();
        }

        [TestMethod]
        public void IsFull_FullQueueIsFull()
        {
            throw new NotImplementedException();
        }
    }
}
