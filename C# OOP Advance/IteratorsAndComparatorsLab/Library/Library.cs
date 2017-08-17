using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    private SortedSet<Book> books;
    private int currentIndex;

    public Library(params Book[] book)
    {
        this.books = new SortedSet<Book>(book, new BookComparator());
        this.currentIndex = 0;
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }


        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return (++currentIndex) < books.Count;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }

        public Book Current { get { return this.books[this.currentIndex]; } }

        object IEnumerator.Current
        {
            get { return this.Current; }
        }
    }
}
