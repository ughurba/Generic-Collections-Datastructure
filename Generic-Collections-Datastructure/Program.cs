using System;

namespace Generic_Collections_Datastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {



           
            var key  = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Enter:
                  
                    Library library = new Library(SetInfoInt("limit qeyd edin"));
                    
                        Book book = new Book(SetInfo("AuthorName yazin"),
                            SetInfoInt("Sehfeni yazin"),
                             SetInfo("Name yazin"),
                             SetInfoInt("qiymet"));
                        library.AddBook(book);

                        Console.WriteLine();
                        Console.WriteLine("kitab add olundu");
                            book.ShowInfo();

                        
                    
                    while (true)
                    {
                        Console.WriteLine("------MENU-------");
                        Console.WriteLine("\n1.book satmaq\n2.booka id-ile baxmaq\n3.book silmek");
                        int num = Convert.ToInt32(Console.ReadLine());

                        if (num == 2)
                        {
                            library.GetBookById(SetInfoInt("id qeyd edin"));
                        }else if (num == 1)
                        {
                            book.Sell();

                        }
                        else if (num == 3)
                        {
                            library.RemoveById(SetInfoInt("id qeyd edin"));

                        }
                    }
                        break;
                    
            }


        }
      
        public static int SetInfoInt(string str)
        {
            int input;
            Console.WriteLine();
            Console.WriteLine(str);
            input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public static string SetInfo(string str)
        {


            string input;
            Console.WriteLine();
            Console.WriteLine(str);
            input = Console.ReadLine();
            return input;

        }
    }
}
