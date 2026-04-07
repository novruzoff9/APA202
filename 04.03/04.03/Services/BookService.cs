using _04._03.Enums;
using _04._03.Exceptions;
using _04._03.Interfaces;
using _04._03.Models;
using System.Text.Json;

namespace _04._03.Services
{
    internal class BookService : IBookService
    {
        private static string _filePath = "C:\\Users\\User\\Desktop\\APA202\\04.03\\04.03\\Data.json";
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
        public  List<Book> GetByGenre(Genre genre)
        {
            return Books.FindAll(i => i.Genre == genre);
           
        }
        public Book GetMostExpensiveBook()
        {
          return Books.MaxBy(i => i.Price);
        }
        public Book GetCheapestBook()
        {
            return Books.MinBy(i => i.Price);
        }
        public decimal GetAveragePrice()
        {
            return Books.Average(i => i.Price);
        }
        public int CountByGenre(Genre genre)
        {
            return Books.Count(i => i.Genre==genre);
        }
        public List<Book > GetByPriceRang(double min, double max)
        {
            return Books.FindAll(i => i.Price > (decimal)min && i.Price <(decimal) max);
        }

        public void WriteToFile()
        {
            using FileStream fileStream = new FileStream(_filePath, FileMode.Create);
            using StreamWriter streamWriter = new StreamWriter(fileStream);

            string json = JsonSerializer.Serialize(Books);

            streamWriter.Write(json);
            Console.WriteLine("Listimiz dataya cevrildi");
        }

        public void ReadFromFile()
        {
            using FileStream fileStream = new FileStream(_filePath, FileMode.Open);
            using StreamReader streamReader = new StreamReader(fileStream);

            string json = streamReader.ReadToEnd();

            Books = JsonSerializer.Deserialize<List<Book>>(json);
        }
    }
}
