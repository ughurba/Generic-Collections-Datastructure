namespace Generic_Collections_Datastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(5); // book limiti 


            Book book = new Book("Sahil", 1000, "Ibrahim", 50);
            Book book2 = new Book("Remiz", 1000, "Zahir", 35);
            Book book3 = new Book("Efqan", 100, "Qedim", 40);
            Book book4 = new Book("Ruhin", 100, "Ramiz", 150);
            Book book5 = new Book("Afet", 100, "Akif", 100);
            //Book book6 = new Book("Afet", 100, "Akif", 100);

            //Add methodu iwdeyir
            library.AddBook(book);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            //library.AddBook(book6); - book limiti awir

            //ShowInfo iwleyir
            book.ShowInfo();
            book2.ShowInfo();
            book3.ShowInfo();
            book4.ShowInfo();
            book5.ShowInfo();
            //Sell iwleyir
            book.Sell();
            book2.Sell();
            book3.Sell();
            book4.Sell();
            book5.Sell();

            //   book5.Sell(); - burda exception tutur  cunki count uje 0 



            //id Verirem ve mene hemen id-li booku verir
            library.GetBookById(2);
            library.GetBookById(3);
            //library.GetBookById(null); - exception tutur saxlayir





            library.RemoveById(3); // 3-idli book silindi
            //library.RemoveById(null); //NullReferenceException: Object reference not set to an instance of an object.
            library.RemoveById(6); // NotFoundException: bele bir id kitab yoxdur


            library.GetBookById(3); // 3-idli kitabi gorsetmir cunki silinib 









        }


    }
}
