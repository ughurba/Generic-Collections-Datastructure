using Generic_Collections_Datastructure.MyCustomException;
using System;
using System.Collections.Generic;

namespace Generic_Collections_Datastructure
{
    public class Library
    {


        List<Book> books = new List<Book>();

        public int BookLimit { get; set; }

        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
        }

        public void AddBook(Book book)
        {
            if (BookLimit.Limit(book.Id, BookLimit))
            {
                books.Add(book);


            }
            else
            {
                throw new CapacityLimitException("Book limit awir");
            }
        }

        public void RemoveById(int? id)
        {


            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    Console.WriteLine("**************************");
                    Console.WriteLine();
                    books.Remove(item);
                    Console.WriteLine("Ugurla silindi");
                    Console.WriteLine($"Id{item.Id}\nName:{item.Name}\nAuthorName:{item.AuthorName}\nPageCount:{item.PageCount}\nPrice:{item.Price}");
                    return;
                }
            }
            if (id == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                throw new NotFoundException("bele bir id kitab yoxdur");
            }

        }
        public Book GetBookById(int? id)
        {

            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    Console.WriteLine();
                    Console.WriteLine("*****************");
                    Console.WriteLine($"Id{item.Id}\nName:{item.Name}\nAuthorName:{item.AuthorName}\nPageCount:{item.PageCount}\nPrice:{item.Price}");
                    return item;
                }
            }
            if (id == null)
            {
                throw new NullReferenceException();
            }
            return null;
        }


    }
}
