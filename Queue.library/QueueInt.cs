namespace Queue.library
{
    public class QueueInt
    {
        #region OEFENING 1

        // voegt een getal toe aan de stack tot als deze vol is.
        //negeer de waarde als de stack vol is.
        public void Enqueue(int newValue)
        {
            throw new NotImplementedException();
        }

        // haalt het laatste getal van de stack en geeft deze waarde terug.
        //geef int.MinValue terug als de stack leeg is.
        public int Dequeue()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region OEFENING 2
        // vul de properties IsEmpty en IsFull in.
        // roep de properties IsEmpty en IsFull aan waar nodig in de functies Push() en Pop(), zodat je een InvalidOperationException toont wanneer de array vol of leeg is.

        // geeft true terug als de stack leeg is, anders false.
        public bool IsEmpty => throw new NotImplementedException();

        // geeft true terug als de stack vol is, anders false.
        public bool IsFull => throw new NotImplementedException();

        public int Length => throw new NotImplementedException();

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
        }

        // maakt de array dubbel zo groot.
        private void ResizeArray()
        {
            throw new NotImplementedException();
        }

        private void ReorderArray()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
