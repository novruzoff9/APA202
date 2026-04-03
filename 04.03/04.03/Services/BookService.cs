using _04._03.Exceptions;
using _04._03.Interfaces;
using _04._03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03.Services
{
    internal class BookService : IBookService
    {
        public static List<Book> Books = [];
        public void Add(Book book)
        {
            var exsistBook = Books.Find(x => x.Title == book.Title);
            if (exsistBook==null)
            {
                Books.Add(book);
            }
            else
            {
                throw new ConflictExceptions();
            }

            //foreach (var item in Books)
            //{
            //    if (item.Title == book.Title)
            //        exsistBook = item;
            //}
        }

        public Book GetById(int id)
        {
            var existId = Books.Find(i => i.Id == id);
            if (existId==null)
            {
                throw new NotFoundExceptions();
            }
            return existId;
        }
    }
}
