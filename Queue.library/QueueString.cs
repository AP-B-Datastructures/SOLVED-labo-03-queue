using System;

namespace Queue.library
{
    public class QueueString
    {
        private string[] _data = new string[10];
        private int front = -1;
        private int back = -1;

        public bool IsEmpty => throw new NotImplementedException();

        public bool IsFull => throw new NotImplementedException();

        public QueueString(int initialSize = 10)
        {
            throw new NotImplementedException();
        }

        public void Enqueue(string newValue)
        {
            throw new NotImplementedException();
        }

        public string Dequeue()
        {
            throw new NotImplementedException();
        }


        private void ResizeArray()
        {
            throw new NotImplementedException();
        }

        private void ReorderArray()
        {
            throw new NotImplementedException();
        }
    }
}
