using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class BookShop
    {
        string name;
        string address;
        Book[] bookList = new Book[1000];
        int totalBookCopyCount = 0;

        public BookShop() { }
        public BookShop(string name, string address,int totalBookCopyCount)
        {
            this.name = name;
            this.address = address;
            this.totalBookCopyCount = totalBookCopyCount;
        }
        public void showBookShopInfo()
        {
            Console.WriteLine($"Name: {name}\nAddress: {address}\nTotal Copy of Books: {totalBookCopyCount}");
            Console.WriteLine("-----------------------------------------");
        }
        public void searchBook(Book b) {
            Console.Write("Search Status: ");
            bool flag = false;
            for (int i=0; i<bookList.Length; i++)
            {
                if (bookList[i] == b)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
                Console.WriteLine("404 Not Found");
            else
                Console.WriteLine("Found");

        }
        public void buyNewBook(Book b) {
            //var extra = new List<Book>(bookList);
            //extra.Add(b);
            //bookList = extra.ToArray();
            if (totalBookCopyCount < bookList.Length)
            {
                bookList[totalBookCopyCount++] = b;
            }
            else
                Console.WriteLine("Library is Full");
        }
        public void addExistingBook(Book b, int qty)
        {
            for(int i=0; i<bookList.Length; i++)
            {
                if (bookList[i] == b)
                {
                    totalBookCopyCount += qty;
                }
            }
        }
        public void sellBook(Book b, int qty)
        {
            Console.WriteLine($"Selling Book: {b.Title}");
            deleteExistingBook(b);
            totalBookCopyCount -= qty;
        }
        public void deleteExistingBook(Book b) {
            var extra = new List<Book>(bookList);
            for (int i = 0; i < bookList.Length; i++)
            {
                if (b == bookList[i])
                {
                    extra.RemoveAt(i);
                }
            }
            bookList = extra.ToArray();
        }
    }
}
