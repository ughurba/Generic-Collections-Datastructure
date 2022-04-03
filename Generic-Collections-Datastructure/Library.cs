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
            if (BookLimit.Limit(book.Id,BookLimit))
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
            
            try
            {
                foreach (var item in books)
                {
                    if (item.Id == id)
                    {
                        books.Remove(item);
                        Console.WriteLine("Ugurla silindi");
                        Console.WriteLine($"Id{item.Id}\nName:{item.Name}\nAuthorName:{item.AuthorName}\nPageCount:{item.PageCount}\nPrice:{item.Price}");
                        return;
                    }
                }
                
                 
                
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public Book GetBookById(int? id)
        {
            try
            {
                foreach (var item in books)
                {
                    if (item.Id == id)
                    {
                        Console.WriteLine($"Id{item.Id}\nName:{item.Name}\nAuthorName:{item.AuthorName}\nPageCount:{item.PageCount}\nPrice:{item.Price}");
                        return item;
                    }
                }
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }

            return null;



        }

 
    }
}
