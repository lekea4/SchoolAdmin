using SchoolAdmin.LookUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Facilities
{


    //public delegate void BookAddedEventHandler(object source, BookEventArgs args);

    public class LibraryCatalog
    {



        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime DateAdded { get; set;  }























        //  public event BookAddedEventHandler BookAdded;

        //public EventHandler<BookEventArgs> BookAdded;

        //private List<Book> bookList;

        //public LibraryCatalog()
        //{
        //    bookList = new List<Book>();
        //}


        //protected virtual void OnBookAdded(object source, BookEventArgs args)
        //{
        //    // checks if subscribers exist for this event, raise the event

        //    if (BookAdded != null)
        //    {
        //        Console.WriteLine($"BookAdded Event fired. Number of subscribers: {BookAdded.GetInvocationList().Length}");
        //        BookAdded(this, args);
        //    }

        //    else
        //    {
        //        Console.WriteLine("Book Added event was not fired and no subscribers yet");
        //    }
        //}

        //public void AddBook(Book newBook)
        //{
        //    bookList.Add(newBook);

        //    OnBookAdded(this, new BookEventArgs
        //    {
        //        Title = newBook.Title,
        //        Author = newBook.Author,
        //        TimeAdded = DateTime.Now
        //    });
        //}
    }

    //public class BookEventArgs : EventArgs
    //{
    //    public string Title;

    //    public string Author;

    //    public DateTime TimeAdded;

    //}

}
