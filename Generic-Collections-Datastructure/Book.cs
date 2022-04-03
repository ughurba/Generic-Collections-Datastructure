using Generic_Collections_Datastructure.MyCustomException;
using System;

namespace Generic_Collections_Datastructure
{
    public class Book : Product
    {
        // Book class (Product-dan miras alır)
        //- AuthorName
        //- PageCount
        //ShowInfo methodunu override edir və bütün book-un məlumatlarını console-a çıxardır.
        //Sell methodunu override edir və hər dəfə sell methodu işə düşəndə bir ədəd book satılmalıdır count azalır TotalInCome isə artır,
        //əgər Product-ın count-ı sıfır olarsa o zaman ProductCountIsZeroException baş versin və satış baş verməsin.
        //ps: name, price, authorName, pageCount dəyərləri olmadan book obyekti yaratmaq olmaz.
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        
        public Book(string authorName, int pageCount, string name, double price)
        {
            AuthorName = authorName;
            PageCount = pageCount;
            Name = name;
            Price = price;
        }
      
        public override void Sell()
        {
            if (Count == 0)
            {
                throw new ProductCountIsZeroException("productun countu  sifirdir");
                return;
            }
            else
            {
                Count--;
                TotalInCome++;


            }


        }
     
        public override void ShowInfo()
        {
           
                Console.WriteLine($"Id{Id}\nName:{Name}\nAuthorName:{AuthorName}\nPageCount:{PageCount}\nPrice:{Price}");
            
               
            
        }

    }
}
