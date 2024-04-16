using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository
    {
        Book book;
        private List<Book> books = new List<Book> ();
        public List<Book> AddBook(Book book)
        {
            //book = new Book();
            books.Add(book);
            return books;
        }
        public Book GetBook(string itemId)
        {
            foreach (var book in books)
            {
                if (book.ItemId == itemId)
                {
                    return book;
                    break;
                }
            }
            return book;
        }
        public double GetTotalValue()
        {
            double value = 0;
            double totalValue = 0;
            foreach (var book in books)
            {
                value = Utility.GetValueOfBook(book);
                totalValue = totalValue + value;
            }
            return totalValue;
        }
    }
}
