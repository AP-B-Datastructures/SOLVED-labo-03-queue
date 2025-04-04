namespace Queue.library
{
    public class QueueInt
    {
        #region OEFENING 1
        int[] _data = new int[5];
        int _back = 0;
        int _front = 0;

        // voegt een getal toe aan de stack tot als deze vol is.
        //negeer de waarde als de stack vol is.
        public void Enqueue(int newValue)
        {
            if (IsFull)
            {
                if (this.Length < this._data.Length / 2)
                {
                    ReorderArray();
                }
                else
                {
                    ResizeArray();
                }
            }

            this._data[this._back] = newValue;
            this._back++;
        }

        // haalt het laatste getal van de stack en geeft deze waarde terug.
        //geef int.MinValue terug als de stack leeg is.
        public int Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("ERROR: Can't dequeue an empty queue");
            }
            int result = this._data[this._front];
            this._front++;
            return result;
        }

        #endregion

        #region OEFENING 2
        // vul de properties IsEmpty en IsFull in.
        // roep de properties IsEmpty en IsFull aan waar nodig in de functies Push() en Pop(), zodat je een InvalidOperationException toont wanneer de array vol of leeg is.

        // geeft true terug als de stack leeg is, anders false.
        public bool IsEmpty => this._front == this._back;

        // geeft true terug als de stack vol is, anders false.
        public bool IsFull => this._back >= this._data.Length;

        public int Length => this._back - this._front;

        #endregion

        #region OEFENING 3
        // Vul de functie ResizeArray() in.
        // roep de functie ResizeArray aan vanuit Enqueue, maar enkel wanneer de array vol is. Je moet geen Exception meer tonen als de array vol is.
        // Vul de functie ReorderArray() in.
        // roep de functie ReorderArray() aan vanuit ResizeArray, maar enkel wanneer de start van de queue voorbij de helft van de array staat.

        // constructor die een initiele grootte mee krijgt.
        // - initialSize: de startgrootte van de array voor de stack.
        public QueueInt(int initialSize = 10)
        {
            this._data = new int[initialSize];
        }

        // maakt de array dubbel zo groot.
        private void ResizeArray()
        {
            int[] newDataArray = new int[this._data.Length * 2];

            for (var i = this._front; i < this._back; ++i)
            {
                newDataArray[i] = this._data[i];
            }

            this._data = newDataArray;
        }

        private void ReorderArray()
        {
            for (var i = this._front; i < this._back; ++i)
            {
                this._data[i - this._front] = this._data[i];
            }

            this._back = this._back - this._front;
            this._front = 0;
        }

        #endregion
    }
}
