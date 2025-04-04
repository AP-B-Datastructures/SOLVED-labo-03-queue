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
            throw new NotImplementedException();
        }

        [DataTestMethod]
        public void Enqueue_EnqueueAllValuesKeepsInputOrder()
        {
            throw new NotImplementedException();
        }
    }
}
