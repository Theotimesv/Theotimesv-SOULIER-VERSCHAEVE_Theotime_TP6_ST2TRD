namespace TP6.IteratorDesignPattern
{
    interface AbstractIterator
    {
        Book Root();
        Book Next();
        bool IsCompleted { get; }
    }
    
    class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int currentbook = 0;
        private int step = 1;
        // Constructor
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        // Gets first item
        public Book Root()
        {
            currentbook = 0;
            return collection.GetBook(currentbook);
        }
        // Gets next item
        public Book Next()
        {
            currentbook += step;
            if (!IsCompleted)
            {
                return collection.GetBook(currentbook);
            }
            else
            {
                return null;
            }
        }
        public bool IsCompleted
        {
            get { return currentbook >= collection.Count; }
        }
    }
}