using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Facilities.SchoolLibrary
{
    class LibraryCatalogQuery
    {
        public IEnumerable<LibraryCatalog> authors = new List<LibraryCatalog>()
        {
            new LibraryCatalog() {Title = "Things Fall Apart", Author ="Chinua Achebe", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "A Tale of Two Cities", Author ="Charles Dickens", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "The Lord of the Rings", Author =" J.R.R. Tolkien", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "The Little Prince", Author ="Antoine de Saint-Exupery", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "Harry Potter and the Sorcerer's Stone", Author ="J.K. Rowling", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "And Then There Were None", Author ="Agatha Christie", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "The Dream of the Red Chamber", Author ="Cao Xueqin", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "The Da Vinci Code", Author ="Dan Brown", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "Anne of Green Gables", Author ="Lucy Maud Montgomery", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "Black Beauty", Author ="Anna Sewell", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "Berenstain Bears series", Author ="Stan and Jan Berenstain", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "Harry Potter and the Sorcerer's Stone", Author ="Stan and Jan Berenstain", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "Harry Potter and the Sorcerer's Stone", Author ="Cao Xueqin", DateAdded=new DateTime(2008, 5, 23)},


            new LibraryCatalog() {Title = "Harry Potter and the Sorcerer's Stone", Author ="Anna Sewell", DateAdded=new DateTime(2008, 5, 23)},

            new LibraryCatalog() {Title = "Harry Potter and the Chamber of Secrets", Author ="J.K. Rowling", DateAdded=new DateTime(2008, 5, 23)},
            
            new LibraryCatalog() {Title = "Harry Potter and the Prisoner of Azkaban", Author ="J.K. Rowling", DateAdded=new DateTime(2008, 5, 23)},
            
            new LibraryCatalog() {Title = "Harry Potter and the Goblet of Fire", Author ="J.K. Rowling", DateAdded=new DateTime(2008, 5, 23)},
            
            new LibraryCatalog() {Title = "Harry Potter and the Order of the Phoenix", Author ="J.K. Rowling", DateAdded=new DateTime(2008, 5, 23)},
           
            new LibraryCatalog() {Title = "Harry Potter and the Half-Blood Prince", Author ="J.K. Rowling", DateAdded=new DateTime(2008, 5, 23)},
           
            new LibraryCatalog() {Title = "Harry Potter and the Deathly Hallows", Author ="J.K. Rowling", DateAdded=new DateTime(2008, 5, 23)},


            new LibraryCatalog() {Title = "Think and Grow Rich", Author ="Napoleon Hill", DateAdded=new DateTime(2008, 5, 23)}

        };

        /*QUERY EXPECTATIONS 

             Ability to fetch all books in the library, sorted by title in ascending order.
            Ability to fetch all books in the library, sorted by title in ascending order, followed by author in descending order.
            Ability to fetch all books written by a specified author.
            Ability to fetch the title and author of any book whose title or author name contains a given string value. The returned values should be in uppercase.
            Ability to obtain a count of books written by each author. */



        //QUERY SYNTAX 

        //1. Ability to fetch all books in the library, sorted by title in ascending order.

         public  void GetBooksInAscendingOrder1()
        {
            IEnumerable<LibraryCatalog> ascendingOrderSortQuery = from author in authors
                                                                  orderby author.Title
                                                                  select author;

            Console.WriteLine("\n\nList of books sorted by title in ascending order");

            Console.WriteLine("\n\nTitle\t\t\t\t\t\t\tAuthor\t\t\t\t\tDate Added\n");

            foreach (LibraryCatalog item in ascendingOrderSortQuery)
            {
                Console.WriteLine($"{item.Title}\t\t\t\t{item.Author}\t\t\t\t{item.DateAdded.ToShortDateString()}");
            }

        }


        // 2.Ability to fetch all books in the library, sorted by title in ascending order, followed by author in descending order.


        public void GetBooksTitleAndAuthor1()
        {
            IEnumerable<LibraryCatalog> ascendingTitleDescendingAuthorQuery = from author in authors
                                                                              orderby author.Title, author.Author descending
                                                                              select author;


            Console.WriteLine("\n\nList of books sorted by title in ascending order");

            Console.WriteLine("\n\nTitle\t\t\t\t\t\tAuthor\t\t\t\tDate Added\n");

            foreach (LibraryCatalog item in ascendingTitleDescendingAuthorQuery)
            {
                Console.WriteLine($"{item.Title}\t\t\t\t{item.Author}\t\t\t\t{item.DateAdded.ToShortDateString()}");
            }

        }


        // 3. Ability to fetch all books written by a specified author.

        public void GetBookByAuthor1()
        {
            IEnumerable<LibraryCatalog> booksBySprcificAuthorQuery = from author in authors
                                                                     where author.Author == "J.K. Rowling"
                                                                     select author;

            Console.WriteLine("The list of books by J.K. Rowling are listed below");

            foreach (LibraryCatalog item in booksBySprcificAuthorQuery)
            {
                Console.WriteLine($"{item.Title} {item.Author}");
            }

        }


        // 4.   Ability to fetch the title and author of any book whose title or author name contains a given string value. The returned values should be in uppercase.





        //METHOD SYNTAX 
        //1. Ability to fetch all books in the library, sorted by title in ascending order.

        public void GetBooksInAscendingOrder2()
        {
            IEnumerable<LibraryCatalog> ascendingOrderSortQuery = authors.OrderBy(a => authors);

            Console.WriteLine("\n\n\nList of books sorted by title in ascending order");

            Console.WriteLine("\n\nTitle\t\t\t\t\t\t\tAuthor\t\t\t\t\tDate Added\n");

            foreach (LibraryCatalog item in ascendingOrderSortQuery)
            {
                Console.WriteLine($"{item.Title}\t\t\t\t{item.Author}\t\t\t\t{item.DateAdded.ToShortDateString()}");
            }
        }


       // 2.Ability to fetch all books in the library, sorted by title in ascending order, followed by author in descending order.


        public void GetBooksTitleAndAuthor2()
        {
            IEnumerable<LibraryCatalog> ascendingTitleDescendingAuthorQuery = authors.OrderBy(a => a.Title)
                .ThenByDescending(a => a.Author);


            Console.WriteLine("\n\nList of books sorted by title in ascending order");

            Console.WriteLine("\n\nTitle\t\t\t\t\t\tAuthor\t\t\t\tDate Added\n");

            foreach (LibraryCatalog item in ascendingTitleDescendingAuthorQuery)
            {
                Console.WriteLine($"{item.Title}\t\t\t\t{item.Author}\t\t\t\t{item.DateAdded.ToShortDateString()}");
            }

        }


        // 3. Ability to fetch all books written by a specified author.

        public void GetBookByAuthor2()
        {
            IEnumerable<LibraryCatalog> booksBySprcificAuthorQuery = authors.Where(a => a.Author == "J.K. Rowling");

            Console.WriteLine("The list of books by J.K. Rowling are listed below");

            foreach (LibraryCatalog item in booksBySprcificAuthorQuery)
            {
                Console.WriteLine($"{item.Title} {item.Author}");
            }

        }


        // 4.   Ability to fetch the title and author of any book whose title or author name contains a given string value. The returned values should be in uppercase.


    }
}
