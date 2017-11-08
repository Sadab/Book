using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        string title;
        string authorName;
        string issbn;
        int yearOfPublication;
        double price;
        int numberOfCopy;

        public Book() { }
        public Book(string title, string authorName, string issbn, int yearOfPublication, double price, int numberOfCopy)
        {
            this.title = title;
            this.authorName = authorName;
            this.issbn = issbn;
            this.yearOfPublication = yearOfPublication;
            this.price = price;
            this.numberOfCopy = numberOfCopy;
        }
        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }
        public string AuthorName
        {
            get { return authorName; }
            set { this.authorName = value; }
        }
        public string ISSBN
        {
            get { return issbn; }
            set { this.issbn = value; }
        }
        public int YearOfPublication
        {
            get { return yearOfPublication; }
            set { this.yearOfPublication = value; }
        }
        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }
        public int NumberOfCopy
        {
            get { return numberOfCopy; }
            set { this.numberOfCopy = value; }
        }
        public void showBookInfo()
        {
            Console.WriteLine($"Title: {title}\nAuthor Name: {authorName}\nIssbn: {issbn}\nYear Of Publication: {yearOfPublication}\nPrice: {price}\nNumber Of Copy: {numberOfCopy}\n");
        }
    }
}
