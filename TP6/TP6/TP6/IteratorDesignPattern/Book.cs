namespace TP6.IteratorDesignPattern
{
    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public Book(string title, int bookId)
        {
            Title = title;
            BookId = bookId;
        }
    }
}