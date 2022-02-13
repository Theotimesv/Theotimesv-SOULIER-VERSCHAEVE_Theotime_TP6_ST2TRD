using System.Collections.Generic;

namespace TP6.IteratorDesignPattern
{
    interface AbstractCollection
    {
        Iterator CreateIterator();
    }
    
    class ConcreteCollection : AbstractCollection
    {
        private List<Book> Booklist = new List<Book>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return Booklist.Count; }
        }

        public void AddBook(Book book)
        {
            Booklist.Add(book);
        }

        public Book GetBook(int index)
        {
            return Booklist[index];
        }
    }
}