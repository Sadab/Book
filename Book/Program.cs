using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            Book b1 = new Book("Batman", "No", "100", 2017, 10, 2);
            Book b2 = new Book("Superman", "Yes", "200", 2016, 20, 5);
            Book b3 = new Book("Ironman", "Oh Yes", "300", 2015, 30,5);
            Book b4 = new Book("Naruto", "Oh Yes No", "400", 2014, 40, 7);

            //For B1
            Console.WriteLine(b1.Title);
            Console.WriteLine(b1.AuthorName);
            Console.WriteLine(b1.ISSBN);
            Console.WriteLine(b1.YearOfPublication);
            Console.WriteLine(b1.Price);
            Console.WriteLine(b1.NumberOfCopy);

            //For B2
            Console.WriteLine(b2.Title);
            Console.WriteLine(b2.AuthorName);
            Console.WriteLine(b2.ISSBN);
            Console.WriteLine(b2.YearOfPublication);
            Console.WriteLine(b2.Price);
            Console.WriteLine(b2.NumberOfCopy);

            b3.showBookInfo();
            b4.showBookInfo();

            BookShop bs = new BookShop("National Book Store", "Mongol Groho", 0);

            bs.showBookShopInfo();

            bs.buyNewBook(b1);
            bs.buyNewBook(b2);
            bs.buyNewBook(b3);

            bs.showBookShopInfo();

            bs.addExistingBook(b1, 10);
            bs.showBookShopInfo();
            bs.sellBook(b3, 5);
            bs.showBookShopInfo();
            bs.deleteExistingBook(b2);
            bs.searchBook(b2);
            bs.buyNewBook(b4);
            bs.searchBook(b3);

        }
    }
}
